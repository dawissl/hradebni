namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VytvorForm();
        }

        private void VytvorForm()
        {
            Form f = new Form();

            Label label = new Label();
            label.Text = "xxx";
            label.Location = new Point(10, 10);

            Button butt = new Button();
            butt.Text = "save";
            butt.Location = new Point(10, 50);
            butt.Click += new EventHandler(button_Click);

            f.Controls.Add(label);
            f.Controls.Add(butt);

            f.ShowDialog();
        }

        private void button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Výsledne skore");
        }
    }
}