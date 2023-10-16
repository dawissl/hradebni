namespace _02_CiselneSoustavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            int number = ConvertToDec(TxtInput.Text);
            string output = "";

            switch (comboBox1.Text)
            {
                case "Binární":
                    output = ConvertToBin(number);
                    break;
                case "Osmièková":
                    output = ConvertToOct(number);
                    break;
                case "Desítková":
                    output = number.ToString();
                    break;
                case "Hexadecimální":
                    output = ConvertToHex(number);
                    break;
            }



            LblOutput.Text = output;

        }

        private int ConvertToDec(string text)
        {
            switch (comboBox2.Text)
            {
                case "Binární":
                    return FromBinary(int.Parse(text));
                case "Osmièková":
                    return FromOctal(int.Parse(text));
                case "Desítková":
                    return int.Parse(text);
                case "Hexadecimální":
                    return FromHex(text);
                default:
                    return -1;
            }
        }

        private int FromBinary(int v)
        {
            char[] binArr = v.ToString().ToCharArray();
            int result = 0;
            for (int i = 0; i < binArr.Length; i++)
            {
                result += (int)Char.GetNumericValue(binArr[i]) * (int)Math.Pow(2, i);
            }
            return result;
        }

        private int FromOctal(int v)
        {
            char[] octArr = v.ToString().ToCharArray();
            int result = 0;
            for (int i = 0; i < octArr.Length; i++)
            {
                result += (int)Char.GetNumericValue(octArr[i]) * (int)Math.Pow(8, i);
            }
            return result;
        }

        private int FromHex(string v)
        {
            char[] hexArr = v.ToString().ToCharArray();
            int result = 0;
            for (int i = 0; i < hexArr.Length; i++)
            {
                if (Char.IsDigit(hexArr[i]))
                {
                    result += (int)Char.GetNumericValue(hexArr[i]) * (int)Math.Pow(16, i);
                }
                else
                {
                    int num = 0;
                    if (hexArr[i] == 'A') num = 10;
                    if (hexArr[i] == 'B') num = 11;
                    if (hexArr[i] == 'C') num = 12;
                    if (hexArr[i] == 'D') num = 13;
                    if (hexArr[i] == 'E') num = 14;
                    if (hexArr[i] == 'F') num = 15;

                    result += num * (int)Math.Pow(2, 1);
                }

            }
            return result;
        }

        private string ConvertToBin(int number)
        {
            string tmp = "";
            while (number != 0)
            {
                tmp += $"{number % 2}";
                number /= 2;
            }
            char[] charNumber = tmp.ToCharArray();
            Array.Reverse(charNumber);
            return new string(charNumber);

        }

        private string ConvertToHex(int number)
        {
            string tmp = "";
            while (number != 0)
            {
                int rest = number % 16;
                if (rest < 10) tmp += $"{rest}";

                switch (rest)
                {
                    case 10:
                        tmp += "A";
                        break;
                    case 11:
                        tmp += "B";
                        break;
                    case 12:
                        tmp += "C";
                        break;
                    case 13:
                        tmp += "D";
                        break;
                    case 14:
                        tmp += "E";
                        break;
                    case 15:
                        tmp += "F";
                        break;
                }
                number /= 16;
            }
            char[] charNumber = tmp.ToCharArray();
            Array.Reverse(charNumber);
            return new string(charNumber);
        }

        private string ConvertToOct(int number)
        {

            string tmp = "";
            while (number != 0)
            {
                tmp += $"{number % 8}";
                number /= 8;
            }
            char[] charNumber = tmp.ToCharArray();
            Array.Reverse(charNumber);
            return new string(charNumber);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}