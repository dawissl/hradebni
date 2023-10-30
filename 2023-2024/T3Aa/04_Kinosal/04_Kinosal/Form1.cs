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
            /// 2) napln�n� dvourozm�rn�ho pole sedadly
            /// 3) sedadla jsou rozm�st�na v s�le a jsou mezi nimi mezery
            /// B1) p�idat p�ed sedadla pl�tno Label
            /// B2) p�idat sedadl�m ��slov�n� viditeln� pro u�ivatele
            /// 
            Clear();
            //1)
            int size = Convert.ToInt32(NumSize.Value);
            if (size <= 0)
            {
                MessageBox.Show("Nelze m�t s�l bez seda�ek");
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