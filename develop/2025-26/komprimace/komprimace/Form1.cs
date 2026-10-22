namespace komprimace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool NoDigitCheck()
        {
            foreach (char c in TxtInput.Text)
            {
                if (Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        
        private void BtnWork_Click(object sender, EventArgs e)
        {
            TxtInput.ForeColor = Color.Black;

            if (!NoDigitCheck())
            {
                TxtInput.ForeColor = Color.Red;
                return;
            }
            
            List<string> data = new List<string>();
            char znak = TxtInput.Text[0];
            int counter = 1;
            for(int i = 1; i < TxtInput.Text.Length; i++)
            {
                if (TxtInput.Text[i] == znak)
                    counter++;
                else
                {
                    if (counter == 1)
                    {
                        data.Add($"{znak}");
                    }
                    else
                    {
                        data.Add($"{counter}{znak}");
                        counter = 1;
                    }
                    znak = TxtInput.Text[i];
                }
            }
            // pridani posledni skupiny znaku po skonèení forcyku
            if (counter == 1)
            {
                // newString += $"{znak}";
                data.Add($"{znak}");
            }
            else
            {
                data.Add($"{counter}{znak}");
                counter = 1;
            }

            string newString = string.Empty;
            foreach(string s in data) newString += s;
           LblVystup.Text = newString;
        }
    }
}
