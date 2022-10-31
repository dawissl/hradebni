namespace _02_RozdeleniTymu
{
    public partial class Form1 : Form
    {
        private List<string> listOfplayers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Zadejte jm�no hr��e");
                return;
            }
            else
            {
                listOfplayers.Add(TxtName.Text);
            }
            // aktualizece seznamu hr��� po p�id�n�
            LblPlayers.Text = "";
            foreach (string player in listOfplayers)
            {
                LblPlayers.Text += player + Environment.NewLine;
            }
        }

        private void BtnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listOfplayers.Count == 0) return;
            if (listOfplayers.IndexOf(TxtName.Text) != -1)
            {
                listOfplayers.Remove(TxtName.Text);
            }
            if (TxtName.Text == "")
            {
                listOfplayers.RemoveAt(listOfplayers.Count - 1);
            }
            // vypsani upraven�ho seznamu hr���
            LblPlayers.Text = "";
            foreach (string player in listOfplayers)
            {
                LblPlayers.Text += player + Environment.NewLine;
            }
        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            int teamCount = (int)NumTeam.Value;
            int playersOver = listOfplayers.Count % teamCount;

            if(teamCount > listOfplayers.Count)
            {
                return;
            }
            if(teamCount <= 0)
            {
                return;
            }
            string newTeams = "";
            int baseNumberOfPlayers = listOfplayers.Count/teamCount;
            int tmpBase = 0;
            foreach (string player in listOfplayers)
            {                
                if(playersOver > 0)
                {
                    if (tmpBase != baseNumberOfPlayers + 1)
                    {
                        newTeams += player + Environment.NewLine;
                        //tmpBase++;
                        playersOver--;
                    }
                    else
                    {
                        newTeams += "---------"+Environment.NewLine;
                        tmpBase = 0;
                    }                    
                }
                else
                {
                    if(tmpBase != baseNumberOfPlayers)
                    {
                        newTeams += player + Environment.NewLine;
                        tmpBase++;
                    }
                    else
                    {
                        newTeams += "---------" + Environment.NewLine;
                        tmpBase = 0;
                    }
                }

               

            }
            LblTeam.Text = newTeams;

        }
    }
}