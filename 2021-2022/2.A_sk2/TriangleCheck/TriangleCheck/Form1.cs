using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            // obarvení labelu
            LblCheck.BackColor = Color.Yellow;
            if(Triangle(NumericSideA.Value, NumericSideB.Value, NumericSideC.Value))
            {
                LblCheck.BackColor = Color.Green;
            }
            else
            {
                LblCheck.BackColor = Color.Red;
            }

        }
      
    /// <summary>
    /// Funkce pro zjištění, zda zadané strany mohou sestrojit trojúhelník
    /// </summary>
    /// <param name="a">délka strany a</param>
    /// <param name="b">délka strany b</param>
    /// <param name="c">délka strany c</param>
    /// <returns>true pokud lze sestrojit trojúhelník</returns>
        private bool Triangle(decimal a, decimal b, decimal c)
        {
            if (a + b <= c) return false;
            if (a + c <= b) return false;
            if (c + b <= a) return false;
            return true;
            //alternativně
            // return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
