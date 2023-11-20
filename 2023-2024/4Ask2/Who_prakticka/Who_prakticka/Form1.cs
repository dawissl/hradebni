using System.Reflection;

namespace Who_prakticka
{
    public partial class Form1 : Form
    {
        private List<Pricina> seznamPrincin = new List<Pricina>();
        private int deti, dospeli, duchodci;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aktualizace vekovych katergorii pacientù na základì vìku nového pacienta
        /// </summary>
        /// <param name="vek">vek pacienta</param>
        public void PriradPacientaDoKategorie(int vek)
        {
            if (vek < 18) deti++;
            if (vek >= 18 && vek < 65) dospeli++;
            if (vek >= 65) duchodci++;
        }

        /// <summary>
        /// Aktualizace seznamu, pøidá nové onemocnìní, pokud ještì není v seznamu
        /// </summary>
        /// <param name="onemonceni">název onemocnìní</param>
        public void AktualizaceSeznamuPricin(string onemonceni)
        {
            bool noveOnemocneni = true;
            foreach (Pricina p in seznamPrincin)
            {
                //pokud je již v seznamu dane onemocnìni akutalizujeme poèet pacientù
                if (onemonceni.ToUpper() == p.Onemocneni)
                {
                    noveOnemocneni = false;
                    p.PocetVyskytu = 1;
                    break;
                }
            }
            // pokud nedošlo k atualizaci nìkteré z pøièin je tøeba pøièinu vložit jako novou
            if (noveOnemocneni)
            {
                seznamPrincin.Add(new Pricina(onemonceni));
            }
        }

        /// <summary>
        /// Pozice pøièiny s nejèastìjším vyskytem
        /// </summary>
        /// <returns>index v listu s nejèastìjším vyskytem</returns>
        public int IndexNejcastejsiPriciny()
        {
            int index = 0;
            int max = seznamPrincin[index].PocetVyskytu;

            for (int i = 1; i < seznamPrincin.Count; i++)
            {
                if (seznamPrincin[i].PocetVyskytu > max)
                {
                    max = seznamPrincin[i].PocetVyskytu;
                    index = i;
                }
            }
            return index;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PriradPacientaDoKategorie((int)NumVek.Value);
            AktualizaceSeznamuPricin(TxtPricina.Text);
            TxtVystup.Text = VypisInfo(true, true);
        }

        /// <summary>
        /// Ziskani formatovaneho retezce s informacemi o onemocneni a vekových kategorii
        /// 
        /// </summary>
        /// <param name="nemoc">do vypisu je zahrnuta informace o nemocich</param>
        /// <param name="vek">do vypisu je zahrnuta infomrace o vekovych kategoriich</param>
        /// <returns>formatovany vypis</returns>
        private string VypisInfo(bool nemoc, bool vek)
        {
            string vystup = "";
            if (nemoc)
            {
                vystup += $"{seznamPrincin[IndexNejcastejsiPriciny()].Onemocneni}" +
                $" {(double)seznamPrincin[IndexNejcastejsiPriciny()].PocetVyskytu * 100 / PocetPacientu()}" +
                $"%{Environment.NewLine}";
            }
            if (vek)
            {
                int sumaPacientu = deti + dospeli + duchodci;
                vystup += $"Dìti: {(double)deti * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"Dospìlí: {(double)dospeli * 100 / sumaPacientu} %{Environment.NewLine}";
                vystup += $"Dùchodci: {(double)duchodci * 100 / sumaPacientu} %{Environment.NewLine}";

            }
            return vystup;
        }

        /// <summary>
        /// Ziskani poctu pacientu v datovém souboru
        /// </summary>
        /// <returns>poèet pacientù</returns>
        public int PocetPacientu()
        {
            int suma = 0;
            foreach (Pricina p in seznamPrincin)
            {
                suma += p.PocetVyskytu;
            }
            return suma;
        }

        
        private void BtnFile_Click(object sender, EventArgs e)
        {
            // vypsani do souboru nemoci.txt
            using (StreamWriter writer = new StreamWriter("nemoci.txt"))
            {
                writer.WriteLine(VypisInfo(CheckPriciny.Checked, CheckVeky.Checked));
                writer.Close();
            }
        }
    }
}