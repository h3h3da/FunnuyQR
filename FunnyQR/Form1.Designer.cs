namespace FunnyQR
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backpic = new System.Windows.Forms.PictureBox();
            this.qrpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.RichTextBox();
            this.picselect = new System.Windows.Forms.Button();
            this.qrout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backp = new System.Windows.Forms.Label();
            this.qrp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).BeginInit();
            this.SuspendLayout();
            // 
            // backpic
            // 
            this.backpic.Location = new System.Drawing.Point(12, 218);
            this.backpic.Name = "backpic";
            this.backpic.Size = new System.Drawing.Size(280, 280);
            this.backpic.TabIndex = 0;
            this.backpic.TabStop = false;
            // 
            // qrpic
            // 
            this.qrpic.Location = new System.Drawing.Point(412, 218);
            this.qrpic.Name = "qrpic";
            this.qrpic.Size = new System.Drawing.Size(280, 280);
            this.qrpic.TabIndex = 1;
            this.qrpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入文本信息： ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome To FunnyQR!";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(12, 81);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(680, 96);
            this.txtbox.TabIndex = 4;
            this.txtbox.Text = "";
            // 
            // picselect
            // 
            this.picselect.Location = new System.Drawing.Point(216, 189);
            this.picselect.Name = "picselect";
            this.picselect.Size = new System.Drawing.Size(75, 23);
            this.picselect.TabIndex = 6;
            this.picselect.Text = "选  择";
            this.picselect.UseVisualStyleBackColor = true;
            this.picselect.Click += new System.EventHandler(this.picinput_Click);
            // 
            // qrout
            // 
            this.qrout.Location = new System.Drawing.Point(615, 189);
            this.qrout.Name = "qrout";
            this.qrout.Size = new System.Drawing.Size(75, 23);
            this.qrout.TabIndex = 7;
            this.qrout.Text = "一键生成";
            this.qrout.UseVisualStyleBackColor = true;
            this.qrout.Click += new System.EventHandler(this.qrout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "插入背景：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "二维码：";
            // 
            // backp
            // 
            this.backp.AutoSize = true;
            this.backp.Location = new System.Drawing.Point(10, 501);
            this.backp.Name = "backp";
            this.backp.Size = new System.Drawing.Size(65, 12);
            this.backp.TabIndex = 10;
            this.backp.Text = "图片路径：";
            // 
            // qrp
            // 
            this.qrp.AutoSize = true;
            this.qrp.Location = new System.Drawing.Point(327, 504);
            this.qrp.Name = "qrp";
            this.qrp.Size = new System.Drawing.Size(65, 12);
            this.qrp.TabIndex = 11;
            this.qrp.Text = "保存路径：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Version 1.2.2 beta";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(327, 66);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(316, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "黑  白";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(316, 302);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "彩  色";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(314, 382);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 12);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(314, 354);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(65, 12);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 525);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qrp);
            this.Controls.Add(this.backp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qrout);
            this.Controls.Add(this.picselect);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrpic);
            this.Controls.Add(this.backpic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FunnyQR";
            ((System.ComponentModel.ISupportInitialize)(this.backpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backpic;
        private System.Windows.Forms.PictureBox qrpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtbox;
        private System.Windows.Forms.Button picselect;
        private System.Windows.Forms.Button qrout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label backp;
        private System.Windows.Forms.Label qrp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

