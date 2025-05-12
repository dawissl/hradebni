namespace _22_BoolovakAlgebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /** P�EHLED ZNA�EK
        *   & = alt + 38 (AND)
        *   | = alt + 124 (OR)
        *   $ = alt + 36
        *   ^ = alt + 94 (XOR)
        *   ! (NOT)
        *   implikace A => B je vyj�d�ena jako
        *   !A || B
        *   ekvivalence odpov�d� porovn�n� ==
        */

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool a = chkA.Checked;
            bool b = chkB.Checked;
            string operation = cmbOperation.Text.ToUpper();
            bool result = false;
            try
            {
                switch (operation)
                {
                    case "A AND B":
                        result = a && b;
                        break;
                    case "A OR B":
                        result = a || b;
                        break;
                    case "A XOR B":
                        result = a ^ b;
                        break;
                    case "NOT A":
                        result = !a;
                        break;
                    case "NOT B":
                        result = !b;
                        break;
                    case "A IMPLICATE B":
                       result = !a || b;
                        break;
                    case "B IMPLICATE A":
                        result = !b || a;
                        break;
                    case "A EQUALL B":
                        result = a == b;
                        break;
                    default:
                        throw new Exception("Nezn�m� operace");
                }


                lblResult.Text = $"V�sledek: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zvolte operaci z p��slu�n� komponenty", ex.Message);
            }
        }
    }
}
