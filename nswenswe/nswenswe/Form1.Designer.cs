// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-02-2017
//
// Last Modified By : wicher
// Last Modified On : 01-08-2018
// ***********************************************************************
// <copyright file="Form1.Designer.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace nswenswe
{
    /// <summary>
    /// Class Rozpoczecie_gry.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Rozpoczecie_gry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rozpoczecie_gry));
            this.rtbZasadyGry = new System.Windows.Forms.RichTextBox();
            this.lNSWEKierunkiSwiata = new System.Windows.Forms.Label();
            this.bRozpocznijGre = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbZasadyGry
            // 
            this.rtbZasadyGry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbZasadyGry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rtbZasadyGry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbZasadyGry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbZasadyGry.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbZasadyGry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbZasadyGry.Location = new System.Drawing.Point(12, 113);
            this.rtbZasadyGry.Name = "rtbZasadyGry";
            this.rtbZasadyGry.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbZasadyGry.Size = new System.Drawing.Size(583, 407);
            this.rtbZasadyGry.TabIndex = 17;
            this.rtbZasadyGry.Text = resources.GetString("rtbZasadyGry.Text");
            // 
            // lNSWEKierunkiSwiata
            // 
            this.lNSWEKierunkiSwiata.AutoSize = true;
            this.lNSWEKierunkiSwiata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lNSWEKierunkiSwiata.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNSWEKierunkiSwiata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.lNSWEKierunkiSwiata.Location = new System.Drawing.Point(185, 21);
            this.lNSWEKierunkiSwiata.Name = "lNSWEKierunkiSwiata";
            this.lNSWEKierunkiSwiata.Size = new System.Drawing.Size(905, 66);
            this.lNSWEKierunkiSwiata.TabIndex = 15;
            this.lNSWEKierunkiSwiata.Text = "NSWE - Kierunki Świata";
            // 
            // bRozpocznijGre
            // 
            this.bRozpocznijGre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.bRozpocznijGre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRozpocznijGre.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRozpocznijGre.Location = new System.Drawing.Point(832, 615);
            this.bRozpocznijGre.Name = "bRozpocznijGre";
            this.bRozpocznijGre.Size = new System.Drawing.Size(390, 99);
            this.bRozpocznijGre.TabIndex = 16;
            this.bRozpocznijGre.Text = "ROZPOCZNIJ GRĘ!";
            this.bRozpocznijGre.UseVisualStyleBackColor = false;
            this.bRozpocznijGre.Click += new System.EventHandler(this.bDalej_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.richTextBox1.Location = new System.Drawing.Point(626, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(570, 471);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(83)))), ((int)(((byte)(148)))));
            this.richTextBox2.Location = new System.Drawing.Point(12, 526);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(583, 188);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Początkowo proste zagadnienia dotyczące \nczterech podstawowych kierunków świata b" +
    "ędą przechodzić w trudniejsze\nzwiązane z kierunkami pośrednimi, kątami czy też a" +
    "zymutem.";
            // 
            // Rozpoczecie_gry
            // 
            this.AcceptButton = this.bRozpocznijGre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 752);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bRozpocznijGre);
            this.Controls.Add(this.lNSWEKierunkiSwiata);
            this.Controls.Add(this.rtbZasadyGry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rozpoczecie_gry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSWE - Kierunki Świata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// etykieta - napis NSWE Kierunki Swiata
        /// </summary>
        private System.Windows.Forms.Label lNSWEKierunkiSwiata;
        /// <summary>
        /// przycisk "Rozpocznij Gre"
        /// </summary>
        private System.Windows.Forms.Button bRozpocznijGre;
        /// <summary>
        /// tekst z zasadami gry
        /// </summary>
        private System.Windows.Forms.RichTextBox rtbZasadyGry;
        /// <summary>
        /// tekst z zasadami gry
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBox1;
        /// <summary>
        /// tekst z zasadami gry
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

