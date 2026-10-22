namespace _21_NpcManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDialog_Click(object sender, EventArgs e)
        {
            NpcDialog dialog = new NpcDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                NpcList.Items.Add(dialog.Character);
            }
        }

        private void NpcList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpcCharacter? character = NpcList.SelectedItem as NpcCharacter;
            if (character != null)
            {
                LblInfo.Text = character.Friendly.ToString();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (NpcList.SelectedIndex == -1)
            {
                MessageBox.Show("Není vybraná položka k editaci");
                return;
            }

            NpcCharacter edited = NpcList.SelectedItem as NpcCharacter;
            NpcDialog dialog = new NpcDialog(edited);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                NpcList.Items[NpcList.SelectedIndex] = dialog.Character;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (NpcList.SelectedIndex == -1)
            {
                MessageBox.Show("Není vybraná položka k editaci");
                return;
            }
            NpcList.Items.RemoveAt(NpcList.SelectedIndex);
        }
    }
}
