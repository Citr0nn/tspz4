using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadImage();
        }

        private void buttoninfo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Используйте ShowDialog(), если хотите модальное окно
        }
        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonrun_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadImage()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Alex\source\repos\WindowsFormsApp3\png.png");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                double fileSize = double.Parse(txtFileSize.Text);
                double resultInBytes = 0;

                if (rbGB.Checked)
                    resultInBytes = fileSize * Math.Pow(1024, 3); // Гигабайты в байты
                else if (rbMB.Checked)
                    resultInBytes = fileSize * Math.Pow(1024, 2); // Мегабайты в байты
                else if (rbKB.Checked)
                    resultInBytes = fileSize * 1024; // Килобайты в байты
                else if (rbBytes.Checked)
                    resultInBytes = fileSize; // Уже в байтах

                lblBytesResult.Text = resultInBytes.ToString();
                lblBytesResult.ForeColor = System.Drawing.Color.Black;
            }
            catch
            {
                // Некорректный ввод
                lblBytesResult.Text = "0";
                lblBytesResult.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
