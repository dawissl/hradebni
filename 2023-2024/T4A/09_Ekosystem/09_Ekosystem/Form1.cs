namespace _09_Ekosystem
{
    public partial class Form1 : Form
    {
        private const double PORODNOST_OVCE = 0.008;
        private const double PORODNOST_VLK = 0.018;
        private const int VODA_OVCE = 5;
        private const int VODA_VLK = 2;
        private const int JIDLO_OVCE = 2;
        private const double JIDLO_VLK = 0.2;
        private int water, area;
        private double sheeps, wolves;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSimulate_Click(object sender, EventArgs e)
        {
            // get entry values from user
            sheeps = (double)NumSheep.Value;
            wolves = (double)NumWolf.Value;
            area = (int)NumArea.Value;
            water = (int)NumRiver.Value;
            // delete result of previous atempt
            TxtSimulation.Text = "";

            for (int day = 1; day <= 365; day++)
            {
                //bread of animal
                sheeps *= (1 + PORODNOST_OVCE);
                wolves *= (1 + PORODNOST_VLK);
                //consumption of water
                int waterConsumption = (int)sheeps * VODA_OVCE + (int)wolves * VODA_VLK;
                if (waterConsumption > water)
                {
                    TxtSimulation.Text += $"Den[{day}] - ekosystém zahuben. Nedostatek vody";
                    break;
                }
                //consumption of grass
                int grassConsumption = (int)sheeps * JIDLO_OVCE;
                if (grassConsumption > area)
                {
                    TxtSimulation.Text += $"Den[{day}] - ekosystém zahuben. Nedostatek louky";
                    break;
                }
                //consumption of sheeps - rounded up
                double sheepConsumption = (int)wolves * JIDLO_VLK;
                if ((sheepConsumption * 10) % 10 > 0)
                    sheepConsumption += 1;

                if ((int)sheepConsumption > sheeps)
                {
                    TxtSimulation.Text += $"Den[{day}] - ekosystém zahuben. Došly ovce";
                    break;
                }
                //check count of sheeps
                sheeps -= (int)sheepConsumption;

                //kill wolves after 30 days
                if (day % 30 == 0)
                    wolves--;

                TxtSimulation.Text += StatusOfEcosystem(day) + Environment.NewLine;

            }

        }

        private string StatusOfEcosystem(int day)
        {
            return $"Day {day} - ovce [{(int)sheeps}], vlci [{(int)wolves}] ";
        }
    }
}