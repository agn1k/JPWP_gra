// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 01-06-2018
//
// Last Modified By : wicher
// Last Modified On : 01-07-2018
// ***********************************************************************
// <copyright file="Form5.cs" company="">
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
    /// Class Pomoc.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Pomoc : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pomoc"/> class.
        /// </summary>
        /// <param name="tCzas">The t czas.</param>
        public Pomoc(Timer tCzas)
        {
            InitializeComponent();
            this.tCzasPomoc = tCzas;
        }

        /// <summary>
        /// Handles the Click event of the bPowrotDoGry control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bPowrotDoGry_Click(object sender, EventArgs e)
        {
            this.Hide();
            tCzasPomoc.Start();
        }
    }
}
