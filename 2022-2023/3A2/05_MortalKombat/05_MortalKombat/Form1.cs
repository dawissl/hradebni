namespace _05_MortalKombat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            // vytvo�en� hr���
            Player p1 = new Player("Fifinka", 10, 7, 6);
            Player p2 = new Player("Bobik", 6, 4, 15);
            Player p3 = new Player("Mispulin", 11, 8, 5);
            Player p4 = new Player("Pinda", 10, 7, 7);

            //napln�n� combo box� hr��i
            ComboPlayerOne.Items.Add(p1);
            ComboPlayerOne.Items.Add(p2);
            ComboPlayerOne.Items.Add(p3);
            ComboPlayerOne.Items.Add(p4);

            ComboPlayerTwo.Items.Add(p1);
            ComboPlayerTwo.Items.Add(p2);
            ComboPlayerTwo.Items.Add(p3);
            ComboPlayerTwo.Items.Add(p4);


        }

        private void BtnFight_Click(object sender, EventArgs e)
        {
            // | = alt + 124
            if (ComboPlayerOne.SelectedIndex == -1 || ComboPlayerTwo.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber hr��e pro souboj");
                return;
            }
            TxtLog.Text = "";
            Player p1 = (Player)ComboPlayerOne.SelectedItem;
            Player p2 = (Player)ComboPlayerTwo.SelectedItem;

            // TODO souboj + log o souboji

            Random rand = new Random();
            // & = alt + 38
            while (p1.Health > 0 && p2.Health > 0)
            {
                int hitpoints = (int)(10 * (rand.Next(p1.AttackMin, p1.AttackMax + 1) / (double)p2.Defence));
                p2.Health = hitpoints;

                TxtLog.Text += $"{p1} za�to�il silou: {hitpoints}{Environment.NewLine}";
                TxtLog.Text += $"{p2}{Environment.NewLine}";
                //neumrel hrac2 ?
                if(p2.Health > 0)
                {
                    hitpoints = (int)(10 * (rand.Next(p2.AttackMin, p2.AttackMax + 1) / (double)p1.Defence));
                    p1.Health = hitpoints;
                    TxtLog.Text += $"{p2} za�to�il silou: {hitpoints}{Environment.NewLine}";
                    TxtLog.Text += $"{p1}{Environment.NewLine}";
                }
            }

            // TODO zobrazeni v�teze
            if(p1.Health > p2.Health)
            {
                MessageBox.Show($"Vyhr�l {p1}");
            }
            else
            {
                MessageBox.Show($"Vyhr�l {p2}");
            }

            p1.RestoreHealth(100);
            p2.RestoreHealth(100);

        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            NewPlayerForm f = new NewPlayerForm();
            DialogResult dg = f.ShowDialog();

            if(dg != DialogResult.OK)
            {
                MessageBox.Show($"{dg}");
            }
        }
    }
}