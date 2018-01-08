// ***********************************************************************
// Assembly         : nswenswe
// Author           : wicher
// Created          : 12-02-2017
//
// Last Modified By : wicher
// Last Modified On : 01-07-2018
// ***********************************************************************
// <copyright file="Form2.cs" company="">
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
using System.Media;

namespace nswenswe
{

    /// <summary>
    /// Class Gra.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Gra : Form
    {
        /// <summary>
        /// rysunek
        /// </summary>
        Dictionary<string, string> rysunek = new Dictionary<string, string>();
        /// <summary>
        /// labedz
        /// </summary>
        Dictionary<string, string> labedz = new Dictionary<string, string>()
                    {
                     {"rb22", "PÓŁNOCNY-WSCHÓD"}, {"rb23","WSCHÓD"}, {"rb33","90°"}, {"rb43","S"}, {"rb53","AZUMUT 180°"},
                     {"rb54","WSCHÓD"}, {"rb55", "E"}, {"rb56","AZYMUT 90°"}, {"rb47","NE"}, {"rb57","S"},
                     {"rb67","POŁUDNIE"}, {"rb76","POŁUDNIOWY-ZACHÓD"}, {"rb75", "ZACHÓD"}, {"rb74","W"}, {"rb73","AZUMUT 270°"},
                     {"rb62","45°"}, {"rb52","AZYMUT 0°"}, {"rb42","N"}, {"rb32", "PÓŁNOC"}, {"rb31","270°"}
                    };
        /// <summary>
        /// drzewo
        /// </summary>
        Dictionary<string, string> drzewo = new Dictionary<string, string>()
                    {
                     {"rb64", "PÓŁNOC"}, {"rb63","ZACHÓD"}, {"rb53","PÓŁNOC"}, {"rb52","ZACHÓD"}, {"rb42","PÓŁNOC"},
                     {"rb32","PÓŁNOC"}, {"rb33", "WSCHÓD"}, {"rb23","PÓŁNOC"}, {"rb24","WSCHÓD"}, {"rb14","PÓŁNOC"},
                     {"rb15","WSCHÓD"}, {"rb25","POŁUDNIE"}, {"rb26", "WSCHÓD"}, {"rb36","POŁUDNIE"}, {"rb37","WSCHÓD"},
                     {"rb47","POŁUDNIE"}, {"rb57","POŁUDNIE"}, {"rb56","ZACHÓD"}, {"rb66", "POŁUDNIE"}, {"rb65","ZACHÓD"},
                     {"rb75","POŁUDNIE"}, {"rb85","POŁUDNIE"}, {"rb84","ZACHÓD"}, {"rb74","PÓŁNOC"}
                    };
        /// <summary>
        /// zegarek
        /// </summary>
        Dictionary<string, string> zegarek = new Dictionary<string, string>()
                    {
                     {"rb32", "PÓŁNOC"}, {"rb23","PÓŁNOCNY-WSCHÓD"}, {"rb13","PÓŁNOC"}, {"rb03","PÓŁNOC"}, {"rb04","WSCHÓD"},
                     {"rb05","WSCHÓD"}, {"rb15", "POŁUDNIE"}, {"rb25","POŁUDNIE"}, {"rb36","POŁUDNIOWY-WSCHÓD"}, {"rb46","POŁUDNIE"},
                     {"rb56","POŁUDNIE"}, {"rb65","POŁUDNIOWY-ZACHÓD"}, {"rb75", "POŁUDNIE"}, {"rb85","POŁUDNIE"}, {"rb95","POŁUDNIE"},
                     {"rb94","ZACHÓD"}, {"rb93","ZACHÓD"}, {"rb83","PÓŁNOC"}, {"rb73", "PÓŁNOC"}, {"rb63","PÓŁNOC"},
                     {"rb52","PÓŁNOCNY-ZACHÓD"}, {"rb42","PÓŁNOC"}
                    };
        /// <summary>
        /// ptak
        /// </summary>
        Dictionary<string, string> ptak = new Dictionary<string, string>()
                    {
                     {"rb95","E"}, {"rb85","N"}, {"rb75","N"}, {"rb64","NW"},
                     {"rb63","W"}, {"rb52", "NW"}, {"rb41","NW"}, {"rb31","N"}, {"rb22","NE"},
                     {"rb21","W"}, {"rb12","NE"}, {"rb13", "E"}, {"rb23","S"}, {"rb32","SW"},
                     {"rb43","SE"}, {"rb44","E"}, {"rb55","SE"}, {"rb66", "SE"}, {"rb77","SE"},
                     {"rb76","W"}, {"rb65","NW"}, {"rrb64","W"}
                    };
        /// <summary>
        /// kosciol
        /// </summary>
        Dictionary<string, string> kosciol = new Dictionary<string, string>()
                    {
                     {"rb14","180°"}, {"rb24","0°"}, {"rb33","45°"}, {"rb43","315°"},
                     {"rb53","0°"}, {"rb62", "45°"}, {"rb72","315°"}, {"rb82","0°"}, {"rb83","270°"},
                     {"rb84","0°"}, {"rb85","0°"}, {"rb86", "0°"}, {"rb76","270°"}, {"rb66","0°"},
                     {"rb55","315°"}, {"rb45","45°"}, {"rb35","0°"}, {"rrb24", "315°"}
                    };
        /// <summary>
        /// ursaminor
        /// </summary>
        Dictionary<string, string> ursaminor = new Dictionary<string, string>()
                    {
                     {"rb67","AZYMUT 135°"}, {"rb68","AZYMUT 90°"}, {"rb77","AZYMUT 225°"}, {"rb78","AZYMUT 90°"},
                     {"rb69","AZYMUT 45°"}, {"rb58", "AZYMUT 315°"}, {"rb48","AZYMUT 0°"}, {"rb38","AZYMUT 0°"}, {"rb28","AZYMUT 0°"},
                     {"rb37","AZYMUT 225°"}, {"rb36","AZYMUT 270°"}, {"rb35", "AZYMUT 270°"}, {"rb34","AZYMUT 270°"}, {"rb33","AZYMUT 270°"},
                     {"rb42","AZYMUT 225°"}, {"rb51","AZYMUT 225°"}, {"rb61","AZYMUT 180°"}, {"rb62", "AZYMUT 90°"}, {"rb53", "AZYMUT 45°"},
                     {"rb54","AZYMUT 90°"}, {"rb64","AZYMUT 180°"}, {"rb73","AZYMUT 225°"}, {"rb74", "AZYMUT 90°"}, {"rb65", "AZYMUT 45°"},
                     {"rb55", "AZYMUT 0°"}, {"rb56", "AZYMUT 90°"}
                    };
        /// <summary>
        /// mrowka
        /// </summary>
        Dictionary<string, string> mrowka = new Dictionary<string, string>()
                    {
                     {"rb30","AZYMUT 0°"}, {"rb41","SE"}, {"rb42","WSCHÓD" }, {"rb52","S"}, {"rb43","225°"},
                     {"rb44", "AZYMUT 90°"}, {"rb55","45°"}, {"rb46","NE"}, {"rb47","AZYMUT 90°"},
                     {"rb48","E"}, {"rb59","45°"}, {"rb68", "AZYMUT 225°"}, {"rb67","45°"}, {"rb66","ZACHÓD"},
                     {"rrb55","NW"}, {"rb64","POŁUDNIOWY-ZACHÓD"}, {"rb63","AZYMUT 270°"}, {"rrb52", "PÓŁNOCNY-ZACHÓD"}, {"rb62", "135°"},
                     {"rb61","ZACHÓD"}, {"rb70","AZYMUT 225°"}, {"rb60","PÓŁNOC"}
                    };

        /// <summary>
        /// sciezka do grafiki
        /// </summary>
        string sciezka_grafika = @"..\..\..\grafia\";
        /// <summary>
        /// linia - lista punktow, na podstawie ktorych tworzy sie obrazek
        /// </summary>
        List<Point> linia = new List<Point>();
        /// <summary>
        /// ilosc szans
        /// </summary>
        public static int szanse = 3;
        /// <summary>
        /// numer poziomu
        /// </summary>
        public static int poziom = 0;
        /// <summary>
        /// czy wygrano poziom
        /// </summary>
        bool wygrana_poziomu = false;
        /// <summary>
        /// wynik - liczba punktow zdobytych przez uzytkownika
        /// </summary>
        public static int wynik = 0;
        /// <summary>
        /// czas - pozostaly czas rozgrywki
        /// </summary>
        public static int czas;
        /// <summary>
        /// bok kratki - odleglosc boku kratki
        /// </summary>
        float bok_kratki;
        /// <summary>
        /// punkt startowy rysowania linii
        /// </summary>
        Point pkt_start;
        /// <summary>
        /// punkt koncowy rysowania linii
        /// </summary>
        Point pkt_stop;
        /// <summary>
        /// numer punktu obrazka
        /// </summary>
        int nr_pkt = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="Gra"/> class.
        /// </summary>
        public Gra()
        {
            InitializeComponent();
            bok_kratki = rb01.Location.X - rb00.Location.X;
            wybiera_poziom();
            
        }
        /// <summary>
        /// Wczytuje poziom.
        /// </summary>
        private void wczytuje_poziom()
        {
            szanse = 3;
            czas = 120;
            foreach (RadioButton radiobutton in gbPlansza.Controls.OfType<RadioButton>())
            {
                radiobutton.Visible = true;
                radiobutton.Enabled = true;
                radiobutton.Click += new EventHandler(radioButtons_Click); 
            }
            pkt_start = gbPlansza.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Location;

            blokuje_rb(gbPlansza.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked));

            lPoziom.Text = poziom.ToString();

            tCzas.Start();
        }
        /// <summary>
        /// Wybiera poziom.
        /// </summary>
        public void wybiera_poziom()
        {
            switch (poziom)
            {
                case 0:
                    {
                        rysunek = labedz;
                        rb31.Checked = true;
                        bSzanse.Text = "∞";
                        bCzas.Text = "∞";
                    }
                    break;
                case 1:
                    {
                        rysunek = drzewo;
                        rb74.Checked = true;
                        
                    } break;
                case 2:
                    {
                        rysunek = zegarek;
                        rb42.Checked = true;
                    }
                    break;
                case 3:
                    {
                        pbPlansza.Image = Image.FromFile(sciezka_grafika + "plansza.png");
                        rysunek = ptak;
                        rb94.Checked = true;
                    }
                    break;
                case 4:
                    {
                        rysunek = kosciol;
                        rb04.Checked = true;
                    }
                    break;
                case 5:
                    {
                        rysunek = ursaminor;
                        rb56.Checked = true;
                    }
                    break;
                case 6:
                    {
                        rysunek = mrowka;
                        rb40.Checked = true;
                    }
                    break;
            }
            wczytuje_poziom();
            lKierunek.Text = rysunek.Values.ElementAt(nr_pkt);
            ustawia_napis();
        }
        /// <summary>
        /// Ustawia napis.
        /// </summary>
        private void ustawia_napis()
        {
            if (lKierunek.Size.Width > bKierunek.Size.Width)
            {
                lKierunek.Font = new Font("OCR A Extended", 26, FontStyle.Bold);
            }
            lKierunek.Location = new Point(bKierunek.Location.X + bKierunek.Width / 2 - lKierunek.Width / 2, bKierunek.Location.Y + bKierunek.Height / 2 - lKierunek.Height / 2);
        }
        /// <summary>
        /// Handles the Click event of the radioButtons control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radioButtons_Click(object sender, EventArgs e)
        {
            mechanika_gry();
        }
        /// <summary>
        /// Blokuje radiobuttony.
        /// </summary>
        /// <param name="rb">The rb.</param>
        private void blokuje_rb(RadioButton rb)
        {
            if (rb.Checked == true)
            {
                foreach (RadioButton radiobutton in gbPlansza.Controls.OfType<RadioButton>())
                {
                    if ((Math.Abs(radiobutton.Location.X - rb.Location.X) > bok_kratki + 10) || (Math.Abs(radiobutton.Location.Y - rb.Location.Y) > bok_kratki))
                    {
                        radiobutton.Enabled = false;
                    }
                    else
                    {
                        radiobutton.Enabled = true;
                    }
                }
            }
        }
        /// <summary>
        /// Mechanika gry.
        /// </summary>
        protected void mechanika_gry()
        {
            //szukanie zaznaczonego punktu
            var rb = gbPlansza.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //przypisanie do punktu końcowego lokalizacji zaznaczonego radio button'a
            pkt_stop = rb.Location;
            
            //dodanie do rysowanej linii punktów startu i stopu
            linia.Add(pkt_start);
            linia.Add(pkt_stop);

            if (nr_pkt < rysunek.Count)
            {
                //sprawdzenie poprawności zaznaczonego punktu
                if (rysunek.Keys.ElementAt(nr_pkt) == rb.Name || rysunek.Keys.ElementAt(nr_pkt) == "r"+rb.Name)
                {
                    tworzy_linie();
                    blokuje_rb(rb);

                    //rysowanie linii
                    pbPlansza.Invalidate();
                    if (nr_pkt == rysunek.Count - 1)
                    {
                        tCzas.Stop();
                        if (poziom != 0)
                            wynik += (czas / 3) + 10;
                        wygrana_poziomu = true;

                        if (poziom == 2)
                            pbPlansza.Image = Image.FromFile(sciezka_grafika + "zegarek.png");
                        
                        System.Threading.Thread.Sleep(2000);
                        pbPlansza.Invalidate();
                        
                        this.Enabled = false;
                        System.Threading.Thread.Sleep(2000);
                        new Wygrana().Show();
                    }
                    else
                    {
                        pkt_start = pkt_stop;
                        nr_pkt += 1;
                        //wpisanie do etykiety instrukcji dotyczącej kolejnego posunięcia (np. PÓŁNOC)  
                        lKierunek.Font = new Font("OCR A Extended", 48, FontStyle.Bold);
                        lKierunek.Text = rysunek.Values.ElementAt(nr_pkt);
                        ustawia_napis();
                    }
                }
                else if (rysunek.Keys.ElementAt(nr_pkt) != rb.Name && pkt_start != pkt_stop)
                {
                    //odejmowanie punktów (szans)
                    if (poziom != 0)
                    {
                        szanse--;
                        if (szanse != -1)
                            bSzanse.Text = szanse.ToString();
                    }
                    linia.Remove(pkt_stop);
                    if (szanse == -1)
                    {
                        tCzas.Stop();
                        szanse = 0;

                        this.Enabled = false;
                        new Przegrana().Show();
                    }
                    //wpisanie ilości szans do etykiety
                }
            }
        }
        /// <summary>
        /// Tworzy linie.
        /// </summary>
        protected void tworzy_linie()
        {
            switch (poziom)
            {
                case 4:
                    {
                        if (rysunek.Keys.ElementAt(nr_pkt) == "rb14")
                        {
                            linia.Add(rb13.Location);
                            linia.Add(rb15.Location);
                            linia.Add(rb14.Location);
                        }
                    }
                    break;
                case 6:
                    {
                        switch (rysunek.Keys.ElementAt(nr_pkt))
                        {
                            case "rb43":
                                {
                                    linia.Add(rb33.Location);
                                    linia.Add(rb32.Location);
                                    linia.Add(rb33.Location);
                                    linia.Add(rb43.Location);
                                }
                                break;
                            case "rb44":
                                {
                                    linia.Add(rb34.Location);
                                    linia.Add(rb23.Location);
                                    linia.Add(rb34.Location);
                                    linia.Add(rb44.Location);
                                }
                                break;
                            case "rb55":
                                {
                                    linia.Add(rb35.Location);
                                    linia.Add(rb24.Location);
                                    linia.Add(rb35.Location);
                                    linia.Add(rb55.Location);
                                }
                                break;
                            case "rrb55":
                                {
                                    linia.Add(rb75.Location);
                                    linia.Add(rb84.Location);
                                    linia.Add(rb75.Location);
                                    linia.Add(rb55.Location);
                                }
                                break;
                            case "rb64":
                                {
                                    linia.Add(rb74.Location);
                                    linia.Add(rb83.Location);
                                    linia.Add(rb74.Location);
                                    linia.Add(rb64.Location);
                                }
                                break;
                            case "rb63":
                                {
                                    linia.Add(rb73.Location);
                                    linia.Add(rb72.Location);
                                    linia.Add(rb73.Location);
                                    linia.Add(rb63.Location);
                                }
                                break;
                            case "rb61":
                                {
                                    linia.Add(rb41.Location);
                                    linia.Add(rb61.Location);
                                }
                                break;
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// Handles the Paint event of the pbPlansza control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected void pbPlansza_Paint(object sender, PaintEventArgs e)
        {
            if (!wygrana_poziomu)
            {
                for (int i = 0; i < linia.Count - 1; i++)
                {
                    using (var p = new Pen(System.Drawing.ColorTranslator.FromHtml("#45818e"), 8))
                    {
                        e.Graphics.DrawLine(p, linia[i].X - 10, linia[i].Y - 10, linia[i + 1].X - 10, linia[i + 1].Y - 10);
                    }
                }
            }
            else
            {
                foreach (RadioButton radiobutton in gbPlansza.Controls.OfType<RadioButton>())
                {
                    radiobutton.Visible = false;
                    radiobutton.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Handles the Tick event of the tCzas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tCzas_Tick(object sender, EventArgs e)
        {
            if (poziom != 0)
            {
                czas -= 1;
                bCzas.Text = czas.ToString();
                if (czas == 0)
                {
                    tCzas.Stop();
                    new Przegrana().Show();
                    this.Enabled = false;
                }
            }
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
        /// <summary>
        /// Handles the Click event of the bPomoc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bPomoc_Click(object sender, EventArgs e)
        {
            tCzas.Stop();
            new Pomoc(tCzas).Show();
        }
    }
}
