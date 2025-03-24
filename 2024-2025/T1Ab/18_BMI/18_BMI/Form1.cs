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
            // vymaz�n� vstupn�ch textbox�
            LblInfo.Text = string.Empty;
            LblResult.Text = string.Empty;
            try
            {
                // na�ten� hodnot od u�ivatele a vyparsov�n� hodnoty z textu
                int vyska = int.Parse(TxtVyska.Text);
                int vaha = int.Parse(TxtVaha.Text);
                // pokud v��ka s v�hou jsou pod minim�ln� hodnotou
                // nedojdeme k v�po�tu
                if (vaha <= 10 || vyska <= 50)
                {
                    LblResult.Text = "Neplatn� vstupn� hodnoty";
                    return;
                }
                // vol�n� funkce pro v�po�et dle zadan�ch hodnot
                double vysledek = BmiVypocet(vyska, vaha);
                LblResult.Text = $"{vysledek}";
                LblInfo.Text = $"{bmiInfo(vysledek)}";
            }
            catch (FormatException ex)
            {
                LblInfo.Text = "Neplatn� form�t hodnot";

            }
        }

        // v�po�et BMI
        // pokud pracujeme s celo��selnou hodnout je t�eba uv�st form�t 1.0,
        // aby kompil�tor v�d�l, �e pracuje s desetinn�m ��slem
        // Math.Round zaoukrouhluje v�sledek na zvolen� po�et desetinn�ch m�st
        private double BmiVypocet(int vyska, int vaha)
        {
            // p�eveden� z centimetr� na metry
            double v = vyska / 100.0;
            return Math.Round((double)vaha / (v * v), 1);

        }
        // na z�klad� vstupn� hodnoty vr�t� p��slu�n� info text
        private string bmiInfo(double value)
        {
            if (value < 18.5) return "podv�ha";
            if (value < 24.9) return "norm�ln� v�ha";
            if (value < 29.9) return "nadv�ha";
            if (value < 34.9) return "obezita 1. stupn�";
            if (value < 39.9) return "obezita 2. stupn�";
            return "obezita 3. stupn�";
        }
    }
}
