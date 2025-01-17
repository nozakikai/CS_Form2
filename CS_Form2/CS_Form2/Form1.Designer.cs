namespace CS_Form2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelPLAYER = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGameCount = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblwin = new System.Windows.Forms.Label();
            this.lbldraw = new System.Windows.Forms.Label();
            this.lbllose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(411, 35);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(129, 18);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "グー、チョキ、パー";
            // 
            // labelPLAYER
            // 
            this.labelPLAYER.AutoSize = true;
            this.labelPLAYER.Location = new System.Drawing.Point(411, 340);
            this.labelPLAYER.Name = "labelPLAYER";
            this.labelPLAYER.Size = new System.Drawing.Size(129, 18);
            this.labelPLAYER.TabIndex = 2;
            this.labelPLAYER.Text = "グー、チョキ、パー";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(180, 600);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 30);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "グー";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(430, 600);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 30);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "チョキ";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(680, 600);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "パー";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(920, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 6;
            this.button4.Text = "　終了";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "CPUが出した手";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(100, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "あなたの出した手";
            // 
            // lblGameCount
            // 
            this.lblGameCount.AutoSize = true;
            this.lblGameCount.Location = new System.Drawing.Point(917, 47);
            this.lblGameCount.Name = "lblGameCount";
            this.lblGameCount.Size = new System.Drawing.Size(80, 18);
            this.lblGameCount.TabIndex = 9;
            this.lblGameCount.Text = "試合回数";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(120, 380);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(220, 200);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(370, 380);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(220, 200);
            this.PictureBox2.TabIndex = 10;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(620, 380);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(250, 200);
            this.PictureBox3.TabIndex = 10;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox4
            // 
            this.PictureBox4.Location = new System.Drawing.Point(120, 101);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(220, 200);
            this.PictureBox4.TabIndex = 10;
            this.PictureBox4.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.Location = new System.Drawing.Point(370, 101);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(220, 200);
            this.PictureBox5.TabIndex = 10;
            this.PictureBox5.TabStop = false;
            // 
            // PictureBox6
            // 
            this.PictureBox6.Location = new System.Drawing.Point(620, 101);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(250, 200);
            this.PictureBox6.TabIndex = 10;
            this.PictureBox6.TabStop = false;
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Location = new System.Drawing.Point(917, 112);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(40, 18);
            this.lblwin.TabIndex = 9;
            this.lblwin.Text = "勝ち";
            // 
            // lbldraw
            // 
            this.lbldraw.AutoSize = true;
            this.lbldraw.Location = new System.Drawing.Point(917, 152);
            this.lbldraw.Name = "lbldraw";
            this.lbldraw.Size = new System.Drawing.Size(73, 18);
            this.lbldraw.TabIndex = 9;
            this.lbldraw.Text = "引き分け";
            // 
            // lbllose
            // 
            this.lbllose.AutoSize = true;
            this.lbllose.Location = new System.Drawing.Point(917, 192);
            this.lbllose.Name = "lbllose";
            this.lbllose.Size = new System.Drawing.Size(41, 18);
            this.lbllose.TabIndex = 9;
            this.lbllose.Text = "負け";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.PictureBox6);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lbllose);
            this.Controls.Add(this.lbldraw);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.lblGameCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.labelPLAYER);
            this.Controls.Add(this.labelCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelPLAYER;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGameCount;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox4;
        private System.Windows.Forms.PictureBox PictureBox5;
        private System.Windows.Forms.PictureBox PictureBox6;
        private System.Windows.Forms.Label lblwin;
        private System.Windows.Forms.Label lbldraw;
        private System.Windows.Forms.Label lbllose;
    }
}

