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

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            soupiska = new List<Hrac>();
            Random r = new Random();
            string output = "";
            for (int i = 0; i < SQUAD_SIZE; i++)
            {
                string name = GenerateName(r.Next());
                string surname = GenerateName(r.Next());
                Position pos = ChoosePosition(r.Next());
                Hrac h = new Hrac(name, surname, i + 1, r.Next(30, 51), r.Next(30, 51), r.Next(30, 51), pos);
                soupiska.Add(h);
                output += h.ToString() + Environment.NewLine;
            }
            TxtDefault.Text = output;
            soupiska.Sort();
            soupiska.Reverse();
            output = "";
            foreach (Hrac h in soupiska)
            {
                output += h.ToString() + Environment.NewLine;
            }
            TxtSorted.Text = output;
        }

        private Position ChoosePosition(int v)
        {
            switch (v % 3)
            {
                case 0: return Position.ST;
                case 1: return Position.DF;
                default: return Position.GK;
            }
        }
        private string GenerateName(int v)
        {
            return  Convert.ToChar('A' + v % 26).ToString() + Convert.ToChar('z' - v % 26).ToString();
        }

        private void BtnSquad_Click(object sender, EventArgs e)
        {
            int aw = 0, wg = 1, dw = 0;
            if (Rad131.Checked)
            {
                aw = 1;
                dw = 3;
            }
            if (Rad221.Checked)
            {
                aw = 2;
                dw = 2;
            }
            if (Rad311.Checked)
            {
                aw = 3;
                dw = 1;
            }
            List<Hrac> sestava = new List<Hrac>();
            string output = "";
            foreach(Hrac h in soupiska)
            {
                if (aw == 0 && wg == 0 && dw == 0) break;
                if(h.GetPosition == Position.ST && aw > 0)
                {
                    sestava.Add(h);
                    output += h.ToString() + Environment.NewLine;
                    aw--;
                }
                if (h.GetPosition == Position.GK && wg > 0)
                {
                    sestava.Add(h);
                    output += h.ToString() + Environment.NewLine;
                    wg--;
                }
                if (h.GetPosition == Position.DF && dw > 0)
                {
                    sestava.Add(h);
                    output += h.ToString() + Environment.NewLine;
                    dw--;
                }
            }
            TxtSorted.Text = output;
        }
    }
}