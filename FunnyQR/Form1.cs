using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyQR
{
    public partial class Form1 : Form
    {
        public string picname;
        public string qrpath;
        public Form1()
        {
            InitializeComponent();
            linkLabel2.Hide();
            linkLabel3.Hide();
        }

        private void txtinput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For No.1 test!");
        }

        private void picinput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要插入的图片";
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.Filter = "|*.png||*.jpg||*.jpeg||*.bmp||*.gif||*.svg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;//你选中的图片的绝对路径
                Image tempic;
                tempic = Image.FromFile(path);
                backpic.Image = AdjImageToFitSize(tempic,backpic.Width, backpic.Height);
                //backpic.Image = Image.FromFile(path);
               // MessageBox.Show(path);
                picname = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                qrpath = System.IO.Path.GetDirectoryName(ofd.FileName);
            }
            //ofd.ShowDialog();
            //得到选择文件的路径
            
            backp.Text = ofd.FileName;
          //  linkLabel2.Show();
            
        }
        public static Image AdjImageToFitSize(Image fromImage, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);

            Graphics graphics = Graphics.FromImage(bitmap);
            Point[] destPoints = new Point[] {  
                new Point(0, 0),  
                new Point(width, 0),  
                new Point(0, height)  
            };

            Rectangle rect = GetImageRectangle(fromImage.Width, fromImage.Height);
            graphics.DrawImage(fromImage, destPoints, rect, GraphicsUnit.Pixel);

            Image image = Image.FromHbitmap(bitmap.GetHbitmap());
            bitmap.Dispose();
            graphics.Dispose();
            return image;
        }
        public static Rectangle GetImageRectangle(int w, int h)
        {
            int x = 0;
            int y = 0;

            if (h > w)
            {
                h = w;
                y = (h - w) / 2;
            }
            else
            {
                w = h;
                x = (w - h) / 2;
            }

            return new Rectangle(x, y, w, h);
        }  

        private void qrout_Click(object sender, EventArgs e)
        {

            if (txtbox.Text == "")
            {
                MessageBox.Show("请输入文本信息！");
            }
            else
            {
               Image myimage;
                if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked)
                {
                    MessageBox.Show("请选择二维码颜色！");
                }
                else if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked)
                {
                    MessageBox.Show("请选择一种二维码颜色！");
                }
                else if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Unchecked)
                {
                    string str = "myqr " + txtbox.Text + " -p " + backp.Text + " -n " + qrpath + @"\" + picname + "_qrcode.png -v 5 -l H";

                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                    p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                    p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                    p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                    p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                    p.Start();//启动程序

                    //向cmd窗口发送输入信息
                    p.StandardInput.WriteLine(str + "&exit");

                    p.StandardInput.AutoFlush = true;
                    //p.StandardInput.WriteLine("exit");
                    //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                    //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令



                    //获取cmd窗口的输出信息
                   // string output = p.StandardOutput.ReadToEnd();

                    //txtbox.Text = output;

                    p.WaitForExit();//等待程序执行完退出进程
                    p.Close();
                   // qrpath = Environment.CurrentDirectory;
                   // MessageBox.Show(qrpath + @"\" + picname + "_qrcode.png");
                    myimage = Image.FromFile(qrpath + @"\" + picname + "_qrcode.png");  
                    qrpic.Image = AdjImageToFitSize(myimage,qrpic.Width, qrpic.Height); //350  
                    qrp.Text = qrpath + @"\" + picname + "_qrcode.png";
                    //linkLabel3.Show();
                    
                     
                    
                    //qrpic.Image
                }
                else if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Checked)
                {
                    string str = "myqr " + txtbox.Text + " -p " + backp.Text + " -n " + qrpath + @"\c_" + picname + "_qrcode.png -c -v 5 -l H";

                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
                    p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                    p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                    p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                    p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                    p.Start();//启动程序

                    //向cmd窗口发送输入信息
                    p.StandardInput.WriteLine(str + "&exit");

                    p.StandardInput.AutoFlush = true;
                    //p.StandardInput.WriteLine("exit");
                    //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                    //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令



                    //获取cmd窗口的输出信息
                    //string output = p.StandardOutput.ReadToEnd();

                    //txtbox.Text = output;

                    p.WaitForExit();//等待程序执行完退出进程
                    p.Close();
                    //qrpath = Environment.CurrentDirectory;
                    //MessageBox.Show(picname);
                   // MessageBox.Show(qrpath + @"\c_" + picname + "_qrcode.png");
                    myimage = Image.FromFile(qrpath + @"\c_" + picname + "_qrcode.png");
                    qrpic.Image = AdjImageToFitSize(myimage, qrpic.Width, qrpic.Height); //350  
                    qrp.Text = qrpath + @"\c_" + picname + "_qrcode.png";
                    //linkLabel3.Show();
                    
                }
                
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[0].LinkData = "https://github.com/h3h3da/qrcode";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.linkLabel1.Links[0].LinkData = "file://" + backpicpath.Text;
          //  MessageBox.Show("file://" + backpicpath.Text);
          //  System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // this.linkLabel1.Links[0].LinkData = "file://" + qrpicpath.Text;
            //MessageBox.Show("file://" + qrpicpath.Text);
           // System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        
    }
}
