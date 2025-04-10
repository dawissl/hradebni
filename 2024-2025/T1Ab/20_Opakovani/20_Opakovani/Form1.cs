namespace _20_Opakovani
{
    public partial class Form1 : Form
    {
        // deklarace a incializace polí a generátoru náhodných èísel
        string[] jmena = { "Kamil", "Jarmila", "Petr", "David", "Lucie", "Mirek", "Ondøej", "Martina" };
        string[] povolani = { "opraváø", "uèitel", "zedník", "instalatér", "právník", "voják" };
        Random rn = new Random();
        List<string> vypis = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            vypis.Clear();
            try
            {

                int pocet = int.Parse(TxtCount.Text);
                if (pocet < 0) throw new Exception("Vloženo záporné èíslo");
                string vystup = "";
                for (int i = 0; i < pocet; i++)
                {
                    // vložení jména a povolání do seznamu list
                    // bereme náhodnou položku v rozsahu pole
                    vypis.Add($"{i + 1} {jmena[rn.Next(jmena.Length)]} {povolani[rn.Next(povolani.Length)]}");
                    // získání položky na indexu a pøidání do výpisu
                    vystup += vypis[i] + Environment.NewLine; 
                }
                // pokud je checkbox zaškrtnutý pøevedeme vše na velká písmena
                if (CheckUpper.Checked) vystup = vystup.ToUpper();
                LblVystup.Text = vystup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
