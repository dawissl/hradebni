namespace _05_MortalKombat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Bob�k
            ComboPlayerOne.Items.Add(new Fighter("Bob�k",7,10,6));
            ComboPlayerTwo.Items.Add(new Fighter("Bob�k", 7, 10, 6));
            // Mi�pul�n
            ComboPlayerOne.Items.Add(new Fighter("Mi�pul�n", 5, 11, 7));
            ComboPlayerTwo.Items.Add(new Fighter("Mi�pul�n", 5, 11, 7));
            // Pin�a
            ComboPlayerOne.Items.Add(new Fighter("Pin�a", 8, 13, 4));
            ComboPlayerTwo.Items.Add(new Fighter("Pin�a", 8, 13, 4));

        }

        private void ButtonFight_Click(object sender, EventArgs e)
        {
            // | = alt + 124
            if(ComboPlayerOne.SelectedIndex == -1 || ComboPlayerTwo.SelectedIndex == -1)
            {
                MessageBox.Show("Zvolte hr��e");
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
                LblOut.Text += $"{playerOne.Name} za�to�il silou {tmp}{Environment.NewLine}";
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
                LblOut.Text += $"{playerTwo.Name} za�to�il silou {tmp}{Environment.NewLine}";
                LblOut.Text += $"{playerOne}{Environment.NewLine}";

            }

            if(playerOne.Health >= playerTwo.Health)
            {
                MessageBox.Show($"Vyhr�l: {playerOne.Name}");
            }
            else
            {
                MessageBox.Show($"Vyhr�l: {playerTwo.Name}");
            }

            playerOne.RestoreHealth();
            playerTwo.RestoreHealth();

        }
    }
}