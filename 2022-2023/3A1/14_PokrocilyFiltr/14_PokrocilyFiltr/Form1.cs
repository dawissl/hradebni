namespace _14_PokrocilyFiltr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListSensors.Items.Clear();
            using (StreamReader sr = new StreamReader("senzory-iot.csv"))
            {
                sr.ReadLine();
                sr.ReadLine();
                
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // 3,4,5,6
                    //x;x;x;x;x;x;x;x;x
                    string[] data = line.Split(';');
                    //[x,x,x,x,x,x,x,x,x]
                    // | = alt + 124
                    if ((TxtFarm.Text == "" || TxtFarm.Text.Split('_').Contains(data[3]))
                        &&
                        (TxtType.Text == "" || TxtType.Text.Split('_').Contains(data[4]))
                        &&
                        (TxtStatus.Text == "" || TxtStatus.Text.Split('_').Contains(data[5]))
                        &&
                        (TxtNetwork.Text == "" || TxtNetwork.Text.Split('_').Contains(data[6]))
                        &&
                        (TxtFull.Text == "" || data.Contains(TxtFull.Text)))
                    {
                        ListSensors.Items.Add(line);
                    }
                }
               
                sr.Close();


            }
        }
    }
}