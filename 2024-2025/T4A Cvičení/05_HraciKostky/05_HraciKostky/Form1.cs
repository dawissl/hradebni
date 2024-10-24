namespace _05_HraciKostky
{
    public partial class Form1 : Form
    {
        private List<Label> dices = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Dice d = new Dice((int)NumD.Value, lblColor.BackColor);
                CheckListDices.Items.Add(d);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            if (ColorDiag.ShowDialog() == DialogResult.OK)
            {
                lblColor.BackColor = ColorDiag.Color;
            }
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            //remove previous dices
            foreach (Label label in dices)
            {
                Controls.Remove(label);
            }
            const int OFFSET_X = 270;
            int OFFSET_Y = 30;
            const int SIZE = 25;
            const int SPACE = 10;
            dices = new List<Label>();
            if (CheckListDices.CheckedItems.Count == 0)
            {
                MessageBox.Show("Nebyly vybrané žádné kostky", "Info");
                return;
            }
            foreach (Dice d in CheckListDices.CheckedItems)
            {
                Label l = new Label();
                l.Location = new Point(OFFSET_X, OFFSET_Y);
                l.Text = $"{d.Roll()}";
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.BackColor = d.Clr;
                l.Width = SIZE;
                l.Height = SIZE;
                dices.Add(l);
                OFFSET_Y += SPACE + SIZE;
            }
            foreach (Label l in dices)
            {
                Controls.Add(l);
            }
        }
    }
}
