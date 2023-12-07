namespace _08_Dialogy
{
    public partial class Form1 : Form
    {
        private List<string> drawings = new List<string>();
        private int time = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // ziskani barvy stetce z ColorDialogu
            SolidBrush stetec = new SolidBrush(ColorD.Color);
            foreach (string s in drawings)
            {
                string[] draw = s.Split(";");
                //obrazec;Px;Py;šíøka;výška
                switch (draw[0])
                {
                    case "elipsa":
                        g.FillEllipse(stetec,
                            int.Parse(draw[1]),
                            int.Parse(draw[2]),
                            int.Parse(draw[3]),
                            int.Parse(draw[4]));
                        break;
                    case "obdelnik":
                        g.FillRectangle(stetec,
                            int.Parse(draw[1]),
                            int.Parse(draw[2]),
                            int.Parse(draw[3]),
                            int.Parse(draw[4]));
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuOpenFile_Click(object sender, EventArgs e)
        {
            if (FileD.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(FileD.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        drawings.Add(reader.ReadLine());
                    }
                    reader.Close();
                }
                panel1.Refresh();
            }
        }

        private void MenuPickColour_Click(object sender, EventArgs e)
        {
            if (ColorD.ShowDialog() == DialogResult.OK)
            {
                ColorCustom.BackColor = ColorD.Color;
                panel1.Refresh();
            }
        }

        private void MenuReset_Click(object sender, EventArgs e)
        {
            drawings.Clear();
            ColorD.Color = Color.Black;
            panel1.Refresh();

        }

        private void ovládáníToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O programu", "Program slouží pro demonstraci vužití uživatelského menu a dialogových oken.");
        }

        private void TimerRun_Tick(object sender, EventArgs e)
        {
            time++;
            int minutes = time / 60;
            int seconds = time % 60;
            string outTime = "";
            outTime += (minutes < 10) ? $"0{minutes}" : $"{minutes}";

           /* vyuziti if else pro stejnou funkcionalitu namisto ternarniho operatoru
            * if (minutes < 10)
            {
                outTime += $"0{minutes}";
            }
            else
            {
                outTime += $"{minutes}";
            }*/

            outTime += (seconds < 10) ? $":0{seconds}" : $":{seconds}";

            StatusTime.Text = outTime;
        }
    }
}