using System;
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


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sakuma ゆいと");
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
                //　画像を0,0に描画する
                e.Graphics.DrawImage(currentImage2,
                    0, 0, currentImage2.Width, currentImage2.Height);

            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage3 != null)
            {
                //　画像を0,0に描画する
                e.Graphics.DrawImage(currentImage3,
                    0, 0, currentImage3.Width, currentImage3.Height);

            }

        }

    }

}


