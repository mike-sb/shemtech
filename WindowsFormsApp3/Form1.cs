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
        public int t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            type = "JK";
            radioButton1.Checked = true;
            t = 2;
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

            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Rows.Count; j++)
                {
                    dataGridView2.Rows[j].Cells[i].Value = "";
                    dataGridView3.Rows[j].Cells[i].Value = "";
                }
            }


            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                switch (Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value))
                {
                    case 0:
                        dataGridView2.Rows[0].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 1:
                        dataGridView3.Rows[0].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 2:
                        dataGridView2.Rows[0].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 3:
                        dataGridView3.Rows[0].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 4:
                        dataGridView2.Rows[0].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 5:
                        dataGridView3.Rows[0].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 6:
                        dataGridView2.Rows[0].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 7:
                        dataGridView3.Rows[0].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 8:
                        dataGridView2.Rows[1].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 9:
                        dataGridView3.Rows[1].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 10:
                        dataGridView2.Rows[1].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 11:
                        dataGridView3.Rows[1].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 12:
                        dataGridView2.Rows[1].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 13:
                        dataGridView3.Rows[1].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 14:
                        dataGridView2.Rows[1].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 15:
                        dataGridView3.Rows[1].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 16:
                        dataGridView2.Rows[3].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 17:
                        dataGridView3.Rows[3].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 18:
                        dataGridView2.Rows[3].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 19:
                        dataGridView3.Rows[3].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 20:
                        dataGridView2.Rows[3].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 21:
                        dataGridView3.Rows[3].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 22:
                        dataGridView2.Rows[3].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 23:
                        dataGridView3.Rows[3].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 24:

                        dataGridView2.Rows[2].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 25:

                        dataGridView3.Rows[2].Cells[0].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 26:
                        dataGridView2.Rows[2].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 27:

                        dataGridView3.Rows[2].Cells[1].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 28:
                        dataGridView2.Rows[2].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 29:
                        dataGridView3.Rows[2].Cells[3].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 30:
                        dataGridView2.Rows[2].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    case 31:
                        dataGridView3.Rows[2].Cells[2].Value = dataGridView1.Rows[i].Cells[t].Value;
                        break;
                    default:
                        break;
                }

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            t = 3;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            t = 2;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            t = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            t = 5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            t = 6;
        }
    }
}

