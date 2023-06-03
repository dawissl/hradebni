namespace _20_Poznamky
{
    public partial class Form1 : Form
    {
        private Aplikace novaAppka = new Aplikace();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poznamka p1 = new Poznamka("nadpis 1");
            Poznamka p2 = new Poznamka("nadpis 2");
            Poznamka p3 = new Poznamka("nadpis 3", "ABC");
            Poznamka p4 = new Poznamka("nadpis 4", "DEF");

            novaAppka.PridatPoznamku(p1);
            novaAppka.PridatPoznamku(p2);
            novaAppka.PridatPoznamku(p3);
            novaAppka.PridatPoznamku(p4);

            string tmp = "";
            foreach(Poznamka p in novaAppka.SeznamPoznamek)
            {
                tmp += p + Environment.NewLine;
            }
            MessageBox.Show(tmp);
            /// odebrani polozky v seznamu poznamek
            novaAppka.OdeberPoznamku(p3);
            tmp = "";
            foreach (Poznamka p in novaAppka.SeznamPoznamek)
            {
                tmp += p + Environment.NewLine;
            }
            MessageBox.Show(tmp);
        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboType.Text == "POZNAMKA")
            {
                DateCalendar.Enabled = false;
                TxtList.Enabled = false;
            }

            if (ComboType.Text == "UKOL")
            {
                DateCalendar.Enabled = true;
                TxtList.Enabled = false;
            }

            if (ComboType.Text == "SEZNAM")
            {
                DateCalendar.Enabled = false;
                TxtList.Enabled = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Poznamka novaPoznamka = null;

            if (ComboType.Text == "POZNAMKA")
            {
                novaPoznamka = new Poznamka(TxtName.Text);
            }

            if (ComboType.Text == "UKOL")
            {
                novaPoznamka = new Ukol(TxtName.Text, Convert.ToDateTime(DateCalendar.Text));
            }

            if (ComboType.Text == "SEZNAM")
            {
                novaPoznamka = new Seznam(TxtName.Text);
            }


            if (novaPoznamka != null) novaAppka.PridatPoznamku(novaPoznamka);

            RefreshList();
    
        }

        private void RefreshList()
        {
            ListTasks.Items.Clear();
            foreach(Poznamka p in novaAppka.SeznamPoznamek)
            {
                ListTasks.Items.Add(p);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ComboType.Text = "POZNAMKA";
            TxtName.Text = "";
            TxtLabel.Text = "";
            TxtList.Text = "";
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if(ListTasks.SelectedIndex == -1)
            {
                // není nic vybráno
                MessageBox.Show("Není vybraný žádný z úkolù");
                return;
            }

            novaAppka.SeznamPoznamek[ListTasks.SelectedIndex].UpravStav = Stav.ZAVRENY;
            RefreshList();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ListTasks.SelectedIndex == -1)
            {
                // není nic vybráno
                MessageBox.Show("Není vybraný žádný z úkolù");
                return;
            }

            if (novaAppka.SeznamPoznamek[ListTasks.SelectedIndex].UpravStav == Stav.ZAVRENY)
            {
                novaAppka.SeznamPoznamek.RemoveAt(ListTasks.SelectedIndex);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Lze odstranit pouze uzavøené poznámky");
            }
           
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("poznamky.txt"))
            {
                sw.WriteLine("------ Seznam poznamek -----");
                foreach(Poznamka p  in novaAppka.SeznamPoznamek)
                {
                    sw.WriteLine(p.ToString());
                }
                sw.Close();
            }
        }
    }
}