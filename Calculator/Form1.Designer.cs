﻿namespace Calculator
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
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.btnRazlika = new System.Windows.Forms.Button();
            this.btnZbir = new System.Windows.Forms.Button();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrugBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrviBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDobrodoslica
            // 
            this.lblDobrodoslica.AutoSize = true;
            this.lblDobrodoslica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodoslica.Location = new System.Drawing.Point(118, 36);
            this.lblDobrodoslica.Name = "lblDobrodoslica";
            this.lblDobrodoslica.Size = new System.Drawing.Size(57, 20);
            this.lblDobrodoslica.TabIndex = 17;
            this.lblDobrodoslica.Text = "label4";
            // 
            // btnRazlika
            // 
            this.btnRazlika.Location = new System.Drawing.Point(359, 246);
            this.btnRazlika.Name = "btnRazlika";
            this.btnRazlika.Size = new System.Drawing.Size(75, 23);
            this.btnRazlika.TabIndex = 16;
            this.btnRazlika.Text = "Razlika";
            this.btnRazlika.UseVisualStyleBackColor = true;
            this.btnRazlika.Click += new System.EventHandler(this.btnRazlika_Click);
            // 
            // btnZbir
            // 
            this.btnZbir.Location = new System.Drawing.Point(82, 246);
            this.btnZbir.Name = "btnZbir";
            this.btnZbir.Size = new System.Drawing.Size(75, 23);
            this.btnZbir.TabIndex = 15;
            this.btnZbir.Text = "Zbir";
            this.btnZbir.UseVisualStyleBackColor = true;
            this.btnZbir.Click += new System.EventHandler(this.btnZbir_Click);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Enabled = false;
            this.txtRezultat.Location = new System.Drawing.Point(232, 194);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(186, 20);
            this.txtRezultat.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rezultat:";
            // 
            // txtDrugBroj
            // 
            this.txtDrugBroj.Location = new System.Drawing.Point(232, 133);
            this.txtDrugBroj.Name = "txtDrugBroj";
            this.txtDrugBroj.Size = new System.Drawing.Size(186, 20);
            this.txtDrugBroj.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Unesite b:";
            // 
            // txtPrviBroj
            // 
            this.txtPrviBroj.Location = new System.Drawing.Point(232, 79);
            this.txtPrviBroj.Name = "txtPrviBroj";
            this.txtPrviBroj.Size = new System.Drawing.Size(186, 20);
            this.txtPrviBroj.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unesite a:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.btnRazlika);
            this.Controls.Add(this.btnZbir);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDrugBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrviBroj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.Button btnRazlika;
        private System.Windows.Forms.Button btnZbir;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrugBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrviBroj;
        private System.Windows.Forms.Label label1;
    }
}

