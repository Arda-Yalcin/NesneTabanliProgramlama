namespace Toplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            BtnTopla = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "İki Sayı Giriniz";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(172, 17);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 23);
            txtSayi1.TabIndex = 1;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(172, 80);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 1;
            // 
            // BtnTopla
            // 
            BtnTopla.BackColor = Color.DarkGray;
            BtnTopla.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnTopla.Location = new Point(12, 65);
            BtnTopla.Name = "BtnTopla";
            BtnTopla.Size = new Size(102, 48);
            BtnTopla.TabIndex = 2;
            BtnTopla.Text = "Topla Buton";
            BtnTopla.UseVisualStyleBackColor = false;
            BtnTopla.Click += BtnTopla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonuc.Location = new Point(60, 138);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(58, 17);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuc =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 240);
            Controls.Add(lblSonuc);
            Controls.Add(BtnTopla);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hesap Makinesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button BtnTopla;
        private Label lblSonuc;
    }
}