namespace _11_Teraformace
{
    public partial class Form1 : Form
    {
        private Planet exoTerra = new Planet(5);
        private int year = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Area a in exoTerra.Land)
            {
                this.Controls.Add(a);
            }
            axeX.Maximum = 4;
            axeY.Maximum = 4;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            year++;
            LblYear.Text = year.ToString();
            exoTerra.NextYearUpdate();
            if (exoTerra.isTerraType())
            {
                LblStatus.BackColor = Color.LightGreen;
            }
            LblStatus.Text = exoTerra.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int x = (int) axeX.Value;
            int y = (int) axeY.Value;
            switch (ComboUnit.Text)
            {
                case "WATER":
                    exoTerra.Land[x, y].Unit = new FactoryUnit("WATER");
                    break;
                case "OXYGEN":
                    exoTerra.Land[x, y].Unit = new FactoryUnit("OXYGEN");
                    break;
                case "TEMP":
                    exoTerra.Land[x, y].Unit = new FactoryUnit("TEMPERATURE");

                    break;
            }

        }
    }
}
