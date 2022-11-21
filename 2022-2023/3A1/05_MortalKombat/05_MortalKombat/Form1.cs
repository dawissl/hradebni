namespace _05_MortalKombat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Bobík
            ComboPlayerOne.Items.Add(new Fighter("Bobík",7,10,6));
            ComboPlayerTwo.Items.Add(new Fighter("Bobík", 7, 10, 6));
            // Mišpulín
            ComboPlayerOne.Items.Add(new Fighter("Mišpulín", 5, 11, 7));
            ComboPlayerTwo.Items.Add(new Fighter("Mišpulín", 5, 11, 7));
            // Pinïa
            ComboPlayerOne.Items.Add(new Fighter("Pinïa", 8, 13, 4));
            ComboPlayerTwo.Items.Add(new Fighter("Pinïa", 8, 13, 4));

        }

        private void ButtonFight_Click(object sender, EventArgs e)
        {
            // | = alt + 124
            if(ComboPlayerOne.SelectedIndex == -1 || ComboPlayerTwo.SelectedIndex == -1)
            {
                MessageBox.Show("Zvolte hráèe");
                return;
            }

	    LblOut.Text = "";
            Fighter playerOne = (Fighter)ComboPlayerOne.SelectedItem;
            Fighter playerTwo = (Fighter)ComboPlayerTwo.SelectedItem;

            Random rnd = new Random();
            // & = alt + 38
            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                int attack = rnd.Next(playerOne.MinAttack, playerOne.MaxAttack + 1);
                int tmp = (int)(attack / (double)playerTwo.Defense) * 10;
                playerTwo.Health = tmp;
                LblOut.Text += $"{playerOne.Name} zaútoèil silou {tmp}{Environment.NewLine}";
                LblOut.Text += $"{playerTwo}{Environment.NewLine}";

                if (playerTwo.Health > 0)
                {
                    attack = rnd.Next(playerTwo.MinAttack, playerTwo.MaxAttack + 1);
                    tmp = (int)(attack / (double)playerOne.Defense) * 10;
                    playerOne.Health = tmp;
                }
                else
                {
                    return;
                }


                // $ = alt + 36
                LblOut.Text += $"{playerTwo.Name} zaútoèil silou {tmp}{Environment.NewLine}";
                LblOut.Text += $"{playerOne}{Environment.NewLine}";

            }

            if(playerOne.Health >= playerTwo.Health)
            {
                MessageBox.Show($"Vyhrál: {playerOne.Name}");
            }
            else
            {
                MessageBox.Show($"Vyhrál: {playerTwo.Name}");
            }

            playerOne.RestoreHealth();
            playerTwo.RestoreHealth();

        }
    }
}