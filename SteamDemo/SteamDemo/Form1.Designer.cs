namespace SteamDemo
{
    

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DownloadSPeedOn = new Button();
            label1 = new Label();
            button1 = new Button();
            PathChange = new Button();
            textBoxPath = new TextBox();
            openFileDialog = new OpenFileDialog();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // DownloadSPeedOn
            // 
            DownloadSPeedOn.Location = new Point(0, 159);
            DownloadSPeedOn.Name = "DownloadSPeedOn";
            DownloadSPeedOn.Size = new Size(317, 76);
            DownloadSPeedOn.TabIndex = 0;
            DownloadSPeedOn.Text = "下载Steam++（密码1234）";
            DownloadSPeedOn.UseVisualStyleBackColor = true;
            DownloadSPeedOn.Click += DownloadSPeedOn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 6);
            label1.Name = "label1";
            label1.Size = new Size(104, 17);
            label1.TabIndex = 1;
            label1.Text = "Steam手残下载器";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(323, 191);
            button1.Name = "button1";
            button1.Size = new Size(123, 44);
            button1.TabIndex = 2;
            button1.Text = "快速打开Steam++";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PathChange
            // 
            PathChange.Location = new Point(323, 159);
            PathChange.Name = "PathChange";
            PathChange.Size = new Size(123, 33);
            PathChange.TabIndex = 3;
            PathChange.Text = "此处选择打开路径";
            PathChange.UseVisualStyleBackColor = true;
            PathChange.Click += PathChange_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.BackColor = SystemColors.HotTrack;
            textBoxPath.Enabled = false;
            textBoxPath.ForeColor = SystemColors.Window;
            textBoxPath.Location = new Point(0, 130);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(152, 23);
            textBoxPath.TabIndex = 4;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "(*.exe)|*.exe";
            // 
            // button2
            // 
            button2.Location = new Point(0, 241);
            button2.Name = "button2";
            button2.Size = new Size(446, 65);
            button2.TabIndex = 6;
            button2.Text = "下载Steam（请连接加速器）";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(234, 17);
            label2.TabIndex = 8;
            label2.Text = "开发者:Un_Taimei 非商业用途 项目已开源";
            // 
            // button3
            // 
            button3.Location = new Point(0, 61);
            button3.Name = "button3";
            button3.Size = new Size(152, 63);
            button3.TabIndex = 9;
            button3.Text = "使用前点击查看教程";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 42);
            label3.Name = "label3";
            label3.Size = new Size(404, 17);
            label3.TabIndex = 11;
            label3.Text = "Steam官网和客户端在国内是无法正常连接的所以每次使用请先连接加速器";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 339);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBoxPath);
            Controls.Add(PathChange);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(DownloadSPeedOn);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DownloadSPeedOn;
        private Label label1;
        private Button button1;
        private Button PathChange;
        private TextBox textBoxPath;
        private OpenFileDialog openFileDialog;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
    }
}
