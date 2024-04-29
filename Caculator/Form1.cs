using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        static float a, b;
        static char pheptoan;
        static int cnt = 0;
        static int cntdot = 0;
        static float ketqua;
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cnt <= 1 && cntdot == 0)
            { 
                lbl_hienthi.Text += ".";
                cntdot++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string s = lbl_hienthi.Text;
            if(cnt == 0 && s[s.Length- 1] != '.')
            {
                a = float.Parse(lbl_hienthi.Text);
                lbl_hienthi.Text += "+";
                cntdot = 0;
                pheptoan = '+';
                cnt++;       
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string s = lbl_hienthi.Text;
            if (cnt == 0 && s[s.Length - 1] != '.')
            {
                a = float.Parse(lbl_hienthi.Text);
                cnt++;
                pheptoan = '/';
                cntdot = 0;
                lbl_hienthi.Text += "/";
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string s = lbl_hienthi.Text;
            if (cnt == 0 && s[s.Length - 1] != '.')
            {
                a = float.Parse(lbl_hienthi.Text);
                cnt++;
                pheptoan = '-';
                cntdot = 0;
                lbl_hienthi.Text += "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = lbl_hienthi.Text;
            if (cnt == 0 && s[s.Length - 1] != '.')
            {
                a = float.Parse(lbl_hienthi.Text);
                cnt++;
                cntdot = 0;
                pheptoan = '*';
                lbl_hienthi.Text += "*";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(cnt <= 1)
            lbl_hienthi.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(lbl_ketqua.Text);
            lbl_ketqua.Text = "";
            lbl_hienthi.Text = a.ToString();
            cnt = 0;
            cntdot = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            lbl_hienthi.Text += "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (cnt == 0) return;
            string s = lbl_hienthi.Text;
            int x = s.IndexOf(pheptoan);
            b = float.Parse(s.Substring(x + 1, s.Length - x - 1));
            switch (pheptoan)
            {
                case '+':
                    ketqua = a + b;
                    lbl_ketqua.Text = ketqua.ToString();
                    break;
                case '-':
                    
                    if (s[x] == s[x + 1])
                    {
                        ketqua = a + b;
                    }
                    else
                        ketqua = a - b;
                    lbl_ketqua.Text = ketqua.ToString();
                    break;
                case '*':
                    ketqua = a * b;
                    lbl_ketqua.Text = ketqua.ToString();
                    break;
                case '/':
                    if(b != 0)
                    {
                        ketqua = a / b;
                        lbl_ketqua.Text = ketqua.ToString();
                    }else
                    {
                        lbl_ketqua.Text = "Math error";
                    }
                    break;

            }
            cnt++;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            cnt = 0;
            lbl_ketqua.Text = "";
            lbl_hienthi.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cnt <= 1)
                lbl_hienthi.Text += "7";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string s = lbl_hienthi.Text;
            if (s[s.Length - 1] ==  pheptoan)
            {
                cnt--;
                if (a != Math.Floor(a))
                {
                    cntdot = 1;
                }
            }
            lbl_hienthi.Text = s.Substring(0, s.Length - 1);
        }

        private void lbl_ketqua_Click(object sender, EventArgs e)
        {

        }
    }
}
