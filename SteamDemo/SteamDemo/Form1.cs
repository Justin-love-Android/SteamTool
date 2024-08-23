
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace SteamDemo
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }




        private void DownloadSPeedOn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://wwn.lanzouy.com/iaB8726vwkah",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开浏览器: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string Path = openFileDialog.FileName;
            if (string.IsNullOrEmpty(Path))
            {
                MessageBox.Show("你没有选择路径");
                return;
            }
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Path,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PathChange_Click(object sender, EventArgs e)
        {
            // 显示对话框并检查用户是否选择了文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                string selectedFilePath = openFileDialog.FileName;

                // 在文本框中显示选择的路径
                textBoxPath.Text = selectedFilePath;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            
        }
    }
}

