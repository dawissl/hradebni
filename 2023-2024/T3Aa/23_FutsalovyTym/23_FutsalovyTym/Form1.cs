using System.Drawing.Text;

namespace _23_FutsalovyTym
{
    public partial class Form1 : Form
    {
        private List<Hrac> soupiska;
        private const int SQUAD_SIZE = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            soupiska = new List<Hrac>();
            Random r = new Random();
            string output = "";
            for (int i = 0; i < SQUAD_SIZE; i++)
            {
                string name = CreateName(r.Next());
                string surname = CreateName(r.Next());
                Positioin position = ChoosePosition(r.Next());
                Hrac h = new Hrac(name, surname, i + 1, r.Next(30, 51), r.Next(30, 51), r.Next(30, 51), position);
                soupiska.Add(h);
                output += h.ToString() + Environment.NewLine;
            }
            TxtDefault.Text = output;
            output = "";
            soupiska.Sort(); // serazeni týmu podle hodnoceni
            soupiska.Reverse(); // pøeklopení pole pro seøazení od nejvyššího hodnocení
            foreach (Hrac h in soupiska)
            {
                output += h.ToString() + Environment.NewLine;
            }
            TxtSorted.Text = output;

        }

        private Positioin ChoosePosition(int v)
        {
            switch (v % 3)
            {
                case 0: return Positioin.STRIKER;
                case 1: return Positioin.DEFFENDER;
                case 2: return Positioin.GOALKEEPER;
                default: return Positioin.STRIKER;
            }
        }
        private string CreateName(int v)
        {
            return Convert.ToChar('A' + v % 26).ToString();
        }

        private void BtnSquad_Click(object sender, EventArgs e)
        {
            int wa = 0, wd = 0, wg = 1;
            if (Rad131.Checked) { wa = 1; wd = 3; }
            if (Rad311.Checked) { wa = 3; wd = 1; }
            if (Rad221.Checked) { wa = 2; wd = 2; }

            List<Hrac> sestava = new List<Hrac>();
            string output = "";
            foreach (Hrac h in soupiska)
            {
                if (wa == 0 && wd == 0 && wg == 0) break;
                if (h.Position == Positioin.STRIKER && wa > 0)
                {
                    sestava.Add(h);
                    wa--;
                    output += h.ToString() + Environment.NewLine;
                }
                if (h.Position == Positioin.DEFFENDER && wd > 0)
                {
                    sestava.Add(h);
                    wd--;
                    output += h.ToString() + Environment.NewLine;

                }
                if (h.Position == Positioin.GOALKEEPER && wg > 0)
                {
                    sestava.Add(h);
                    wg--;
                    output += h.ToString() + Environment.NewLine;
                }
            }
            TxtSorted.Text = output;
        }
    }
}
