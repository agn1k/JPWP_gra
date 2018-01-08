// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-25-2017
//
// Last Modified By : wicher
// Last Modified On : 01-07-2018
// ***********************************************************************
// <copyright file="Form4.Designer.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace nswenswe
{
    /// <summary>
    /// Class Wygrana.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Wygrana
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
            this.rtbCiekawostka = new System.Windows.Forms.RichTextBox();
            this.lGratulacje = new System.Windows.Forms.Label();
            this.bNastepnyPoziom = new System.Windows.Forms.Button();
            this.pbCiekawostka = new System.Windows.Forms.PictureBox();
            this.lWynik = new System.Windows.Forms.Label();
            this.lWynikNapis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCiekawostka)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCiekawostka
            // 
            this.rtbCiekawostka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCiekawostka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rtbCiekawostka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCiekawostka.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbCiekawostka.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCiekawostka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.rtbCiekawostka.Location = new System.Drawing.Point(32, 120);
            this.rtbCiekawostka.Name = "rtbCiekawostka";
            this.rtbCiekawostka.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbCiekawostka.Size = new System.Drawing.Size(690, 491);
            this.rtbCiekawostka.TabIndex = 18;
            this.rtbCiekawostka.Text = "Ciekawostka";
            // 
            // lGratulacje
            // 
            this.lGratulacje.AutoSize = true;
            this.lGratulacje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lGratulacje.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGratulacje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lGratulacje.Location = new System.Drawing.Point(21, 27);
            this.lGratulacje.Name = "lGratulacje";
            this.lGratulacje.Size = new System.Drawing.Size(1207, 66);
            this.lGratulacje.TabIndex = 19;
            this.lGratulacje.Text = "Gratulacje! Ukończyłeś poziom!";
            // 
            // bNastepnyPoziom
            // 
            this.bNastepnyPoziom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.bNastepnyPoziom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNastepnyPoziom.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNastepnyPoziom.Location = new System.Drawing.Point(822, 620);
            this.bNastepnyPoziom.Name = "bNastepnyPoziom";
            this.bNastepnyPoziom.Size = new System.Drawing.Size(390, 99);
            this.bNastepnyPoziom.TabIndex = 20;
            this.bNastepnyPoziom.Text = "NASTĘPNY POZIOM";
            this.bNastepnyPoziom.UseVisualStyleBackColor = false;
            this.bNastepnyPoziom.Click += new System.EventHandler(this.bNastepnyPoziom_Click);
            // 
            // pbCiekawostka
            // 
            this.pbCiekawostka.Location = new System.Drawing.Point(728, 120);
            this.pbCiekawostka.Name = "pbCiekawostka";
            this.pbCiekawostka.Size = new System.Drawing.Size(518, 493);
            this.pbCiekawostka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCiekawostka.TabIndex = 21;
            this.pbCiekawostka.TabStop = false;
            // 
            // lWynik
            // 
            this.lWynik.AutoSize = true;
            this.lWynik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lWynik.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWynik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lWynik.Location = new System.Drawing.Point(580, 653);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(68, 66);
            this.lWynik.TabIndex = 36;
            this.lWynik.Text = "0";
            // 
            // lWynikNapis
            // 
            this.lWynikNapis.AutoSize = true;
            this.lWynikNapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lWynikNapis.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWynikNapis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lWynikNapis.Location = new System.Drawing.Point(306, 653);
            this.lWynikNapis.Name = "lWynikNapis";
            this.lWynikNapis.Size = new System.Drawing.Size(268, 66);
            this.lWynikNapis.TabIndex = 35;
            this.lWynikNapis.Text = "WYNIK:";
            // 
            // Wygrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 752);
            this.Controls.Add(this.lWynik);
            this.Controls.Add(this.lWynikNapis);
            this.Controls.Add(this.bNastepnyPoziom);
            this.Controls.Add(this.lGratulacje);
            this.Controls.Add(this.rtbCiekawostka);
            this.Controls.Add(this.pbCiekawostka);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wygrana";
            this.Text = "NSWE- Kierunki Świata";
            ((System.ComponentModel.ISupportInitialize)(this.pbCiekawostka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        #endregion
        /// <summary>
        /// tekst z ciekawostka
        /// </summary>
        private System.Windows.Forms.RichTextBox rtbCiekawostka;
        /// <summary>
        /// etykieta - wyswietla napis z gratulacjami
        /// </summary>
        private System.Windows.Forms.Label lGratulacje;
        /// <summary>
        /// przycisk "NASTEPNY POZIOM"
        /// </summary>
        private System.Windows.Forms.Button bNastepnyPoziom;
        /// <summary>
        /// grafika dotyczaca ciekawostki
        /// </summary>
        private System.Windows.Forms.PictureBox pbCiekawostka;
        /// <summary>
        /// etykieta - wyswietla liczbe uzyskanych przez uzytkownika punktow
        /// </summary>
        private System.Windows.Forms.Label lWynik;
        /// <summary>
        /// etykieta - wyswietla napis "WYNIK:"
        /// </summary>
        private System.Windows.Forms.Label lWynikNapis;
    }
}