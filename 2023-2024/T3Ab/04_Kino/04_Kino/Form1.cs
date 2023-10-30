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
            /// 1) inicializace velikosti dvourozm�rn�ho pole dle NumericUpDown.Value
            /// 2) Naplnit pole sedadly - mezi sedadly je mezera
            /// 3) vlo�it sedadla na formul��
            /// 4) odstra�ov�n� sedadel p�i p�egenerov�n� s�lu
            /// B1) vlo�it pl�tno p�ed sedadla o ���ce s�lu
            /// B2) sedadla maj� �t�tetk s ozna�en�m  
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