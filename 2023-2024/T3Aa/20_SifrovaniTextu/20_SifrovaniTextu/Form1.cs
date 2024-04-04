using System.Reflection;

namespace _20_SifrovaniTextu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMake_Click(object sender, EventArgs e)
        {
            // pøemazání pudovního výstupu
            TxtSiforvany.Text = "";
            // pøevedeni textu na velka pismena pro zjednoduseni podminek
            foreach (char c in TxtVychozi.Text.ToUpper())
            {
                // zachovani znaku mimo rozsah abecedy
                if (c < 'A' || c > 'Z')
                {
                    TxtSiforvany.Text += c;
                    continue;
                }
                int tmp = (int)(c + NumShift.Value);
                // muzeme si dovolit porovnat int s char, protože char je
                // reprezentovan jako ASCII kód
                if (tmp > 'Z') tmp = 'A' - 'Z' + tmp - 1;
                if (tmp < 'A') tmp = 'Z' - 'A' + tmp + 1;
                TxtSiforvany.Text += Convert.ToChar(tmp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtSiforvany.Text = "///";
            // definice slovíku 
            Dictionary<char, string> morse = new Dictionary<char, string>
            {
                { 'A', ".-" },{ 'B', "-..." },{ 'C', "-.-." },{ 'D', "-.." },
                { 'E', "." },{ 'F', "..-." },{ 'G', "--." },{ 'H', "...." },
                { 'I', ".." },{ 'J', ".---" },{ 'K', "-.-" },{ 'L', ".-.." },
                { 'M', "--" },{ 'N', "-." },{ 'O', "---" },{ 'P', ".--." },
                { 'Q', "--.-" },{ 'R', ".-." },{ 'S', "..." },{ 'T', "-" },
                { 'U', "..-" },{ 'V', "...-" },{ 'W', ".--" },{ 'X', "-..-" },
                { 'Z', "--.." },
            };
            foreach (char c in TxtVychozi.Text.ToUpper())
            {
                if (c == ' ')
                {
                    // zaznaèení mezery
                    TxtSiforvany.Text += "/";
                    continue;
                }
                // pøeskoèení neznámého klíèe
                if (!morse.ContainsKey(c)) continue;
                // získání hodnoty na základì klíèe slovníku
                TxtSiforvany.Text += morse[c] + "/";
            }
            TxtSiforvany.Text += "//"; // ukonèení zprávy
        }


    }
}
