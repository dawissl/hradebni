namespace _11_Filtr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFiltr_Click(object sender, EventArgs e)
        {
            ListSensors.Items.Clear();
            using(StreamReader sr = new StreamReader("admin-iot.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineArr = line.Split(';');

                    if(( (lineArr[3] ==  TxtFarm.Text) || (TxtFarm.Text == ""))
                        &&
                        ((lineArr[4] == TxtType.Text) || (TxtType.Text == ""))
                        &&
                        ((lineArr[5] == TxtStatus.Text) || (TxtStatus.Text == ""))
                        &&
                        ((TxtNetwork.Text.Split(' ').Contains( lineArr[6])) || (TxtNetwork.Text == ""))
                        &&
                        (line.Contains(TxtFull.Text) || TxtFull.Text == "")
                        )
                    {
                        ListSensors.Items.Add(line);
                    }
                }
            }
        }
    }
}