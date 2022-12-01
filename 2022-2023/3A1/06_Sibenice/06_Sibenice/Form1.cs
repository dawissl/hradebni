namespace _06_Sibenice
{
    public partial class Form1 : Form
    {
        private List<char> hadanaPismena;
        private string hadaneSlovo;
        private int zivoty;

        public Form1()
        {
            InitializeComponent();
            NovaHra();
        }

        private void NovaHra()
        {
            hadanaPismena = new List<char>();
            zivoty = 13;
            //$ = alt + 36
            LblLives.Text = $"{zivoty}";
            hadaneSlovo = VygenerujSlovo();
            LblResult.Text = HadejPismeno();

        }

        private string VygenerujSlovo()
        {
            string[] slova = { "koštì" };
            return slova[new Random().Next(0, slova.Length)];
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            // kontrola správného vstupu
            if (TxtLetter.Text.Length != 1)
            {
                MessageBox.Show("Hadej pouze jedno pismeno");
                return;
            }
            char pismeno = char.Parse(TxtLetter.Text);
            // pokud jiz pismeno je v seznamu, znovu jej nepridavame
            if (hadanaPismena.Contains(pismeno))
            {
                MessageBox.Show("Pismeno jiz bylo hadané");
                return;
            }
            if (pismeno == 's') hadanaPismena.Add('š');
            if (pismeno == 'e')
            {
                hadanaPismena.Add('é');
                hadanaPismena.Add('ì');
            }
            hadanaPismena.Add(pismeno);
            TxtLetter.Text = "";
            string tmp = HadejPismeno();

            // rozhodnuti o ubrani zivotu
            if (tmp == LblResult.Text)
            {
                zivoty--;
                Refresh();
                LblLives.Text = $"{zivoty}";
                if (zivoty == 0)
                {
                    DialogResult dr;
                    dr = MessageBox.Show($"Hádané slovo{Environment.NewLine}" +
                         $"{hadaneSlovo}", "Konec hry", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        NovaHra();
                        return;
                    }
                    else
                    {
                        Close();
                    }

                }
            }
            LblResult.Text = tmp;

            if (LblResult.Text == hadaneSlovo)
            {
                DialogResult dr;
                dr = MessageBox.Show("Uhadnul jsi slovo!", "Konec hry",
                                      MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    NovaHra();
                    return;
                }
                else
                {
                    Close();
                }
            }
        }

        /// <summary>
        /// Reseni hadani pismena na zaklade pridanych pismeno v listu
        /// </summary>
        /// <returns>hadane slov pomlèky pøedstavují neuhadnute</returns>
        private string HadejPismeno()
        {
            string tmp = "";
            foreach (char c in hadaneSlovo)
            {
                if (hadanaPismena.Contains(c))
                {
                    tmp += $"{c}";
                }
                else
                {
                    tmp += "-";
                }
            }
            return tmp;
        }

        private void TxtLetter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("enter");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < 13; i++)
            {
                g.FillEllipse(Brushes.Green, 50 + 40 * i, 300, 30, 30);
            }
            for (int i = zivoty; i < 13; i++)
            {
                g.FillEllipse(Brushes.Red, 50 + 40 * i, 300, 30, 30);
            }

        }
    }
}