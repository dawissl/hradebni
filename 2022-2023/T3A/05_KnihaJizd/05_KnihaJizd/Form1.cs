using System.IO;
namespace _05_KnihaJizd
{
    public partial class Form1 : Form
    {
        private List<Jizda> seznamJizd;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReadFile_Click_1(object sender, EventArgs e)
        {
            seznamJizd = new List<Jizda>();
            if (TxtFileName.Text == "")
            {
                MessageBox.Show("Zadejte název souboru");
                return;
            }
            LblOut.Text = "";
            using (StreamReader sr = new StreamReader(TxtFileName.Text))
            {
                while (!sr.EndOfStream)
                {
                    Jizda tmp = GetJizda(sr.ReadLine());
                    if(tmp != null)  seznamJizd.Add(tmp);
                }

            }

            foreach(Jizda jizda in seznamJizd)
            {
                LblOut.Text += jizda + Environment.NewLine;
            }
        }

        private Jizda GetJizda(string? v)
        {

            throw new NotImplementedException();
        }
    }
}