using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace algoAssignment3
{
    public partial class Form2 : Form
    {
        private string fileNameStr;
        public String lines;
        public Form2()
        {
            InitializeComponent();
        }

        private void fileNametextBox_TextChanged(object sender, EventArgs e)
        {
            fileNameStr = fileNametextBox.Text;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(fileNameStr);
            openFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameStr = openFileDialog1.FileName;
            }
            openFile();
        }
        void openFile()
        {
            if (File.Exists(fileNameStr))
            {
                try
                {
                    lines = File.ReadAllText(fileNameStr).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                this.Hide();
                Form1 form1 = new Form1(lines);
                form1.ShowDialog();
            }
            else
            {
                //string asd = File.ReadLines(fileNameStr).ToString();
                string msg = "File Not Exist!";
                string tit = "Error";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(msg, tit, btn);
            }
        }
    }
}
