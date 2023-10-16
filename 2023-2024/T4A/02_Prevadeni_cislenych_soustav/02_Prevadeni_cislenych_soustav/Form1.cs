namespace _02_Prevadeni_cislenych_soustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if(ComboOut.SelectedIndex == -1) {
                MessageBox.Show("Vyberte prosím soustavu.");
                return;
            }

            if (TxtInput.Text == "")
            {
                MessageBox.Show("Zadejte vstupní hodnotu");
                return;
            }

            string output = "";
            switch (ComboOut.Text)
            {
                case "Binární":
                    output = ToBinary(TxtInput.Text);
                    break;
                case "Oktalová":
                    output = ToOct(TxtInput.Text);
                    break;
                case "Decimální":
                    output = TxtInput.Text;
                    break;
                case "Hexadecimální":
                    output = ToHex(TxtInput.Text);
                    break;
            }

            LblOut.Text = output;

        }

        private string ToBinary(string text)
        {
            int value = int.Parse(text);

           
            string output = "";
            while (value != 0)
            {
                output += $"{value%2}";
                value /= 2;

            }
            char[] chars = output.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);

        }

        private string ToOct(string text)
        {
            int value = int.Parse(text);

            string output = "";
            while (value != 0)
            {
                output += $"{value % 8}";
                value /= 8;

            }
            char[] chars = output.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        private string ToHex(string text)
        {
            int value = int.Parse(text);
            int tmp =0;
            string output = "";
            while (value != 0)
            {
               
                tmp = value % 16;

                if(tmp<10) output += $"{tmp}";
                if (tmp == 10) output += "A";
                if (tmp == 11) output += "B";
                if (tmp == 12) output += "C";
                if (tmp == 13) output += "D";
                if (tmp == 14) output += "E";
                if (tmp == 15) output += "F";

                value /= 16;

            }
            char[] chars = output.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
    }
}