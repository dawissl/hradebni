namespace _18_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBMI_Click(object sender, EventArgs e)
        {
            // vymazání vstupních textboxù
            LblInfo.Text = string.Empty;
            LblResult.Text = string.Empty;
            try
            {
                // naètení hodnot od uživatele a vyparsování hodnoty z textu
                int vyska = int.Parse(TxtVyska.Text);
                int vaha = int.Parse(TxtVaha.Text);
                // pokud výška s váhou jsou pod minimální hodnotou
                // nedojdeme k výpoètu
                if (vaha <= 10 || vyska <= 50)
                {
                    LblResult.Text = "Neplatné vstupní hodnoty";
                    return;
                }
                // volání funkce pro výpoèet dle zadaných hodnot
                double vysledek = BmiVypocet(vyska, vaha);
                LblResult.Text = $"{vysledek}";
                LblInfo.Text = $"{bmiInfo(vysledek)}";
            }
            catch (FormatException ex)
            {
                LblInfo.Text = "Neplatný formát hodnot";

            }
        }

        // výpoèet BMI
        // pokud pracujeme s celoèíselnou hodnout je tøeba uvést formát 1.0,
        // aby kompilátor vìdìl, že pracuje s desetinným èíslem
        // Math.Round zaoukrouhluje výsledek na zvolený poèet desetinných míst
        private double BmiVypocet(int vyska, int vaha)
        {
            // pøevedení z centimetrù na metry
            double v = vyska / 100.0;
            return Math.Round((double)vaha / (v * v), 1);

        }
        // na základì vstupní hodnoty vrátí pøíslušný info text
        private string bmiInfo(double value)
        {
            if (value < 18.5) return "podváha";
            if (value < 24.9) return "normální váha";
            if (value < 29.9) return "nadváha";
            if (value < 34.9) return "obezita 1. stupnì";
            if (value < 39.9) return "obezita 2. stupnì";
            return "obezita 3. stupnì";
        }
    }
}
