namespace Defense
{
    public partial class Form1 : Form
    {
        private int fireA;
        private int fireB;
        public Form1()
        {
            InitializeComponent();
            GenerateGame(GetDifficult());
        }

        private void GenerateGame(Difficult diffucult)
        {
            fireA = 5;
            fireB = 5;
            Random rnd = new Random();
            double[] initial = new double[5];
            for (int i = 0; i < 5; i++)
            {
                switch (diffucult)
                {
                    case Difficult.EASY:
                        initial[i] = rnd.Next(2, 6);
                        break;
                    case Difficult.MEDIUM:
                        initial[i] = rnd.Next(3, 7);
                        break;
                    case Difficult.HARD:
                        initial[i] = rnd.Next(4, 7);
                        break;
                }
            }
            L1.Text = $"{initial[0]}";
            L2.Text = $"{initial[1]}";
            L3.Text = $"{initial[2]}";
            L4.Text = $"{initial[3]}";
            L5.Text = $"{initial[4]}";
            LblAmmoB.Text = $"{fireB}";
            LabelAmmoA.Text = $"{fireA}";
            BtnFireA.Enabled = true;
            BtnFireB.Enabled = true;


        }

        private void Increase(Difficult diffucult)
        {
            Random rnd = new Random();
            double[] plus = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (GetActualArray()[i] <= 0) continue;
                switch (diffucult)
                {
                    case Difficult.EASY: plus[i] = 1; break;
                    case Difficult.MEDIUM: plus[i] = rnd.NextDouble(); break;
                    case Difficult.HARD: plus[i] = 1.5 * rnd.NextDouble(); break;
                }
            }
            if (double.Parse(L1.Text) <= 0)
                L1.Text = "0";
            else
                L1.Text = $"{Math.Round(double.Parse(L1.Text) + plus[0], 1)}";
            if (double.Parse(L2.Text) <= 0)
                L2.Text = "0";
            else
                L2.Text = $"{Math.Round(double.Parse(L2.Text) + plus[1], 1)}";
            if (double.Parse(L3.Text) <= 0)
                L3.Text = "0";
            else
                L3.Text = $"{Math.Round(double.Parse(L3.Text) + plus[2], 1)}";
            if (double.Parse(L4.Text) <= 0)
                L4.Text = "0";
            else
                L4.Text = $"{Math.Round(double.Parse(L4.Text) + plus[3], 1)}";
            if (double.Parse(L5.Text) <= 0)
                L5.Text = "0";
            else
                L5.Text = $"{Math.Round(double.Parse(L5.Text) + plus[4], 1)}";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pro vítìzství je tøeba eliminovat nepøátelské stroje, které se pøibližují" + Environment.NewLine
                + "Støela A míøí pøesnì na nejbližší cíl (èím vyšší èíslo, tím blíž)" + Environment.NewLine
                + "Støela B míøí také na nejbližší, ale svou sílu rozptýlí i na blízké stroje" + Environment.NewLine
                + "Pokud nìkterý ze strojù dosáhne základny (hodnota 10), hráè prohrál", "Obrana základny");
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateGame(GetDifficult());
        }

        private Difficult GetDifficult()
        {
            if (RadioMedium.Checked) return Difficult.MEDIUM;
            if (RadioHard.Checked) return Difficult.HARD;
            return Difficult.EASY;
        }


        private void BtnFireA_Click(object sender, EventArgs e)
        {

            double[] actual = GetActualArray();

            int indexOfShot = FindNearestTarget(actual);
            ShotA(indexOfShot);
            fireA--;
            LabelAmmoA.Text = $"{fireA}";
            if (fireA == 0) BtnFireA.Enabled = false;
            Increase(GetDifficult());
            CheckLose();
        }



        private void ShotA(int indexOfShot)
        {
            switch (indexOfShot)
            {
                case 0:
                    L1.Text = $"{double.Parse(L1.Text) - 5}";
                    break;
                case 1:
                    L2.Text = $"{double.Parse(L2.Text) - 5}";
                    break;
                case 2:
                    L3.Text = $"{double.Parse(L3.Text) - 5}";
                    break;
                case 3:
                    L4.Text = $"{double.Parse(L4.Text) - 5}";
                    break;
                case 4:
                    L5.Text = $"{double.Parse(L5.Text) - 5}";
                    break;
            }
        }

        private void ShotB(int indexOfShot)
        {
            switch (indexOfShot)
            {
                case 0:
                    L1.Text = $"{double.Parse(L1.Text) - 4}";
                    L2.Text = $"{double.Parse(L2.Text) - 1}";
                    break;
                case 1:
                    L2.Text = $"{double.Parse(L2.Text) - 4}";
                    L1.Text = $"{double.Parse(L1.Text) - 1}";
                    L3.Text = $"{double.Parse(L3.Text) - 1}";
                    break;
                case 2:
                    L3.Text = $"{double.Parse(L3.Text) - 4}";
                    L2.Text = $"{double.Parse(L2.Text) - 1}";
                    L4.Text = $"{double.Parse(L4.Text) - 1}";
                    break;
                case 3:
                    L4.Text = $"{double.Parse(L4.Text) - 4}";
                    L3.Text = $"{double.Parse(L3.Text) - 1}";
                    L5.Text = $"{double.Parse(L5.Text) - 1}";
                    break;
                case 4:
                    L5.Text = $"{double.Parse(L5.Text) - 4}";
                    L4.Text = $"{double.Parse(L5.Text) - 1}";
                    break;
            }
        }

        private void CheckLose()
        {
            double[] vs = GetActualArray();
            bool win = true;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] >= 10)
                {
                    MessageBox.Show("Lose");
                    return;
                }
                if (vs[i] > 0 && fireA == 0 && fireB == 0)
                {
                    MessageBox.Show("No ammo - lose");
                    return;
                }
                if (vs[i] > 0) win = false;
            }
            if (win)
            {
                MessageBox.Show("You win!");
            }
        }

        private int FindNearestTarget(double[] actual)
        {
            double max = actual[0];
            int index = 0;

            for (int i = 1; i < actual.Length; i++)
            {
                if (actual[i] > max)
                {
                    index = i;
                    max = actual[i];
                }
            }
            return index;
        }

        private double[] GetActualArray()
        {
            double[] ret = new double[5];
            ret[0] = double.Parse(L1.Text);
            ret[1] = double.Parse(L2.Text);
            ret[2] = double.Parse(L3.Text);
            ret[3] = double.Parse(L4.Text);
            ret[4] = double.Parse(L5.Text);
            return ret;
        }

        private void BtnFireB_Click(object sender, EventArgs e)
        {
            double[] actual = GetActualArray();

            int indexOfShot = FindNearestTarget(actual);
            ShotB(indexOfShot);
            fireB--;
            LblAmmoB.Text = $"{fireB}";
            if (fireB == 0) BtnFireB.Enabled = false;
            Increase(GetDifficult());
            CheckLose();
        }


    }

    public enum Difficult { EASY, MEDIUM, HARD }
}