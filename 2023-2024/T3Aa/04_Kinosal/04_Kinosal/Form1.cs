using System.Data;

namespace _04_Kinosal
{
    public partial class Form1 : Form
    {
        private Sedadlo[,] sal;
        private Label platno;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            /// TODO 
            /// 1) inicializace salu podle hodnoty z NumericUpDown
            /// 2) naplnìní dvourozmìrného pole sedadly
            /// 3) sedadla jsou rozmístìna v sále a jsou mezi nimi mezery
            /// B1) pøidat pøed sedadla plátno Label
            /// B2) pøidat sedadlùm èíslování viditelná pro uživatele
            /// 
            Clear();
            //1)
            int size = Convert.ToInt32(NumSize.Value);
            if (size <= 0)
            {
                MessageBox.Show("Nelze mít sál bez sedaèek");
                return;
            }
            sal = new Sedadlo[size, size];
            //2)

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Sedadlo s = new Sedadlo();
                    s.Location = new Point(20 + (s.Width + 10) * x, 150 + (s.Height + 10) * y);
                    s.Name = $"sedadlo_{x + 1}_{y + 1}";
                    s.Text = $"{Char.ToString((char)('A' + y))} {x + 1}";
                    s.TextAlign = ContentAlignment.MiddleCenter;
                    sal[x, y] = s;
                    Controls.Add(s);
                }
            }

            platno = new Platno(size);           
            Controls.Add(platno);
        }

        /// <summary>
        /// Remove seats and screen
        /// </summary>
        private void Clear()
        {
            if (sal == null) return;
            for (int i = 0; i < sal.GetLength(0); i++)
            {
                for (int j = 0; j < sal.GetLength(1); j++)
                {
                    Controls.Remove(sal[i, j]);
                }
            }
            Controls.Remove(platno);
        }

    }
}