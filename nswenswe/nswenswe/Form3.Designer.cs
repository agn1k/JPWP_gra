// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-23-2017
//
// Last Modified By : wicher
// Last Modified On : 01-08-2018
// ***********************************************************************
// <copyright file="Form3.Designer.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace nswenswe
{
    /// <summary>
    /// Class Przegrana.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Przegrana
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
            this.lPrzegrana = new System.Windows.Forms.Label();
            this.bWyjscie = new System.Windows.Forms.Button();
            this.bGraOdNowa = new System.Windows.Forms.Button();
            this.bPoziomOdNowa = new System.Windows.Forms.Button();
            this.pbPrzegrana = new System.Windows.Forms.PictureBox();
            this.lWynikNapis = new System.Windows.Forms.Label();
            this.lWynik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrzegrana)).BeginInit();
            this.SuspendLayout();
            // 
            // lPrzegrana
            // 
            this.lPrzegrana.AutoSize = true;
            this.lPrzegrana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lPrzegrana.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrzegrana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lPrzegrana.Location = new System.Drawing.Point(45, 23);
            this.lPrzegrana.Name = "lPrzegrana";
            this.lPrzegrana.Size = new System.Drawing.Size(147, 25);
            this.lPrzegrana.TabIndex = 20;
            this.lPrzegrana.Text = "PRZEGRANA";
            // 
            // bWyjscie
            // 
            this.bWyjscie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bWyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bWyjscie.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWyjscie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bWyjscie.Location = new System.Drawing.Point(38, 462);
            this.bWyjscie.Name = "bWyjscie";
            this.bWyjscie.Size = new System.Drawing.Size(408, 99);
            this.bWyjscie.TabIndex = 29;
            this.bWyjscie.Text = "WYJŚCIE Z GRY";
            this.bWyjscie.UseVisualStyleBackColor = false;
            this.bWyjscie.Click += new System.EventHandler(this.bWyjscie_Click);
            // 
            // bGraOdNowa
            // 
            this.bGraOdNowa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bGraOdNowa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bGraOdNowa.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGraOdNowa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.bGraOdNowa.Location = new System.Drawing.Point(38, 348);
            this.bGraOdNowa.Name = "bGraOdNowa";
            this.bGraOdNowa.Size = new System.Drawing.Size(408, 99);
            this.bGraOdNowa.TabIndex = 30;
            this.bGraOdNowa.Text = "ROZPOCZNIJ GRĘ OD NOWA";
            this.bGraOdNowa.UseVisualStyleBackColor = false;
            this.bGraOdNowa.Click += new System.EventHandler(this.bGraOdNowa_Click);
            // 
            // bPoziomOdNowa
            // 
            this.bPoziomOdNowa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bPoziomOdNowa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPoziomOdNowa.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPoziomOdNowa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.bPoziomOdNowa.Location = new System.Drawing.Point(38, 231);
            this.bPoziomOdNowa.Name = "bPoziomOdNowa";
            this.bPoziomOdNowa.Size = new System.Drawing.Size(408, 99);
            this.bPoziomOdNowa.TabIndex = 31;
            this.bPoziomOdNowa.Text = "ROZPOCZNIJ TEN POZIOM OD NOWA";
            this.bPoziomOdNowa.UseVisualStyleBackColor = false;
            this.bPoziomOdNowa.Click += new System.EventHandler(this.bPoziomOdNowa_Click_1);
            // 
            // pbPrzegrana
            // 
            this.pbPrzegrana.Image = global::nswenswe.Properties.Resources.zgubiony;
            this.pbPrzegrana.Location = new System.Drawing.Point(11, 12);
            this.pbPrzegrana.Name = "pbPrzegrana";
            this.pbPrzegrana.Size = new System.Drawing.Size(512, 512);
            this.pbPrzegrana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPrzegrana.TabIndex = 32;
            this.pbPrzegrana.TabStop = false;
            // 
            // lWynikNapis
            // 
            this.lWynikNapis.AutoSize = true;
            this.lWynikNapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lWynikNapis.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWynikNapis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lWynikNapis.Location = new System.Drawing.Point(45, 181);
            this.lWynikNapis.Name = "lWynikNapis";
            this.lWynikNapis.Size = new System.Drawing.Size(135, 35);
            this.lWynikNapis.TabIndex = 33;
            this.lWynikNapis.Text = "WYNIK:";
            // 
            // lWynik
            // 
            this.lWynik.AutoSize = true;
            this.lWynik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lWynik.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWynik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lWynik.Location = new System.Drawing.Point(195, 181);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(35, 35);
            this.lWynik.TabIndex = 34;
            this.lWynik.Text = "0";
            // 
            // Przegrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(535, 584);
            this.Controls.Add(this.lWynik);
            this.Controls.Add(this.lWynikNapis);
            this.Controls.Add(this.bPoziomOdNowa);
            this.Controls.Add(this.bGraOdNowa);
            this.Controls.Add(this.bWyjscie);
            this.Controls.Add(this.lPrzegrana);
            this.Controls.Add(this.pbPrzegrana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Przegrana";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbPrzegrana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        #endregion
        /// <summary>
        /// etykieta - wyswietla napis w przypadku przegranej
        /// </summary>
        private System.Windows.Forms.Label lPrzegrana;
        /// <summary>
        /// przycisk - "WYJSCIE"
        /// </summary>
        private System.Windows.Forms.Button bWyjscie;
        /// <summary>
        /// przycisk - "GRA OD NOWA"
        /// </summary>
        private System.Windows.Forms.Button bGraOdNowa;
        /// <summary>
        /// przycisk - "POZIOM OD NOWA"
        /// </summary>
        private System.Windows.Forms.Button bPoziomOdNowa;
        /// <summary>
        /// grafika przegranej
        /// </summary>
        private System.Windows.Forms.PictureBox pbPrzegrana;
        /// <summary>
        /// etykieta - wyswietla napis "WYNIK:"
        /// </summary>
        private System.Windows.Forms.Label lWynikNapis;
        /// <summary>
        /// etykieta - wyswietla liczbe uzyskanych przez uzytkownika punktow
        /// </summary>
        private System.Windows.Forms.Label lWynik;
    }
}