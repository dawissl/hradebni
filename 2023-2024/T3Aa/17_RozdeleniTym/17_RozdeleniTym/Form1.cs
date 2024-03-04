using System.Diagnostics;

namespace _17_RozdeleniTym
{
    public partial class Form1 : Form
    {
        private List<Player> hraci = new List<Player>();
        public Form1()
        {
            InitializeComponent();
            GeneratePlayers();
            //MessageBox.Show(PrintPlayers());
        }

        private void BtnSplitToTeams_Click(object sender, EventArgs e)
        {
            if (NumTeams.Value <= 1)
            {
                MessageBox.Show("Minimální poèet týmù jsou dva");
                return;
            }
            int[] tymyPocty;
            int idealniPocet = (int)(hraci.Count / NumTeams.Value);
            if (hraci.Count % NumTeams.Value == 0)
            {
                // v kazdem tymu je stejny pocet hracu

                tymyPocty = new int[(int)NumTeams.Value];
                for (int i = 0; i < tymyPocty.Length; i++)
                    tymyPocty[i] = idealniPocet;
            }
            else
            {
                int nadpocetniHraci = (int)(hraci.Count % NumTeams.Value);
                tymyPocty = new int[(int)NumTeams.Value];
                for (int i = 0; i < tymyPocty.Length; i++)
                    tymyPocty[i] = idealniPocet;
                for (int i = 0; i < nadpocetniHraci; i++)
                {
                    tymyPocty[i]++;
                }
            }

            // TODO rozdelit do tymu
        }
        private string PrintPlayers()
        {
            string p = "";
            foreach (Player player in hraci)
            {
                p += player.Print() + Environment.NewLine;
            }
            return p;
        }

        private void GeneratePlayers()
        {
            Random r = new Random();

            string[] names = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "AA", "BB", "CC", "DD" };
            for (int i = 0; i < 10; i++)
            {
                if (r.Next() % 2 == 1)
                {
                    hraci.Add(new Player(names[r.Next(names.Length)], "H"));
                }
                else
                {
                    hraci.Add(new Player(names[r.Next(names.Length)], "K"));
                }
            }

        }
    }

    public struct Player
    {
        public string Name { get; init; }
        public string Gender { get; init; }

        public Player(string name, string gender)
        {
            Name = name.ToUpper();
            Gender = gender.ToUpper();
        }
        public string Print()
        {
            return $"{Name} ({Gender})";
        }
    }
}