using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stdiu
{
    public partial class SchoolSurvior : Form
    {
        public SchoolSurvior()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPage1(panelStart);
            IncarcaIntreabri();
        }

        private void ShowPage1(Panel page)
        {
            panelStart.Hide();
            panelWalk.Hide();
            panelExam.Hide();
            panelExamQuestion.Hide();

            page.Visible = true;
            page.BringToFront();
        }


        private void bttnStart_Click(object sender, EventArgs e)
        {
            panelStart.Hide();
            panelWalk.Show();
            panelWalk.BringToFront();

            StartPlayerAnimation();
        }

        int vitezaPlayer = 4;

        private void StartPlayerAnimation()
        {
            pbPlayer.Left = (panelWalk.ClientSize.Width - pbPlayer.Width) / 2;

            pbPlayer.Top = panelWalk.ClientSize.Height - pbPlayer.Height - 10;

            timerWalk.Start();
        }

        private void timerWalk_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top -= vitezaPlayer;

            if(pbPlayer.Top <= 150)
            {
                timerWalk.Stop();
                StartFade();
            }
        }

        bool fadeOut = true;

        private void StartFade()
        {
            fadeOut = true;
            timerFade.Start();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (fadeOut)
            {
                this.Opacity -= 0.1;
                
                if(this.Opacity <= 0.1)
                {
                    this.Opacity = 0;
                    panelWalk.Visible = false;
                    panelExam.Visible = true;
                    panelExam.BringToFront();

                    fadeOut = false;
                }
            } 
            else
            {
                this.Opacity += 0.1;

                if(this.Opacity >= 0.9)
                {
                    this.Opacity = 1;
                    timerFade.Stop();
                }
            }
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            panelExam.Hide();
            panelExamQuestion.Show();
            panelExamQuestion.BringToFront();

            Random random = new Random();

            intrebariExamen = intrebari
                .OrderBy(x => random.Next())
                .Take(10)
                .ToList();

            indexIntrebare = 0;
            raspunsuriCorecte = 0;
            AfiseazaIntrebare();
        }

        List<Intrebare> intrebari = new List<Intrebare>();
        int indexIntrebare = 0;
        int raspunsuriCorecte = 0;

        List<Intrebare> intrebariExamen = new List<Intrebare>();

        private void IncarcaIntreabri()
        {
            string cale = Path.Combine(
                Application.StartupPath,
                "TextFile1.txt"
                );

            string[] linii = File.ReadAllLines(cale);

            Intrebare intrebare = null;

            foreach (string rand in linii)
            {
                string linie = rand.Trim();

                if (linie == "")
                    continue;
                if (char.IsDigit(linie[0]) &&
                        linie.Contains(". "))
                {
                    if (intrebare != null)
                        intrebari.Add(intrebare);

                    intrebare = new Intrebare();
                    intrebare.Text = linie.Substring(linie.IndexOf(". ") + 2);
                }
                else if (intrebare != null &&
             linie.StartsWith("A)"))
                {
                    intrebare.Variante[0] = linie;
                }
                else if (intrebare != null &&
                         linie.StartsWith("B)"))
                {
                    intrebare.Variante[1] = linie;
                }
                else if (intrebare != null &&
                         linie.StartsWith("C)"))
                {
                    intrebare.Variante[2] = linie;
                }
                else if (intrebare != null &&
                         linie.StartsWith("D)"))
                {
                    intrebare.Variante[3] = linie;
                }
                else if (intrebare != null &&
                         linie.StartsWith("Răspuns corect:"))
                {
                    string raspuns = linie.Substring(
                        linie.IndexOf(':') + 1
                    ).Trim();

                    intrebare.RaspunsCorect =
                        char.ToUpper(raspuns[0]);
                }
                else if (intrebare != null)
                {
                    intrebare.Text += " " + linie;
                }
            }

            if (intrebare != null)
                intrebari.Add(intrebare);
        }
        private void AfiseazaIntrebare()
        {
            if(indexIntrebare >= intrebariExamen.Count)
            {
                lblProgres.Text = "Examen Terminat!";
                lblIntrebare.Text = "Ai raspuns la toate intrebarile";


                rdA.Visible = false;
                rdB.Visible = false;
                rdC.Visible = false;
                rdD.Visible = false;

                btnVerfica.Visible = false;
                btnNext.Visible = false;
                lblFeedBack.Text = " Rezultat: " + (raspunsuriCorecte * 100 / intrebariExamen.Count) + "%";

                return;
            }

            Intrebare q = intrebariExamen[indexIntrebare];

            lblProgres.Text = "Întrebarea " +
                (indexIntrebare + 1) + " din " +
                intrebariExamen.Count;

            lblIntrebare.Text = q.Text;

            rdA.Text = q.Variante[0];
            rdB.Text = q.Variante[1];
            rdC.Text = q.Variante[2];
            rdD.Text = q.Variante[3];

            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;

            rdA.Visible = true;
            rdB.Visible = true;
            rdC.Visible = true;
            rdD.Visible = true;

            rdA.Enabled = true;
            rdB.Enabled = true;
            rdC.Enabled = true;
            rdD.Enabled = true;

            btnVerfica.Visible = true;
            btnNext.Visible = false;

            lblFeedBack.Text = "";
        }

        private void btnVerfica_Click(object sender, EventArgs e)
        {
            char raspuns = ' ';

            if (rdA.Checked)
                raspuns = 'A';
            else if (rdB.Checked)
                raspuns = 'B';
            else if (rdC.Checked)
                raspuns = 'C';
            else if (rdD.Checked)
                raspuns = 'D';

            if (raspuns == ' ')
            {
                lblFeedBack.Text = "Selectează un răspuns!";
                return;
            }

            if (raspuns ==
                intrebariExamen[indexIntrebare].RaspunsCorect)
            {
                lblFeedBack.Text = "Corect!";
                raspunsuriCorecte++;
            }
            else
            {
                lblFeedBack.Text = "Greșit! Răspunsul corect este " +
                    intrebariExamen[indexIntrebare].RaspunsCorect + ".";
            }

            rdA.Enabled = false;
            rdB.Enabled = false;
            rdC.Enabled = false;
            rdD.Enabled = false;

            btnVerfica.Visible = false;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            indexIntrebare++;
            AfiseazaIntrebare();
        }
    }
    public class Intrebare
    {
        public string Text;
        public string[] Variante = new string[4];
        public char RaspunsCorect;

    }
}
        