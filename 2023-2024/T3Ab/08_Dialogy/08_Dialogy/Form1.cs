namespace _08_Dialogy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otevøítSouborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(FileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        drawings.Add(reader.ReadLine());
                    }
                    reader.Close();
                }
                PanelDrawings.Refresh();
            }
        }
        private List<string> drawings = new List<string>();
        private void PanelDrawings_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush myBrush = new SolidBrush(ColorDialog.Color);
            foreach (string s in drawings)
            {
                //obrazec;Px;Py;W;H
                string[] splited = s.Split(";");
                switch (splited[0])
                {
                    case "obdelnik":
                        g.FillRectangle(myBrush,
                            int.Parse(splited[1]),
                            int.Parse(splited[2]),
                            int.Parse(splited[3]),
                            int.Parse(splited[4]));
                        break;
                    case "elipsa":
                        g.FillEllipse(myBrush,
                            int.Parse(splited[1]),
                            int.Parse(splited[2]),
                            int.Parse(splited[3]),
                            int.Parse(splited[4]));
                        break;
                }

            }
        }

        private void zvolitBarvuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                StatusColor.BackColor = ColorDialog.Color;
                PanelDrawings.Refresh();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawings.Clear();
            ColorDialog.Color = Color.Black;
            StatusColor.BackColor = Color.Black;
            PanelDrawings.Refresh();
        }

        private int time = 0;
        private void TimerActive_Tick(object sender, EventArgs e)
        {
            time++;
            int minutes = time / 60;
            int seconds = time % 60;
            string outTime = "";
            outTime += (minutes < 10) ? $"0{minutes}" : $"{minutes}";
            outTime += (seconds < 10) ? $":0{seconds}" : $":{seconds}";

            StatusTime.Text = outTime;
        }
    }
}