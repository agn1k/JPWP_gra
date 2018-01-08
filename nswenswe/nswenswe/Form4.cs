// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-25-2017
//
// Last Modified By : wicher
// Last Modified On : 01-08-2018
// ***********************************************************************
// <copyright file="Form4.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nswenswe
{
    /// <summary>
    /// Class Wygrana.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Wygrana : Form
    {
        /// <summary>
        /// sciezka do plikow tekstowych
        /// </summary>
        string sciezka_txt = @"..\..\..\pliki_txt\";
        /// <summary>
        /// sciezka do grafiki
        /// </summary>
        string sciezka_grafika = @"..\..\..\grafia\";
        /// <summary>
        /// Initializes a new instance of the <see cref="Wygrana"/> class.
        /// </summary>
        public Wygrana()
        {
            InitializeComponent();

            czyta_z_pliku();
            wybiera_obrazek();
            if ( Gra.poziom == 6)
            {
                bNastepnyPoziom.Text = "KONIEC!";
                lGratulacje.Text = "Gratulacje! Ukończyłeś grę!";
            }
            lWynik.Text = Gra.wynik.ToString();

        }
        /// <summary>
        /// Czyta z pliku.
        /// </summary>
        private void czyta_z_pliku()
        {
            try
            {
                string text = System.IO.File.ReadAllText(sciezka_txt + Gra.poziom.ToString() + ".txt");
                rtbCiekawostka.Text = text;
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie udało się otworzyć pliku: ");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Wybiera obrazek.
        /// </summary>
        private void wybiera_obrazek()
        {
            if (Gra.poziom != 1)
                pbCiekawostka.Image = Image.FromFile(sciezka_grafika + Gra.poziom + ".png");
            else
                pbCiekawostka.Image = Image.FromFile(sciezka_grafika + Gra.poziom + ".gif");
        }

        /// <summary>
        /// Handles the Click event of the bNastepnyPoziom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bNastepnyPoziom_Click(object sender, EventArgs e)
        {
            if (Gra.poziom != 6)
            {
                Gra.poziom++;
                this.Hide();
                new Gra().Show();
            }
            else
                Application.Exit();
        }
    }
}
