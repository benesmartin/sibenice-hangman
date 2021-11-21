using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sibenice
{
    public partial class Form1 : Form
    {
        private string[] slova = { "Kubín", "Haberzettl", "Douda", "Balín", "Medřický", "Horáček", "Neustupa", "Studihradová", "Beneš", "Brychtová", "Hoffmann", "Kučera", "Kříž", "Rys" };
        private string[] diakritika = { "Á", "É", "Ě", "Í", "Ý", "Ó", "Ú", "Ů", "Ž", "Š", "Č", "Ř", "Ď", "Ť", "Ň" };
        private static Random rand = new Random((int)DateTime.Now.Ticks);
        private List<string> spravne = new List<string>();
        private List<string> spatne = new List<string>();
        private string nahodneSlovo, nahodneSlovoUppercase, pismeno;
        private int pokusy = 10;
        private bool vyhral = false, prohral = false;
        private StringBuilder sibeniceSlovo;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        static string RemoveAccents(string input)
        {
            string normalized = input.Normalize(NormalizationForm.FormKD);
            Encoding removal = Encoding.GetEncoding(Encoding.ASCII.CodePage, new EncoderReplacementFallback(""), new DecoderReplacementFallback(""));
            byte[] bytes = removal.GetBytes(normalized);
            return Encoding.ASCII.GetString(bytes);
        }
        private void newWord()
        {
            pokusy = 10;
            lbChars.Text = "✅ \n❎ \nPokusy: " + Convert.ToString(pokusy);
            spravne.Clear();
            spatne.Clear();
            vyhral = false;
            prohral = false;
            pb1.Image = Properties.Resources.hangman11;
            nahodneSlovo = slova[rand.Next(0, slova.Length)];
            nahodneSlovoUppercase = RemoveAccents(nahodneSlovo.ToUpper());
            sibeniceSlovo = new StringBuilder(nahodneSlovo.Length);
            for (int i = 0; i < nahodneSlovo.Length; i++)
            {
                sibeniceSlovo.Append('-');
            }
        }
        private void Game()
        {
            if (vyhral == false && pokusy >= 0)
            {
                pismeno = tbChar.Text.ToUpper();
                if (spravne.Contains(pismeno))
                {
                    spravne.Remove(pismeno);
                }
                if (spatne.Contains(pismeno))
                {
                    spatne.Remove(pismeno);
                    pokusy++;
                }
                if (nahodneSlovoUppercase.Contains(pismeno))
                {
                    spravne.Add(pismeno);
                    for (int i = 0; i < nahodneSlovo.Length; i++)
                    {
                        if (Convert.ToString(nahodneSlovoUppercase[i]) == pismeno)
                        {
                            sibeniceSlovo[i] = nahodneSlovo[i];
                        }
                    }
                    if (Convert.ToString(sibeniceSlovo) == nahodneSlovo)
                    {
                        vyhral = true;
                    }
                }
                else
                {
                    spatne.Add(pismeno);
                    pokusy--;
                    if (pokusy == 9)
                    {
                        pb1.Image = Properties.Resources.hangman10;
                    }
                    if (pokusy == 8)
                    {
                        pb1.Image = Properties.Resources.hangman9;
                    }
                    if (pokusy == 7)
                    {
                        pb1.Image = Properties.Resources.hangman8;
                    }
                    if (pokusy == 6)
                    {
                        pb1.Image = Properties.Resources.hangman7;
                    }
                    if (pokusy == 5)
                    {
                        pb1.Image = Properties.Resources.hangman6;
                    }
                    if (pokusy == 4)
                    {
                        pb1.Image = Properties.Resources.hangman5;
                    }
                    if (pokusy == 3)
                    {
                        pb1.Image = Properties.Resources.hangman4;
                    }
                    if (pokusy == 2)
                    {
                        pb1.Image = Properties.Resources.hangman3;
                    }
                    if (pokusy == 1)
                    {
                        pb1.Image = Properties.Resources.hangman2;
                    }
                    if (pokusy == 0)
                    {
                        pb1.Image = Properties.Resources.hangman;
                        prohral = true;
                    }
                }
                lbWord.Text = sibeniceSlovo.ToString();
            }
            if (vyhral)
            {
                if (pokusy == 10)
                {
                    MessageBox.Show("Perfekt!\nDokázal jsi vyhrát bez ztráty pokusu!", "Gratuluji!");
                }
                else
                {
                    MessageBox.Show("Vyhrál jsi!", "Gratuluji!");
                }

            }
            if (prohral)
            {
                MessageBox.Show("Prohrál jsi!\nSprávná odpověď je: " + nahodneSlovo, "Bohužel!");
            }
            lbChars.Text = "✅ " + string.Join(',', spravne) + "\n❎ " + string.Join(',', spatne) + "\nPokusy: " + Convert.ToString(pokusy);
        }
        private void configControls()
        {
            this.ActiveControl = tbChar;
            this.tbChar.AutoSize = false;

            pb1.Location = new Point(0, 0);
            pb1.Size = new Size(ClientRectangle.Width / 2, ClientRectangle.Height);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            lbWord.Size = new Size(pb1.Width, Convert.ToInt32(pb1.Height * 0.3));
            lbWord.Location = new Point(pb1.Width, 0);
            lbWord.Font = new Font("Arial", this.ClientSize.Height / 15);
            lbWord.Text = sibeniceSlovo.ToString();

            btnNew.Size = new Size(pb1.Width, Convert.ToInt32(pb1.Height * 0.125));
            btnNew.Location = new Point(ClientRectangle.Width - btnNew.Width, ClientRectangle.Height - btnNew.Height);
            btnNew.Font = new Font("Arial", this.ClientSize.Height / 15);

            tbChar.Size = new Size(pb1.Width, Convert.ToInt32(pb1.Height * 0.2));
            tbChar.Location = new Point(ClientRectangle.Width - tbChar.Width, lbWord.Location.Y + lbWord.Height);
            tbChar.Font = new Font("Arial", Convert.ToInt32(tbChar.Height * 0.75));

            lbChars.Size = new Size(pb1.Width, Convert.ToInt32(pb1.Height * 0.375));
            lbChars.Location = new Point(ClientRectangle.Width - lbChars.Width, tbChar.Location.Y + tbChar.Height);
            lbChars.Font = new Font("Arial", this.ClientSize.Height / 20);
            lbChars.Text = "✅ " + string.Join(',', spravne) + "\n❎ " + string.Join(',', spatne) + "\nPokusy: " + Convert.ToString(pokusy);
        }
        public void Init()
        {
            newWord();
            configControls();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            configControls();
        }
        private void tbChar_TextChanged(object sender, EventArgs e)
        {
            if (tbChar.Text != "")
            {
                if (tbChar.Text != RemoveAccents(tbChar.Text))
                {
                    for (int i = 0; i < diakritika.Length; i++)
                    {
                        if (tbChar.Text.ToUpper() == diakritika[i])
                        {
                            tbChar.Text = RemoveAccents(tbChar.Text);
                        }
                    }
                }
                else
                {
                    Game();
                    tbChar.Text = "";
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            newWord();
            lbWord.Text = sibeniceSlovo.ToString();
            this.ActiveControl = tbChar;
        }
    }
}
