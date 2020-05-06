using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using WindowsFormsApp1_update_20200410.Properties;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using MetroFramework;
using System.Data;

namespace WindowsFormsApp1_update_20200410
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private System.IO.Ports.SerialPort serialPort = new System.IO.Ports.SerialPort();
        private Ymodem.Ymodem ymodem;
        private Thread downloadThread;
        private Settings settings = new Settings();
        string updateCMD = string.Empty;
        string fileName = string.Empty;


        private void Form1_Load(object sender, EventArgs e)
        {
            // initPort();
            this.pathTextBox.Text = settings.pathlog;
            this.SerialPortComboBox.Text = settings.comlog;
            this.labelFileSize.Text = settings.FileSizelog;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.pathlog = this.pathTextBox.Text;
            settings.comlog = this.SerialPortComboBox.Text;
            settings.FileSizelog = this.labelFileSize.Text;
            settings.Save();
        }

        public void radioBtn_CheckedChange(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text.ToString())
            {
                case "FOH-100":
                    updateCMD = "upgrade\r";//"upgrade ?  \r\n";
                    fileName = "FOH-100";
                    break;
                case "FOH-8":
                    updateCMD = "upgrade\r";
                    fileName = "FOH-8";
                    break;
                case "DWM":
                    updateCMD = "atcmd :FUNC:UPGR\r";
                    fileName = "DWDM";
                    break;
                case "CUSTOM":
                    updateCMD = customTextBox1.Text;
                    fileName = "CUSTOM";
                    break;
                default:
                    break;
            }
        }

        public void initPort()
        {
            this.SerialPortComboBox.Items.Clear();

            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                this.SerialPortComboBox.Items.Add(s);
                this.SerialPortComboBox.Text = this.SerialPortComboBox.Items[0].ToString();
            }
        }
        private void SerialPortComboBox_Click(object sender, EventArgs e)
        {
            initPort();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "Open File")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = fileName + " Update File";
                openFileDialog.Filter = "(*.bin)|*.bin|All files(*.*)|*.*"; // "All files（*.*）|*.*|All files(*.*)|*.* ";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName).ToUpper();//Path.GetExtension(filePath);
                    this.pathTextBox.Text = openFileDialog.FileName.ToString();
                    //System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName); 
                    string filePath = openFileDialog.FileName.ToString();// openFileDialog1.FileName;
                    Regex r = new Regex(fileName);//("DWDM");
                    Match m = r.Match(extName);
                    if (m.Success)// "DWDM.bin")
                    {
                        FileStream fileStream = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
                        int fsLen = 0;
                        fsLen = (int)fileStream.Length;
                        labelFileSize.Text = "File size: " + fsLen.ToString() + " byte" + "\r\n";
                        downloadButton.Enabled = true;
                    }
                    else
                    {
                        downloadButton.Enabled = false;
                        MetroMessageBox.Show(this, "\r\n\r\n" + "Please select a different file type and try again." + "\r\n" 
                            + "e.g.  " + fileName +" ...", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            settings.pathlog = this.pathTextBox.Text;
            settings.comlog = this.SerialPortComboBox.Text;
            settings.FileSizelog = this.labelFileSize.Text;
            settings.Save();

            Regex r = new Regex(fileName);//("DWDM");
            Match m = r.Match(Path.GetFileNameWithoutExtension(pathTextBox.Text.ToUpper()));
            if (m.Success)// "DWDM.bin")
            {
                Button button = (Button)sender;

                if (button.Text == "Update")
                {
                    try
                    {
                        serialPort.PortName = SerialPortComboBox.Text;
                        //  serialPort.BaudRate = Convert.ToInt32(BaudRateComboBox.SelectedItem.ToString());
                        serialPort.BaudRate = 115200;

                        serialPort.Open();
                    }
                    catch   //错误处理
                    {
                        MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    serialPort.Write(updateCMD);//("upgrade\r");          //写数据         foh-100:upgrade ?  \r\n   dwdm:atcmd :FUNC:UPGR\r   foh-8:upgrade\r
                    System.Threading.Thread.Sleep(200);     //延时200ms
                    string str = serialPort.ReadExisting(); //字符串方式读       20200310- "dowload bin file enter 1 \r\nexecute app      enter 2 \r\n-------------------------\r\n\0dowload bin file enter 1 \r\nexecute app      enter 2 \r\n-------------------------\r\n\0"
                    int index = 0;

                    if (updateCMD == "upgrade\r")  //foh-100
                    {
                        index = str.IndexOf("Enter 9", index);
                        if (index < 0)
                        {
                            index = 0;
                            index = str.IndexOf("Enter  1", index);
                            if (index < 0)
                            {
                                MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                                serialPort.Close();
                                return;
                            }
                        }
                        else
                        {
                            serialPort.Write("9");//写数据
                            System.Threading.Thread.Sleep(200);     //延时200ms
                            str = serialPort.ReadExisting();        //字符串方式读
                            index = 0;
                            index = str.IndexOf("Enter  1", index);
                            if (index < 0)
                            {
                                MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                                serialPort.Close();
                                return;
                            }
                        }
                    }

                    else
                    {
                        index = str.IndexOf("enter 0", index);  //"Enter  9"
                        if (index < 0)
                        {
                            index = 0;
                            index = str.IndexOf("enter 1", index);   //"Enter  1"
                            if (index < 0)
                            {
                                MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                                serialPort.Close();
                                return;
                            }
                        }
                        else
                        {
                            serialPort.Write("0");//写数据    //9
                            System.Threading.Thread.Sleep(200);     //延时200ms
                            str = serialPort.ReadExisting();        //字符串方式读
                            index = 0;
                            index = str.IndexOf("enter 1", index);   //"Enter  1"
                            if (index < 0)
                            {
                                MetroMessageBox.Show(this, "\r\n\r\n" + "The equipment was unable to connect. Please check the USB connection", "Error", MessageBoxButtons.OK);
                                serialPort.Close();
                                return;
                            }
                        }
                    }

                    serialPort.Write("1");//写数据  //  1
                    System.Threading.Thread.Sleep(2000);     //延时200ms
                    serialPort.Close();
                    this.circularProgressBar1.Value = 0;   //DownloadProgressBar
                    button.Text = "Updating";
                    ymodem = new Ymodem.Ymodem();
                    ymodem.Path = pathTextBox.Text.ToString();
                    ymodem.PortName = SerialPortComboBox.SelectedItem.ToString();
                    ymodem.BaudRate = 115200;// Convert.ToInt32(BaudRateComboBox.SelectedItem.ToString());
                    downloadThread = new System.Threading.Thread(ymodem.YmodemUploadFile);
                    ymodem.NowDownloadProgressEvent += new EventHandler(NowDownloadProgressEvent);
                    ymodem.DownloadResultEvent += new EventHandler(DownloadFinishEvent);
                    downloadThread.Start();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\r\n\r\n" + "Please select a different file type and try again." + "\r\n"
  + "e.g.  " + fileName + " ...", "Error", MessageBoxButtons.OK);
            }
        }

        #region 下载进度委托及事件响应
        private delegate void NowDownloadProgress(int nowValue);
        private void NowDownloadProgressEvent(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(sender);
            NowDownloadProgress count = new NowDownloadProgress(UploadFileProgress);
            this.Invoke(count, value);
        }
        private void UploadFileProgress(int count)
        {
            // DownloadProgressBar.Value = count;

            circularProgressBar1.Value = count;
            circularProgressBar1.Text = count.ToString();

    
        }
        #endregion
        #region 下载完成委托及事件响应
        private delegate void DownloadFinish(bool finish);
        private void DownloadFinishEvent(object sender, EventArgs e)
        {
            bool finish = (Boolean)sender;
            DownloadFinish status = new DownloadFinish(UploadFileResult);
            this.Invoke(status, finish);
        }
        private void UploadFileResult(bool result)
        {
            if (result == true)
            {
                serialPort.Open();
                if (updateCMD == "upgrade\r") { serialPort.Write("3"); }
                else
                {
                    serialPort.Write("2");//写数据     //3
                }
                serialPort.Write("version\n");  //serialPort.ReadExisting();
                System.Threading.Thread.Sleep(200);     //延时200ms
                MetroMessageBox.Show(this, "\r\n\r\n" + "Update success !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialPort.Close();
                this.downloadButton.Text = "Update";
                // this.circularProgressBar1.Value = 0;   //DownloadProgressBar

            }
            else
            {
                MetroMessageBox.Show(this, "\r\n\r\n" + "Update fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.downloadButton.Text = "Update";
                this.circularProgressBar1.Value = 0;   //DownloadProgressBar
            }
        }
        #endregion


    }
}
