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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelPLAYER = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 250);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(439, 9);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(121, 18);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "CPUの出した手";
            // 
            // labelPLAYER
            // 
            this.labelPLAYER.AutoSize = true;
            this.labelPLAYER.Location = new System.Drawing.Point(45, 205);
            this.labelPLAYER.Name = "labelPLAYER";
            this.labelPLAYER.Size = new System.Drawing.Size(122, 18);
            this.labelPLAYER.TabIndex = 2;
            this.labelPLAYER.Text = "自分の出した手";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "グー";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "チョキ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(872, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "パー";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(404, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 250);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(812, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 250);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 697);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPLAYER);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelPLAYER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

