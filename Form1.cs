using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 算数ドリル
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        double noA = 0;
        double noB = 0;
        double noC = 0;
        long mondaiCnt = 0;
        double mondaiMax = 0;
        double seikaiCnt = 0;
        long type = 0;//1:足し算　2:引き算 3:掛け算 4:割り算(割り切れない、小数点以下の問題で未実装)
        double PercentageOfCorrectAnswers = 0;
        string TypeStr;//演算記号表示用

        public Form1()
        {
            InitializeComponent();
        }

        private void InBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||e.KeyChar>'9')&&(e.KeyChar!='\b'))
            {
                if(!(e.KeyChar=='-'&&InBox.TextLength==0))
                {
                    e.Handled = true;//いま入力されたものを無視する
                }
                
            }
            if((e.KeyChar == (char)Keys.Enter)&&(InBox.Text!="")&&InBox.Text!="-")
            {
                Console.WriteLine(InBox.Text);
                //OutBox.AppendText(InBox.Text+"\r\n");
                Kotaeawase();
                InBox.Text = "";
                if(mondaiCnt<mondaiMax)
                {
                    MondaiSakusei();
                }
                else
                {
                    Seiseki();
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InBox.Enabled = false;
            RBwaru.Enabled = false;
        }

        private void MondaiSakusei()
        {
            noA = rand.Next(1, 10);
            noB = rand.Next(1, 10);
            mondaicount.Text = "現在は" + (mondaiCnt+1) + "問目です。";
            mondaiLbl2.Text =noA + TypeStr + noB + " = ";
            if(type==1)
            {
                noC = noA + noB;
            }
            if(type==2)
            {
                noC = noA - noB;
            }
            if(type==3)
            {
                noC = noA * noB;
            }
            if(type==4)
            {
                noC = noA / noB;
            }
            
            mondaiCnt++;
        }

        private void Kotaeawase()
        {
            if(noC==Int64.Parse(InBox.Text))
            {
                OutBox.AppendText("○ ");
                seikaiCnt++;
            }
            else
            {
                OutBox.AppendText("× ");
            }
            OutBox.AppendText(mondaiLbl2.Text + InBox.Text + "\r\n");
        }

        private void Seiseki()
        {
            InBox.Enabled = false;
            mondaiLbl2.Text = "";//問題の表示をクリア
            OutBox.AppendText("正解数は" + seikaiCnt + "です。");
            PercentageOfCorrectAnswers = seikaiCnt/mondaiMax*100;
            OutBox.AppendText("正答率は" + PercentageOfCorrectAnswers + " % です。");
            StartButton.Text = "開　始";
        }


        private void OutBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            if (RB10.Checked)
            {
                mondaiMax = 10;
            }
            if (RB20.Checked)
            {
                mondaiMax = 20;
            }
            if (RB30.Checked)
            {
                mondaiMax = 30;
            }

            if (RBtasu.Checked)
            {
                type = 1;
                TypeStr = " + ";
            }
            if (RBhiku.Checked)
            {
                type = 2;
                TypeStr = " - ";
            }
            if (RBkakeru.Checked)
            {
                type = 3;
                TypeStr = " × ";
            }
            if (RBwaru.Checked)
            {
                type = 4;
                TypeStr = " ÷ ";
            }
            mondaiCnt = 0;
            seikaiCnt = 0;
            MondaiSakusei();
            InBox.Enabled = true;
            InBox.Focus();
            StartButton.Text = "リセット";

            
        }

       

        private void Type_Enter(object sender, EventArgs e)
        {

        }

        private void mondaiLbl2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RBtasu_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void RBhiku_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RB20_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
