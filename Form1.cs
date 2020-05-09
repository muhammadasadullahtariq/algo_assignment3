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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        bool caseFlag, wordFlag;
        int row, column, lengthOfString, count;
        string findstr,text,text1;
        public Form1()
        {
            InitializeComponent();
            caseFlag = wordFlag = false;
            text = "";
            row = column = 0;
            findstr = "";
        }

        public Form1(String asd)
        {
            InitializeComponent();
            caseFlag = wordFlag = false;
            text =text1= asd;
            count = 0;
            lengthOfString = text.Length;
            row = column = 0;
            findstr = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (matchWholeWordCheBox.Checked)
            {
                wordFlag = true;
            }
            else
                wordFlag = false;
            if (matchCaseCheBox.Checked)
            {
                caseFlag = true;
            }
            else
            {
                caseFlag = false;
            }
            bruteForce();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void findWhattextBox_TextChanged(object sender, EventArgs e)
        {
            findstr = findWhattextBox.Text;
        }

        private void matchWholeWordCheBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void matchCaseCheBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            count = row = column = 0;
            this.Close();
        }

        void print(int i)
        {
            i -= findstr.Length;
            string result = "";
            for (int j = i + 1;j<lengthOfString;j++)
            {
                result += text[j];
                if (text1[j]==' '|| text1[j] == '\n')
                {
                    break;
                }
            }
            MessageBox.Show("Found " + result + " at row:" + row.ToString() + " column:" + (column-findstr.Length).ToString(), "Word Found", MessageBoxButtons.OK);
        }
        private void bruteForce()
        {
            if (caseFlag == false)
            {
                text = text.ToLower();
                findstr = findstr.ToLower();
            }
            int j = 0,i;
            for (i = count; i < lengthOfString; i++)
            {
                if(text[i]=='\n')
                {
                    row++;
                    column = 0;
                }
                else
                {
                    column++;
                }
                if(text[i]==findstr[j])
                {
                    j++;
                }
                else
                {
                    j = 0;
                }
                if(j==findstr.Length)
                {
                    if(wordFlag==true)
                    {
                        if(i+1==lengthOfString&& text[i - findstr.Length] == ' ')
                        {
                            print(i);
                        }
                        else if(i - findstr.Length==-1&& text[i + 1] == ' ')
                        {
                            print(i);
                        }
                        else if(text[i-findstr.Length]==' '&&text[i+1]==' ')
                        {
                            print(i);
                        }
                    }
                    else if(wordFlag==false&&caseFlag==false)
                    {
                        print(i);
                    }
                    j = 0;
                    count = i;
                    break;
                }
            }
            if (i == lengthOfString)
            {
                MessageBox.Show("File Completely Wisted:", "Info", MessageBoxButtons.OK);
                Environment.Exit(0);
            }
        }
        void output()
        {
            string sh = caseFlag.ToString();
            sh += "\t";
            sh += wordFlag.ToString();
            sh += "\n";
            sh += text;
            sh += "\n";
            sh += findstr;
            sh += "\n";
            MessageBox.Show(sh);
        }
        
    }
}
