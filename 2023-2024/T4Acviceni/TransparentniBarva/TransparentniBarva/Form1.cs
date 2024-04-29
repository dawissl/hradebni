namespace TransparentniBarva
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(0);
            list.Add(10);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(20);
            list.Add(30);
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(10);
            aggreate2();
            aggreate4();
            Refresh();
        }

        private void aggreate2()
        {
            for(int i = 0; i < list.Count; i += 2)
            {
                list2.Add((list[i] + list[i+1])/2);
            }
        }

        private void aggreate4()
        {
            for (int i = 0; i < list.Count; i += 4)
            {
                list3.Add((list[i] + list[i + 1]+ list[i+2] + list[i + 3]) / 4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="y"></param>
        private void myFunction(int v, int y)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int size = 20;
            int count = 0;
            SolidBrush sol = new SolidBrush(Color.FromArgb(30, 255, 0, 0));
            for (int i = 0; i < list.Count; i++)
            {
                count += list[i];
                g.FillRectangle(sol, 20 * i, 10, 10, count * size);
            }
            if (list.Count <= 0) return;
            int x = 10;
            List<Point> points1= new List<Point>();
            foreach(int i in list)
            {
               Point p = new Point(x, i*10);
                x += 10;
                points1.Add(p);
            }

            x = 10;
            List<Point> points2 = new List<Point>();
            foreach (int i in list2)
            {
                Point p = new Point(x, i*10);
                x += 20;
                points2.Add(p);
            }
            x = 10;
            List<Point> points3 = new List<Point>();
            foreach (int i in list3)
            {
                Point p = new Point(x, i*10);
                x += 40;
                points3.Add(p);
            }
            g.DrawLines(Pens.Green, points1.ToArray());
            g.DrawLines(Pens.Blue, points2.ToArray());
            g.DrawLines(Pens.Red, points3.ToArray());

        }
    }

    public class MyClass
    {
        private int x;
    }
}