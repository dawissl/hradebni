using System.Text.RegularExpressions;

namespace _17_RozdeleniTym
{
    public partial class Form1 : Form
    {
        List<Hrac> players = new List<Hrac>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (RadioBoy.Checked)
            {
                players.Add(new Hrac(TxtName.Text.ToUpper(), "K"));
            }
            else
            {
                players.Add(new Hrac(TxtName.Text.ToUpper(), "H"));
            }
        }

        private void BtnCreateTeams_Click(object sender, EventArgs e)
        {
            if (NumTeamCount.Value <= 1)
            {
                MessageBox.Show("Minimalni pocet tymu jsou dva");
                return;
            }
            int idealPlayersCount = (int)(players.Count / NumTeamCount.Value);
            int plusPlayers = (int)(players.Count % NumTeamCount.Value);
            int[] teamCount = new int[(int)NumTeamCount.Value];
            // naplneni tymu poctem hracu
            for (int i = 0; i < teamCount.Length; i++)
            {
                teamCount[i] = idealPlayersCount;
            }
            // pridani hracu navic
            if (plusPlayers != 0)
            {
                for (int i = 0; i < plusPlayers; i++)
                {
                    teamCount[i]++;
                }
            }
            Hrac[][] teams = new Hrac[teamCount.Length][];
            int playerIndex = 0;
            for (int i = 0; i < teamCount.Length; i++)
            {
                teams[i] = new Hrac[teamCount[i]];
                for(int j = 0; j < teamCount[i]; j++)
                {
                    teams[i][j] = players[playerIndex];
                    playerIndex++;
                }
            }

            TxtTeams.Text = PrinTeams(teams);
        }

        private string PrinTeams(Hrac[][] teams)
        {
            string print = "";
            for(int i= 0; i < teams.Length; i++)
            {
                print += $"Tým {i+1}:{Environment.NewLine}";
                foreach(Hrac hrac in teams[i])
                {
                    print += $"{hrac.Print()}{Environment.NewLine}";
                }
            
            }
            return print;
            
        }
    }

    public struct Hrac
    {
        public string Name { get; init; }
        public string Gender { get; init; }

        public Hrac(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }

        public string Print()
        {
            return $"{Name} ({Gender})";
        }
    }
}