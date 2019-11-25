namespace calc
{
    partial class frm_calc
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
            this.txt_calc = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_calc
            // 
            this.txt_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_calc.Location = new System.Drawing.Point(12, 12);
            this.txt_calc.Name = "txt_calc";
            this.txt_calc.Size = new System.Drawing.Size(299, 53);
            this.txt_calc.TabIndex = 0;
            this.txt_calc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_calc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calc_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 77);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(116, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(134, 77);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 50);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(134, 133);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(55, 50);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(73, 133);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(55, 50);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 133);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(55, 50);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(134, 189);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(55, 50);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(73, 189);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(55, 50);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 189);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(55, 50);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(134, 245);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(55, 50);
            this.btn_3.TabIndex = 12;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(73, 245);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(55, 50);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 245);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(55, 50);
            this.btn_1.TabIndex = 10;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(12, 300);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(177, 50);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(195, 188);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(55, 106);
            this.btn_sub.TabIndex = 17;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(195, 77);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(55, 106);
            this.btn_sum.TabIndex = 16;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(256, 188);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(55, 106);
            this.btn_div.TabIndex = 19;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(256, 77);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(55, 106);
            this.btn_mul.TabIndex = 18;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(195, 300);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(116, 50);
            this.btn_calc.TabIndex = 20;
            this.btn_calc.Text = "=";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // frm_calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 362);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_calc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_calc";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_calc;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_calc;
    }
}

