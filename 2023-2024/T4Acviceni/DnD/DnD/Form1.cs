namespace DnD
{
    public partial class Form1 : Form
    {
        private List<Label> dices = new List<Label>();
        private List<ToolTip>  tips = new List<ToolTip>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            foreach (Label l in dices)
            {
                Controls.Remove(l);
            }
            dices.Clear();
            int offset = 160;
            int step = 25;
            foreach (Dice d in CheckedDicesList.CheckedItems)
            {
                Label l = new Label();
                l.Text = $"{d.Roll()}";
                l.BackColor = d.GetColor;
                l.Size = new Size(50, 20);
                l.Location = new Point(380, offset);

                offset += step;
                dices.Add(l);

               
            }
            foreach (Label l in dices)
            {
                Controls.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedDicesList.Items.Add(new Dice((int)NumSides.Value, TxtLabel.Text, LblColor.BackColor));
        }

        private void LblColor_Click(object sender, EventArgs e)
        {

            if (ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblColor.BackColor = ClrDialog.Color;
            }
        }

        private void CheckedDicesList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}