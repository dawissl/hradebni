namespace Sklenik
{
    public partial class Form1 : Form
    {
        private double moisture = 0;
        private double leafWettness = 0;
        private double dayLight = 0;
        private bool openRolls = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void TrackTemperature_Scroll(object sender, EventArgs e)
        {
            LblTemp.Text = $"{TrackTemperature.Value} °C";
        }

        private void TrackLight_Scroll(object sender, EventArgs e)
        {
            LblLight.Text = $"{TrackLight.Value} lx";
        }

        private void TrackTime_Scroll(object sender, EventArgs e)
        {
            if (TrackTime.Value < 10)
                LblTime.Text = $"0{TrackTime.Value}:00 h";
            else
                LblTime.Text = $"{TrackTime.Value}:00 h";

            dayLight = GetDayLight();
        }

        private double GetDayLight()
        {
            if (TrackTime.Value == 6) return 100;
            if (TrackTime.Value == 7) return 200;
            if (TrackTime.Value == 8) return 500;
            if (TrackTime.Value == 9) return 2000;
            if (TrackTime.Value == 10) return 5000;
            if (TrackTime.Value == 11) return 10000;
            if (TrackTime.Value == 12) return 15000;
            if (TrackTime.Value == 13) return 15500;
            if (TrackTime.Value == 14) return 10000;
            if (TrackTime.Value == 15) return 5000;
            if (TrackTime.Value == 16) return 2000;
            if (TrackTime.Value == 17) return 500;
            if (TrackTime.Value == 18) return 200;
            if (TrackTime.Value == 19) return 100;
            if (TrackTime.Value == 20) return 50;
            return 0;
        }

        private void BtnAddMoist_Click(object sender, EventArgs e)
        {
            moisture += 27 * GetOreCoefficient();
            if (moisture > 100) moisture = 100;
            LblMoisture.Text = $"{Math.Round(moisture, 1)} %";
        }

        public double GetOreCoefficient()
        {
            switch (ComboOre.Text)
            {
                case "RAŠELINA":
                    return 0.8;
                case "RAŠELINNÍ SMÌS":
                    return 0.7;
                case "UNVERZÁLNÍ":
                    return 0.6;
                case "JÍLOVITÁ":
                    return 0.5;
                case "PÍSÈITÁ":
                    return 0.4;
                default:
                    return 1;
            }
        }

        private void BtnRemoveMoist_Click(object sender, EventArgs e)
        {
            moisture -= 5 * GetOreCoefficient();
            if (moisture < 0) moisture = 0;
            LblMoisture.Text = $"{moisture} %";

        }

        private double CountLeafWettness()
        {
            return (2 / Math.PI) * GetOreCoefficient() * moisture
                + TrackTemperature.Value *
                ((dayLight + TrackLight.Value) / 1200);
        }

        private void BtnRecountLeafWettness_Click(object sender, EventArgs e)
        {
            leafWettness = Math.Round(CountLeafWettness(), 0);
            LblLeafWettness.Text = $"{leafWettness} %";
        }

        private void BtnRollet_Click(object sender, EventArgs e)
        {
            if (openRolls)
            {
                openRolls = !openRolls;
                BtnRollet.Text = "Otevøít rolety";
                dayLight = 0;
            }
            else
            {
                openRolls = !openRolls;
                BtnRollet.Text = "Zavøít rolety";
                dayLight = GetDayLight();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           // LblStatus.Text = status ;
        }
    }
}