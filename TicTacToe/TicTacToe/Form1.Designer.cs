namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.oyunAlaniGbx = new System.Windows.Forms.GroupBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.oyunAlaniGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyunAlaniGbx
            // 
            this.oyunAlaniGbx.Controls.Add(this.Btn9);
            this.oyunAlaniGbx.Controls.Add(this.Btn6);
            this.oyunAlaniGbx.Controls.Add(this.Btn3);
            this.oyunAlaniGbx.Controls.Add(this.Btn8);
            this.oyunAlaniGbx.Controls.Add(this.Btn7);
            this.oyunAlaniGbx.Controls.Add(this.Btn5);
            this.oyunAlaniGbx.Controls.Add(this.Btn4);
            this.oyunAlaniGbx.Controls.Add(this.Btn2);
            this.oyunAlaniGbx.Controls.Add(this.Btn1);
            this.oyunAlaniGbx.Location = new System.Drawing.Point(12, 12);
            this.oyunAlaniGbx.Name = "oyunAlaniGbx";
            this.oyunAlaniGbx.Size = new System.Drawing.Size(309, 284);
            this.oyunAlaniGbx.TabIndex = 0;
            this.oyunAlaniGbx.TabStop = false;
            this.oyunAlaniGbx.Text = "Oyun Alanı";
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn1.Location = new System.Drawing.Point(6, 19);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(94, 82);
            this.Btn1.TabIndex = 0;
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn2.Location = new System.Drawing.Point(106, 19);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(94, 82);
            this.Btn2.TabIndex = 0;
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn3.Location = new System.Drawing.Point(206, 19);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(94, 82);
            this.Btn3.TabIndex = 0;
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn4.Location = new System.Drawing.Point(6, 107);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(94, 82);
            this.Btn4.TabIndex = 0;
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn5.Location = new System.Drawing.Point(106, 107);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(94, 82);
            this.Btn5.TabIndex = 0;
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn6.Location = new System.Drawing.Point(206, 107);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(94, 82);
            this.Btn6.TabIndex = 0;
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn7.Location = new System.Drawing.Point(6, 195);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(94, 82);
            this.Btn7.TabIndex = 0;
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn8.Location = new System.Drawing.Point(106, 195);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(94, 82);
            this.Btn8.TabIndex = 0;
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn9.Location = new System.Drawing.Point(206, 195);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(94, 82);
            this.Btn9.TabIndex = 0;
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 302);
            this.Controls.Add(this.oyunAlaniGbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.oyunAlaniGbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oyunAlaniGbx;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
    }
}

