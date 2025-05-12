namespace _20_Opakovani
{
    public partial class Form1 : Form
    {
        // deklarace a incializace pol� a gener�toru n�hodn�ch ��sel
        string[] jmena = { "Kamil", "Jarmila", "Petr", "David", "Lucie", "Mirek", "Ond�ej", "Martina" };
        string[] povolani = { "oprav��", "u�itel", "zedn�k", "instalat�r", "pr�vn�k", "voj�k" };
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
                if (pocet < 0) throw new Exception("Vlo�eno z�porn� ��slo");
                string vystup = "";
                for (int i = 0; i < pocet; i++)
                {
                    // vlo�en� jm�na a povol�n� do seznamu list
                    // bereme n�hodnou polo�ku v rozsahu pole
                    vypis.Add($"{i + 1} {jmena[rn.Next(jmena.Length)]} {povolani[rn.Next(povolani.Length)]}");
                    // z�sk�n� polo�ky na indexu a p�id�n� do v�pisu
                    vystup += vypis[i] + Environment.NewLine; 
                }
                // pokud je checkbox za�krtnut� p�evedeme v�e na velk� p�smena
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
