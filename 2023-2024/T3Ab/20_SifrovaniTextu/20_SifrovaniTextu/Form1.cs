namespace _20_SifrovaniTextu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCaesar_Click(object sender, EventArgs e)
        {
            TxtVystup.Text = "";
            foreach (char c in TxtVychozi.Text.ToUpper())
            {
                if (c > 'Z' || c < 'A')
                {
                    TxtVystup.Text += c;
                    continue;
                }
                int tmp = (int)(c + NumShift.Value);
                if (tmp > 'Z') tmp = 'A' - 'Z' + tmp - 1;
                if (tmp < 'A') tmp = 'Z' - 'A' + tmp + 1;
                TxtVystup.Text += Convert.ToChar(tmp);
            }
        }

        private void BtnMorse_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> morse = new Dictionary<char, string>()
            {
                {'A',".-"},{'B',"-..."},{'C',"-.-."},{'D',"-.."}
                ,{'E',"."},{'F',"..-."},{'G',"--."},{'H',"...."}
                ,{'I',".."},{'J',".--."},{'K',"-.-"},{'L',".-.."}
                ,{'M',"--"},{'N',"-."},{'O',"---"},{'P',".-.-"}
                ,{'Q',"--.-"},{'R',".-."},{'S',"..."},{'T',"-"}
                ,{'U',"..-"},{'V',"...-"},{'W',".--"},{'X',"-..-"},
                {'Z',"--.."}
            };
            TxtVystup.Text = "///";
            foreach (char c in TxtVychozi.Text.ToUpper())
            {
                if (c == ' ')
                {
                    TxtVystup.Text += "/";
                    continue;
                }
                TxtVystup.Text += morse[c] + "/";
            }
            TxtVystup.Text += "//";
        }
    }
}