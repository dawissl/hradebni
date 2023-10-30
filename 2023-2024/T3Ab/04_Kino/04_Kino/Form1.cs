using System.Net.Http.Headers;

namespace _04_Kino
{
    public partial class Form1 : Form
    {
        private Seat[,] seats;
        private Screen screen;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerete_Click(object sender, EventArgs e)
        {
            /// TODO
            /// 1) inicializace velikosti dvourozmìrného pole dle NumericUpDown.Value
            /// 2) Naplnit pole sedadly - mezi sedadly je mezera
            /// 3) vložit sedadla na formuláø
            /// 4) odstraòování sedadel pøi pøegenerování sálu
            /// B1) vložit plátno pøed sedadla o šíøce sálu
            /// B2) sedadla mají štítetk s oznaèením  
            /// 

            //4) 
            Clear();
            //1)
            int sizeX = Convert.ToInt32(NumSizeX.Value);
            int sizeY = Convert.ToInt32(NumSizeY.Value);
            seats = new Seat[sizeX, sizeY];
            
            //2+3)
            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    // zakladni pozice je [20,150]
                    Seat s = new Seat(20 + 40 * x, 100 + 40 * y);
                    //B2)
                    s.Text = $"{Char.ToString((char)('A'+y))}{x+1}";
                    seats[x, y] = s;
                    Controls.Add(s);
                }
            }

            //B1)
            screen = new Screen(sizeX);
            Controls.Add(screen);
        }

        /// <summary>
        /// Remove seats and screen
        /// </summary>
        private void Clear()
        {
           if(seats != null)
            {
                Controls.Remove(screen);
                foreach(Seat s in seats)
                {
                    Controls.Remove(s);
                }

            }
        }
    }
}