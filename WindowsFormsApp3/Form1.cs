using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string type;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            type = "JK";
            radioButton1.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "JK";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "T";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            type = "D";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "JK")
            {
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    string str1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string str2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    char[] s1 = str1.ToCharArray();
                    char[] s2 = str2.ToCharArray();
                    for (int j = 0; j <= s1.Length-1; j++)
                    {
                        int jj = j;
                        if(s1[j] =='0'&&s2[j] =='0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "0/-";
                        }
                        if (s1[j] == '0' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "1/-";
                        }
                        if (s1[j] == '1' && s2[j] == '0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = " -/1";
                        }
                        if (s1[j] == '1' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "-/0";
                        }

                    }
                }
               
            }
            if (type == "T")
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string str1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string str2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    char[] s1 = str1.ToCharArray();
                    char[] s2 = str2.ToCharArray();
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s1[j] == '0' && s2[j] == '0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "0";
                        }
                        if (s1[j] == '0' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "1";
                        }
                        if (s1[j] == '1' && s2[j] == '0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "1";
                        }
                        if (s1[j] == '1' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "0";
                        }
                    }
                }
            }
            if (type == "D")
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    string str1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string str2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    char[] s1 = str1.ToCharArray();
                    char[] s2 = str2.ToCharArray();
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s1[j] == '0' && s2[j] == '0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "0/-";
                        }
                        if (s1[j] == '0' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "1/-";
                        }
                        if (s1[j] == '1' && s2[j] == '0')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "0";
                        }
                        if (s1[j] == '1' && s2[j] == '1')
                        {
                            dataGridView1.Rows[i].Cells[j + 2].Value = "1";
                        }
                    }
                }
            }
        }
    }
}

