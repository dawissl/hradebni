namespace _18_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnBMI_Click(object sender, EventArgs e)
        {          
            try
            {
                // naètení hodnot z TextBoxù
                double vyska, vaha;
                vyska = double.Parse(TxtVyska.Text);
                vaha = double.Parse(TxtVaha.Text);
                // | = ale + 124
                if (vyska < 50 || vaha < 10)
                {
                    throw new Exception("Váha nebo výška nemá min hodnotu.");
                }
                // získání výsledné hodnoty BMI
                double bmi = VypocetBMI(vyska, vaha);
                LblResult.Text = $"{bmi}";
                // získání podrobné informace dle výsledku
                LblInfo.Text = BmiInfo(bmi);
            }
            //odchycení vyjímek
            catch (FormatException ex)
            {
                LblInfo.Text = "Zadávejte pouze èísla";
            }
            catch (Exception ex) { 
                LblInfo.Text = ex.Message;
            }

        }

        private string BmiInfo(double bmi)
        {
            if (bmi < 18.5) return "Podváha";
            if (bmi < 24.9) return "Normální";
            if (bmi < 29.9) return "Nadváha";
            if (bmi < 34.9) return "Obezita 1. stupnì";
            if (bmi < 39.9) return "Obezita 2. stupnì";
            return "Obezita 3. stupnì";
        }

        private double VypocetBMI(double vyska, double vaha)
        {
            // získání hodnoty v metrech
            double vyskaM = vyska / 100;
            // výpoèet dle vzorce
            double bmi = vaha / (vyskaM * vyskaM);
            //vrácení zaokrouhlené hodnoty na dvì desetinná místa
            return Math.Round(bmi,2) ;
        }
    }
}
