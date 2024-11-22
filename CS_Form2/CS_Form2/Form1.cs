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
        Image currentImage = Image.FromFile(@"C:\Users\kai08\Desktop\自由\画像\グー.png");
        public Form1()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage != null)
            {
                //　画像を0,0に描画する
                e.Graphics.DrawImage(currentImage,
                    0, 0, currentImage.Width, currentImage.Height);

            }

        }
        

            
        
    }
}
