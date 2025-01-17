using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form2
{
    public partial class Form1 : Form
    {
        int gameCount = 0;
        int winCount = 0;
        int drawCount = 0;
        int loseCount = 0;

        //画像ファイルを読み込む
        // Image currentImage1 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\グー.png");
        // Image currentImage2 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\チョキ.png");
        // Image currentImage3 = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\パー.png");


        public Form1()
        {
            InitializeComponent();
            PictureBox1.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\グー.png");
            PictureBox2.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\チョキ.png");
            PictureBox3.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\パー.png");

            PictureBox4.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\グー2.png");
            PictureBox5.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\チョキ2.png");
            PictureBox6.Image = Bitmap.FromFile(@"C:\Users\kai08\Desktop\自由\画像\パー2.png");

            lblGameCount.Text = $"試合回数: {gameCount} 回";
        }
        //12月6日　基本的構造完成
        //次回以降　　勝敗カウント、カウントのリセットボタンを追加
        //
        //12月13日　cpuの画像の挿入
        //終了ボタンの中央ぞろえ
        //
        




        private void button1_Click(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            // 終了確認メッセージを表示
            var result = MessageBox.Show("ゲームを終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ユーザーが「はい」を選択した場合、ゲームを終了
            if (result == DialogResult.Yes)
            {
                var result2 = MessageBox.Show("このゲームが終了してしまいます！本当によろしいですか？", "終了確認の終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Error);//Exclamation

                if (result2 == DialogResult.Yes)
                {
                    Application.Exit(); // アプリケーション終了
                }
            }
        }

        private string GetCpuHand()
        {
            Random random = new Random();
            int num = random.Next(3);
            string hand = "";
            if (num == 0)
            {
                PictureBox5.Visible = false;
                PictureBox6.Visible = false;

                hand = "グー";
                
            }
            else if (num == 1) 
            {
                PictureBox4.Visible = false;
                PictureBox6.Visible = false;

                hand = "チョキ";
            }
            else 
            {
                PictureBox4.Visible = false;
                PictureBox5.Visible = false;
                hand = "パー";
            }
            return hand;
        }
        private string Decides(string playerHand, string cpuHand)///playerの手とcpuの手を確認して勝敗を判定する
        {
            string result = "";

            

            if (playerHand == "グー")          ///グーを出したとき
            {
                PictureBox2.Visible = false;
                PictureBox3.Visible = false;

                if (cpuHand == "グー")
                {
                    result = "DRAW　引き分けです。リトライだ！";
                    drawCount++;
                }
                else if (cpuHand == "チョキ")
                {
                    result = "WIN　あなたの勝利です。おめでとう！";
                    winCount++;
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                    loseCount++;
                }
            }
            else if(playerHand == "チョキ")    ///チョキを出したとき　
            {
                PictureBox1.Visible = false;
                PictureBox3.Visible = false;
                if (cpuHand == "チョキ")
                {
                    result = "DRAW　引き分けです。リトライだ！";
                    drawCount++;
                }
                else if (cpuHand == "パー")
                {

                    result = "WIN　あなたの勝利です。おめでとう！";
                    winCount++;
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                    loseCount++;
                }
            }
            else                                ///パーを出したとき
            {
                PictureBox1.Visible = false;
                PictureBox2.Visible = false;

                if (cpuHand == "パー")
                {
                    result = "DRAW　引き分けです。リトライだ！";
                    drawCount++;
                }
                else if (cpuHand == "グー")
                {
                    result = "WIN　あなたの勝利です。おめでとう！";
                    winCount++;
                }
                else
                {
                    result = "LOSE　あなたの負けです。悔しい！";
                    loseCount++;
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

             PictureBox1.Visible = true;
             PictureBox2.Visible = true;
             PictureBox3.Visible = true;
             PictureBox4.Visible = true;
             PictureBox5.Visible = true;
             PictureBox6.Visible = true;

            gameCount++;
            lblGameCount.Text = $"試合回数: {gameCount} 回";
            lblwin.Text = $"勝ち: {winCount} 回";
            lbldraw.Text = $"引き分け: {drawCount} 回";
            lbllose.Text = $"負け: {loseCount} 回";

            labelPLAYER.Text = ("グー、チョキ、パー");
            labelCPU.Text = ("グー、チョキ、パー");

        }
    }
}


