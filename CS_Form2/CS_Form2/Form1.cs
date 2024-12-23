﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form2
{
    public partial class Form1 : Form
    {


        //画像ファイルを読み込む
        Image currentImage1 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\グー.png");
        Image currentImage2 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\チョキ.png");
        Image currentImage3 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\パー.png");
        public Form1()
        {
            InitializeComponent();


        }


       



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage1 != null)
            {
                //　画像を0,0に描画する
                e.Graphics.DrawImage(currentImage1,
                    0, 0, currentImage1.Width, currentImage1.Height);

            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage2 != null)
            {
                e.Graphics.DrawImage(currentImage2,
                    0, 0, currentImage2.Width, currentImage2.Height);

            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage3 != null)
            {

                e.Graphics.DrawImage(currentImage3,
                    0, 0, currentImage3.Width, currentImage3.Height);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("グー");
            Progress("グー");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Progress("チョキ");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Progress("パー");
        }

        private string GetCpuHand()
        {
        Random random = new Random();
            int num = random.Next(3);
            string hand = "";
            if (num == 0)
            {
                hand = "グー";
            }
            else if (num == 1) 
            {
                hand = "チョキ";
            }
            else 
            {
                hand = "パー";
            }
            return hand;
        }
        private string Decides(string playerHand, string cpuHand)///playerの手とcpuの手を確認して勝敗を判定する
        {
            string result = "";

            if (playerHand == "グー")          ///グーを出したとき
            {
                if (cpuHand == "グー")
                {
                    result = "DRAW　引き分けです";
                }
                else if (cpuHand == "チョキ")
                {
                    result = "WIN　あなたの勝利です。おめでとう！";
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                }
            }
            else if(playerHand == "チョキ")    ///チョキを出したとき　
            {
                if (cpuHand == "チョキ")
                {
                    result = "DRAW　引き分けです";
                }
                else if (cpuHand == "パー")
                {
                    result = "WIN　あなたの勝利です。おめでとう！";
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                }
            }
            else                                ///パーを出したとき
            {

                if (cpuHand == "パー")
                {
                    result = "DRAW　引き分けです";
                }
                else if (cpuHand == "グー")
                {
                    result = "WIN　あなたの勝利です。おめでとう！　";
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                }
            }
            return result;
        }

        private void Progress(string playerHand)
        {
            string cpuHand = GetCpuHand();

            string result = Decides(playerHand, cpuHand);

            labelPLAYER.Text = playerHand;
            labelCPU.Text = cpuHand;

            MessageBox.Show(result);

            labelPLAYER.Text = ("グー、チョキ、パー");
            labelCPU.Text = ("グー、チョキ、パー");

        }

       
    }

}


