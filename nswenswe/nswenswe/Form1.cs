// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-02-2017
//
// Last Modified By : wicher
// Last Modified On : 01-08-2018
// ***********************************************************************
// <copyright file="Form1.cs" company="">
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
    /// Class Rozpoczecie_gry.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Rozpoczecie_gry : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rozpoczecie_gry"/> class.
        /// </summary>
        public Rozpoczecie_gry()
        {
            InitializeComponent();
            rtbZasadyGry.SelectAll();
            rtbZasadyGry.SelectionAlignment = HorizontalAlignment.Center;
        }

        /// <summary>
        /// Handles the Click event of the bDalej control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bDalej_Click(object sender, EventArgs e)
        {
            new Gra().Show();
            this.Hide();
        }
    }
}
