﻿namespace Not_Kayit_Sistemi
{
    partial class FrmGiris
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
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ NUMARA:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(255, 43);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 30);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.TextChanged += this.maskedTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(255, 98);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 2;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(511, 178);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmGiris";
            Text = "ÖĞRENCİ NOT KAYIT SİSTEMİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
    }
}
