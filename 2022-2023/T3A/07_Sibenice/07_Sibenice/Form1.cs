namespace _07_Sibenice
{
    public partial class Form1 : Form
    {
        private int zivoty;
        private string slovo;
        private List<char> pismena;
        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private string VyberSlovo()
        {
            string[] slova = { "kalamita", "robot", "hrozno", "pejsek", "hradebka"};
            return slova[new Random().Next(0, slova.Length)];
        }

        private string HadejSlovo()
        {
            string tmp = "";
            foreach (char c in slovo)
            {
                if (pismena.Contains(c))
                    tmp += $"{c}";
                else
                    tmp += $"-";
            }
            return tmp;
        }

        private void BtnHadeji_Click(object sender, EventArgs e)
        {
            if(TxtPismeno.Text.Length >1 || TxtPismeno.Text.Length == 0)
            {
                MessageBox.Show("Neplatný vstup");
                return;
            }
            char hadanePismeno = char.Parse(TxtPismeno.Text);
            pismena.Add(hadanePismeno);
            // vycerpani vsech zivotu
            if(zivoty == 0)
            {
                DialogResult dr = MessageBox.Show($"Hádané slovo: {slovo}{Environment.NewLine}Nová hra?", "Looser", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    Close();
                }
            }
            // rozhodnutí tipu
            if (slovo.Contains(hadanePismeno))
            {
                LblResult.Text = HadejSlovo();
            }
            else
            {
                zivoty--;
                LblZivoty.Text = $"{zivoty}";
            }
            // uhádnutí slova
            if(slovo == LblResult.Text)
            {
               DialogResult dr =  MessageBox.Show("Nová hra?","Winner",MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Close();
                }
            }

        }

        /// <summary>
        /// Inicializace nové hry
        /// </summary>
        private void NewGame()
        {
            zivoty = 13;
            pismena = new List<char>();
            LblZivoty.Text = $"{zivoty}";
            slovo = VyberSlovo();
            LblResult.Text = HadejSlovo();
        }
    }
}