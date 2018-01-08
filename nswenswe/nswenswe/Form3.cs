// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-23-2017
//
// Last Modified By : wicher
// Last Modified On : 01-08-2018
// ***********************************************************************
// <copyright file="Form3.cs" company="">
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

namespace nswenswe
{
    /// <summary>
    /// Class Przegrana.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Przegrana : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Przegrana"/> class.
        /// </summary>
        public Przegrana()
        {
            InitializeComponent();
            if (Gra.czas == 0)
            {
                lPrzegrana.Text = "Skończył Ci się czas !";
            }
            else if (Gra.szanse == 0)
            {
                lPrzegrana.Text = "Wykorzystałeś wszystkie szanse,\n \tkoniec gry !";
            }
            lPrzegrana.Location = new Point(this.Location.X + this.Width / 2 - lPrzegrana.Width / 2, lPrzegrana.Location.Y);
            lWynik.Text = Gra.wynik.ToString();
        }

        /// <summary>
        /// Handles the 1 event of the bPoziomOdNowa_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bPoziomOdNowa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Gra().Show();
        }

        /// <summary>
        /// Handles the Click event of the bGraOdNowa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bGraOdNowa_Click(object sender, EventArgs e)
        {
            Gra.poziom = 1;
            this.Hide();
            new Gra().Show();
        }

        /// <summary>
        /// Handles the Click event of the bWyjscie control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
