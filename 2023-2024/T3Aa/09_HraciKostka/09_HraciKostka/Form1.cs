namespace _09_HraciKostka
{
    public partial class Form1 : Form
    {
        List<Dice> dices = new List<Dice>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Dice newDice = new Dice((int)NumSides.Value,
                                    TxtLabel.Text,
                                    LblClr.BackColor);
            dices.Add(newDice);
            BtnRoll.Text = $"Hod kostkami ({dices.Count})";
        }

        private void LblClr_Click(object sender, EventArgs e)
        {
            if (ClrDialog.ShowDialog() == DialogResult.OK)
            {
                LblClr.BackColor = ClrDialog.Color;
            }
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            //first dice 400;17
            int diceCounter = 0;
            foreach(Dice d in dices)
            {
                Label l = new Label();
                l.Location = new Point(400, 20 + 30 * diceCounter);
                diceCounter++;
                l.Width = 20;
                l.Height = 20;
                l.Text = $"{d.Roll()}";
                l.BackColor = d.GetColor;
                Controls.Add(l);               
            }
        }
    }
}