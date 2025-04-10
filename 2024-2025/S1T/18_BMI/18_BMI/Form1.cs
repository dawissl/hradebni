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
                // na�ten� hodnot z TextBox�
                double vyska, vaha;
                vyska = double.Parse(TxtVyska.Text);
                vaha = double.Parse(TxtVaha.Text);
                // | = ale + 124
                if (vyska < 50 || vaha < 10)
                {
                    throw new Exception("V�ha nebo v��ka nem� min hodnotu.");
                }
                // z�sk�n� v�sledn� hodnoty BMI
                double bmi = VypocetBMI(vyska, vaha);
                LblResult.Text = $"{bmi}";
                // z�sk�n� podrobn� informace dle v�sledku
                LblInfo.Text = BmiInfo(bmi);
            }
            //odchycen� vyj�mek
            catch (FormatException ex)
            {
                LblInfo.Text = "Zad�vejte pouze ��sla";
            }
            catch (Exception ex) { 
                LblInfo.Text = ex.Message;
            }

        }

        private string BmiInfo(double bmi)
        {
            if (bmi < 18.5) return "Podv�ha";
            if (bmi < 24.9) return "Norm�ln�";
            if (bmi < 29.9) return "Nadv�ha";
            if (bmi < 34.9) return "Obezita 1. stupn�";
            if (bmi < 39.9) return "Obezita 2. stupn�";
            return "Obezita 3. stupn�";
        }

        private double VypocetBMI(double vyska, double vaha)
        {
            // z�sk�n� hodnoty v metrech
            double vyskaM = vyska / 100;
            // v�po�et dle vzorce
            double bmi = vaha / (vyskaM * vyskaM);
            //vr�cen� zaokrouhlen� hodnoty na dv� desetinn� m�sta
            return Math.Round(bmi,2) ;
        }
    }
}
