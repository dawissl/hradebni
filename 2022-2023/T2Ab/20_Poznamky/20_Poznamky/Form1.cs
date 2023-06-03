namespace _20_Poznamky
{
    public partial class Form1 : Form
    {
        Aplikace app = new Aplikace();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Poznamka p = null;

            if (CheckBoxDate.Checked)
            {
                // konstruktor s datumem
                p = new Poznamka(TxtName.Text,
                                 TxtText.Text,
                                 dateTimePicker1.Value,
                                 TxtLabel.Text);
            }
            else
            {
                // konstruktor bez datumu
                p = new Poznamka(TxtName.Text,
                                 TxtText.Text,
                                 TxtLabel.Text);
            }


            if (p != null) app.PridaniPoznamky(p);

            SyncListBox();
        }

        private void SyncListBox()
        {
            listTasks.Items.Clear();
            foreach (Poznamka p in app.Seznampoznamek)
            {
                listTasks.Items.Add(p);
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex != -1)
            {
                app.Seznampoznamek[listTasks.SelectedIndex].StavUkolu = Stav.SPLNENO;
                SyncListBox();
            }
            else
            {
                MessageBox.Show("Nebyla vybrána žádná položka");
            }

        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex != -1)
            {
                app.Seznampoznamek[listTasks.SelectedIndex].StavUkolu = Stav.ARCHIVOVANO;
                SyncListBox();
            }
            else
            {
                MessageBox.Show("Nebyla vybrána žádná položka");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Je nutné vyvbrat položku");
                return;
            }

            if (app.Seznampoznamek[listTasks.SelectedIndex].StavUkolu == Stav.SPLNENO)
            {
                app.Seznampoznamek.RemoveAt(listTasks.SelectedIndex);
                SyncListBox();
            }
            else
            { 
                MessageBox.Show("Odstranit lze pouze splnìnou položku"); 
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            /// TODO vypsat uložene poznamky do souboru
            
            using(StreamWriter sw = new StreamWriter("ukolnik.txt"))
            {
                sw.WriteLine("-------- Poznamky --------");
                foreach(Poznamka p in app.Seznampoznamek)
                {
                    sw.WriteLine(p.ToString());
                    sw.WriteLine("############################################");
                }
                sw.Close();
            }
        }
    }
}