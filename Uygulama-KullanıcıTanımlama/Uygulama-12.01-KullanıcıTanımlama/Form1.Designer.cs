
namespace Uygulama_12._01_KullanıcıTanımlama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.girişbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yenibtn = new System.Windows.Forms.Button();
            this.şifretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ıdtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.çıkışbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // girişbtn
            // 
            this.girişbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.girişbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girişbtn.Location = new System.Drawing.Point(352, 357);
            this.girişbtn.Name = "girişbtn";
            this.girişbtn.Size = new System.Drawing.Size(100, 26);
            this.girişbtn.TabIndex = 4;
            this.girişbtn.Text = "GİRİŞ";
            this.girişbtn.UseVisualStyleBackColor = false;
            this.girişbtn.Click += new System.EventHandler(this.girişbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(268, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // yenibtn
            // 
            this.yenibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.yenibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenibtn.Location = new System.Drawing.Point(352, 398);
            this.yenibtn.Name = "yenibtn";
            this.yenibtn.Size = new System.Drawing.Size(100, 45);
            this.yenibtn.TabIndex = 5;
            this.yenibtn.Text = "Yeni kullanıcı oluşturunuz";
            this.yenibtn.UseVisualStyleBackColor = false;
            this.yenibtn.Visible = false;
            this.yenibtn.Click += new System.EventHandler(this.yenibtn_Click);
            // 
            // şifretxt
            // 
            this.şifretxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.şifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifretxt.Location = new System.Drawing.Point(352, 308);
            this.şifretxt.Multiline = true;
            this.şifretxt.Name = "şifretxt";
            this.şifretxt.PasswordChar = '*';
            this.şifretxt.Size = new System.Drawing.Size(100, 26);
            this.şifretxt.TabIndex = 3;
            this.şifretxt.TextChanged += new System.EventHandler(this.şifretxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(193, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // ıdtxt
            // 
            this.ıdtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ıdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıdtxt.Location = new System.Drawing.Point(352, 256);
            this.ıdtxt.Multiline = true;
            this.ıdtxt.Name = "ıdtxt";
            this.ıdtxt.Size = new System.Drawing.Size(100, 26);
            this.ıdtxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ıdtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.şifretxt);
            this.groupBox1.Controls.Add(this.girişbtn);
            this.groupBox1.Controls.Add(this.çıkışbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.yenibtn);
            this.groupBox1.Location = new System.Drawing.Point(-1, -14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 536);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Uygulama_12._01_KullanıcıTanımlama.Properties.Resources.Logo;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(198, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(163, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "AMAZONA HOŞGELDİNİZ";
            this.label3.Visible = false;
            // 
            // çıkışbtn
            // 
            this.çıkışbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.çıkışbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışbtn.Location = new System.Drawing.Point(291, 308);
            this.çıkışbtn.Name = "çıkışbtn";
            this.çıkışbtn.Size = new System.Drawing.Size(100, 26);
            this.çıkışbtn.TabIndex = 9;
            this.çıkışbtn.Text = "ÇIKIŞ";
            this.çıkışbtn.UseVisualStyleBackColor = false;
            this.çıkışbtn.Visible = false;
            this.çıkışbtn.Click += new System.EventHandler(this.çıkışbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(648, 521);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ıdtxt;
        private System.Windows.Forms.TextBox şifretxt;
        private System.Windows.Forms.Button girişbtn;
        private System.Windows.Forms.Button yenibtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button çıkışbtn;
    }
}

