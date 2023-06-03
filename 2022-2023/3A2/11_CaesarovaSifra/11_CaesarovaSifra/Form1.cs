namespace _11_CaesarovaSifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            //  char c = char.Parse(TxtInput.Text.ToLower());

            string outString = "";
            foreach (char c in TxtInput.Text.ToLower())
            {

                if (c == ' ')
                {
                    outString += " ";
                    continue;
                }
                int move = (int)NumMove.Value;

                outString += Convert.ToChar(Crypt(c, move)).ToString();
            }

            LblOut.Text = outString;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string outString = "";
            foreach (char c in TxtInput.Text.ToLower())
            {

                if (c == ' ')
                {
                    outString += " ";
                    continue;
                }
                int move = -1 * (int)NumMove.Value;                

                outString += Convert.ToChar(Crypt(c,move)).ToString();
            }

            LblOut.Text = outString;
        }

        private int Crypt(char c, int move)
        {
            int asciChar = Convert.ToInt32(c) + move;

            if (asciChar > Convert.ToInt32('z'))
            {
                move = asciChar - Convert.ToInt32('z') - 1;
                asciChar = Convert.ToInt32('a') + move;
            }

            if (asciChar < Convert.ToInt32('a'))
            {
                move = Convert.ToInt32('a') - asciChar - 1;
                asciChar = Convert.ToInt32('z') - move;
            }
            return asciChar;
        }
    }
}