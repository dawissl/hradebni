using System.Collections.Generic;

namespace Artefacts
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ArtefactDialog dialog = new ArtefactDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Artefact art = new Artefact(dialog.Name, dialog.Value, dialog.Age);
                ListArtefacts.Items.Add(art);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ArtefactDialog dialog = new ArtefactDialog();
            Artefact edited;
            if (ListArtefacts.SelectedIndex != -1)
            {
                edited = (Artefact)ListArtefacts.Items[ListArtefacts.SelectedIndex];
                dialog.ArtifactName = edited.Name;
                dialog.Value = edited.Value;
                dialog.Age = edited.Age;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    edited.Name = dialog.Name;
                    edited.Value = dialog.Value;
                    edited.Age = dialog.Age;
                    ListArtefacts.Items[ListArtefacts.SelectedIndex] = edited;
                }
                ListArtefacts.Refresh();
            }
            else
            {
                MessageBox.Show("Vyberte artefakt k editaci");
            }
        }

        private void BtnSortName_Click(object sender, EventArgs e)
        {
            string vystup = "";
            List<Artefact> list = ListArtefacts.Items.Cast<Artefact>().ToList();
        
            list.Sort();
            foreach (Artefact a in list)
            {
                vystup += $"{a.ToString()}{Environment.NewLine}";
            }
            LblOut.Text = vystup;

        }

        private void BtnSortAge_Click(object sender, EventArgs e)
        {
            string vystup = "";
            List<Artefact> list = ListArtefacts.Items.Cast<Artefact>().ToList();
         
            list.Sort(new OrderByAge());
            foreach (Artefact a in list)
            {
                vystup += $"{a.ToString()}{Environment.NewLine}";
            }
                        LblOut.Text = vystup;

        }
    }
}
