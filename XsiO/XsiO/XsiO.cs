using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XsiO
{
    public partial class XsiO : Form
    {
        private int scoreJucator1;
        private int scoreJucator2;
        private int scoreEgalitate;
        private int tura;
        private String user1;
        private String user2;
        private String a1, a2, a3, a4, a5, a6, a7, a8, a9;
        public XsiO(string user1, string user2)
        {


            InitializeComponent();
            Form1 f = new Form1();
            tura = 0;
            this.user1 = user1;
            this.user2 = user2;
            label1.Text = user1;
            label2.Text = user2;
            scoreJucator1 = 0;
            scoreJucator2 = 0;
            scoreEgalitate = 0;
            

            

        }
        private void XsiO_Load(object slender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.White;
                button1.Font = new Font("Arial", 12, FontStyle.Bold);
                button1.Text = "X";
                button1.Enabled = false;
                tura++;

            } else if (tura == 1)
            {
                button1.BackColor = Color.Blue;
                button1.ForeColor = Color.White;
                button1.Font = new Font("Arial", 12, FontStyle.Bold);
                button1.Text = "O";
                button1.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (tura == 0)
            {
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
                button2.Font = new Font("Arial", 12, FontStyle.Bold);
                button2.Text = "X";
                button2.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button2.BackColor = Color.Blue;
                button2.ForeColor = Color.White;
                button2.Font = new Font("Arial", 12, FontStyle.Bold);
                button2.Text = "O";
                button2.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button3.BackColor = Color.Red;
                button3.ForeColor = Color.White;
                button3.Font = new Font("Arial", 12, FontStyle.Bold);
                button3.Text = "X";
                button3.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button3.BackColor = Color.Blue;
                button3.ForeColor = Color.White;
                button3.Font = new Font("Arial", 12, FontStyle.Bold);
                button3.Text = "O";
                button3.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            ResetButoanele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button4.BackColor = Color.Red;
                button4.ForeColor = Color.White;
                button4.Font = new Font("Arial", 12, FontStyle.Bold);
                button4.Text = "X";
                button4.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button4.BackColor = Color.Blue;
                button4.ForeColor = Color.White;
                button4.Font = new Font("Arial", 12, FontStyle.Bold);
                button4.Text = "O";
                button4.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button5.BackColor = Color.Red;
                button5.ForeColor = Color.White;
                button5.Font = new Font("Arial", 12, FontStyle.Bold);
                button5.Text = "X";
                button5.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button5.BackColor = Color.Blue;
                button5.ForeColor = Color.White;
                button5.Font = new Font("Arial", 12, FontStyle.Bold);
                button5.Text = "O";
                button5.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button6.BackColor = Color.Red;
                button6.ForeColor = Color.White;
                button6.Font = new Font("Arial", 12, FontStyle.Bold);
                button6.Text = "X";
                button6.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button6.BackColor = Color.Blue;
                button6.ForeColor = Color.White;
                button6.Font = new Font("Arial", 12, FontStyle.Bold);
                button6.Text = "O";
                button6.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button7.BackColor = Color.Red;
                button7.ForeColor = Color.White;
                button7.Font = new Font("Arial", 12, FontStyle.Bold);
                button7.Text = "X";
                button7.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button7.BackColor = Color.Blue;
                button7.ForeColor = Color.White;
                button7.Font = new Font("Arial", 12, FontStyle.Bold);
                button7.Text = "O";
                button7.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button8.BackColor = Color.Red;
                button8.ForeColor = Color.White;
                button8.Font = new Font("Arial", 12, FontStyle.Bold);
                button8.Text = "X";
                button8.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button8.BackColor = Color.Blue;
                button8.ForeColor = Color.White;
                button8.Font = new Font("Arial", 12, FontStyle.Bold);
                button8.Text = "O";
                button8.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tura == 0)
            {
                button9.BackColor = Color.Red;
                button9.ForeColor = Color.White;
                button9.Font = new Font("Arial", 12, FontStyle.Bold);
                button9.Text = "X";
                button9.Enabled = false;
                tura++;

            }
            else if (tura == 1)
            {
                button9.BackColor = Color.Blue;
                button9.ForeColor = Color.White;
                button9.Font = new Font("Arial", 12, FontStyle.Bold);
                button9.Text = "O";
                button9.Enabled = false; tura++;
            }
            else
            {
                tura = 0;
            }
            CineCatiga();
        }
        private void CineCatiga()
        {
            
           String[,] a;
            String a1 = button1.Text;
            String a2 = button2.Text;
            String a3 = button3.Text;
            String a4 = button4.Text;
            String a5 = button5.Text;
            String a6 = button6.Text;
            String a7 = button7.Text;
            String a8 = button8.Text;
            String a9 = button9.Text;
            
            //if (a1 != "-" && a2 != "-" && a3 != "-" && a4 != "-" && a5 != "-" && a6 != "-" && a7 != "-" && a8 != "-" && a9 != "-")
            //{
            if(a1!="-"&&a5!="-"&&a9!="-")
            {
                if(a1 == "X" && a5 == "X" && a9 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if(a1=="O"&& a5 == "O" && a9 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            if (a1 != "-" && a4 != "-" && a7 != "-")
            {
                if (a1 == "X" && a4 == "X" && a7 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a1 == "O" && a4 == "O" && a7 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            if( a1 != "-" &&a2!="-"&& a3 != "-")
            {
                if (a1 == "X" && a2 == "X" && a3 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                   
                }
                if (a1 == "O" && a2 == "O" && a3 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            if (a4 != "-" && a5 != "-" && a6 != "-")
            {
                if (a4 == "X" && a5 == "X" && a6 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a4 == "O" && a5 == "O" && a6 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            if (a7 != "-" && a8!= "-" && a9 != "-")
            {
                if (a7 == "X" && a8 == "X" && a9 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a7 == "O" && a8 == "O" && a9 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            if (a3 != "-" && a5 != "-" && a7 != "-")
            {
                if (a3 == "X" && a5 == "X" && a7 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a3 == "O" && a5 == "O" && a7 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                   
                }
            }
            if (a2 != "-" && a5 != "-" && a8 != "-")
            {
                if (a2 == "X" && a5 == "X" && a8 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a2 == "O" && a5 == "O" && a8 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }

            if (a3 != "-" && a6 != "-" && a9 != "-")
            {
                if (a3 == "X" && a6 == "X" && a9 == "X")
                {
                    scoreJucator1++;
                    ResetButoanele();
                    tura = 0;
                    
                }
                if (a3 == "O" && a6 == "O" && a9 == "O")
                {
                    scoreJucator2++;
                    ResetButoanele();
                    tura = 0;
                    
                }
            }
            Score1.Text = scoreJucator1.ToString();
            Score2.Text = scoreJucator2.ToString();
            List<String> v = new List<String>();
            v.Add(a1);
            v.Add(a2);
            v.Add(a3);
            v.Add(a4);
            v.Add(a5);
            v.Add(a6);
            v.Add(a7);
            v.Add(a8);
            v.Add(a9);
            int c = 0;
            foreach(String i in v)
            {
                if (i != "-")
                {
                    c++;
                    if (c == 9)
                    {
                        scoreEgalitate++;
                    }
                }
                else
                {
                    continue;
                }
            }
            Score3.Text = scoreEgalitate.ToString();


            //}
            /*a = new String[,]
            {
                {a1,a2,a3 },
                {a4,a5,a6 },
                {a7,a8,a9 }
            };
            
           */
        }
        private void ResetButoanele()
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Font = new Font("Arial", 5, FontStyle.Bold);
            button1.Text = "-";
            button1.Enabled = true;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Font = new Font("Arial", 5, FontStyle.Bold);
            button2.Text = "-";
            button2.Enabled = true;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.Font = new Font("Arial", 5, FontStyle.Bold);
            button3.Text = "-";
            button3.Enabled = true;
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Font = new Font("Arial", 5, FontStyle.Bold);
            button4.Text = "-";
            button4.Enabled = true;
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.Font = new Font("Arial", 5, FontStyle.Bold);
            button5.Text = "-";
            button5.Enabled = true;
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
            button6.Font = new Font("Arial", 5, FontStyle.Bold);
            button6.Text = "-";
            button6.Enabled = true;
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Black;
            button7.Font = new Font("Arial", 5, FontStyle.Bold);
            button7.Text = "-";
            button7.Enabled = true;
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Black;
            button8.Font = new Font("Arial", 5, FontStyle.Bold);
            button8.Text = "-";
            button8.Enabled = true;
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Black;
            button9.Font = new Font("Arial", 5, FontStyle.Bold);
            button9.Text = "-";
            button9.Enabled = true;


        }
    }
}

