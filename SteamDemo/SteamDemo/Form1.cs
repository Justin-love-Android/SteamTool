
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
                MessageBox.Show($"�޷��������: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string Path = openFileDialog.FileName;
            if (string.IsNullOrEmpty(Path))
            {
                MessageBox.Show("��û��ѡ��·��");
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
                MessageBox.Show($"�޷���: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PathChange_Click(object sender, EventArgs e)
        {
            // ��ʾ�Ի��򲢼���û��Ƿ�ѡ�����ļ�
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ��ȡѡ����ļ�·��
                string selectedFilePath = openFileDialog.FileName;

                // ���ı�������ʾѡ���·��
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

