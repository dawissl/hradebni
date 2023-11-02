using System.Runtime.CompilerServices;

namespace _05_procvicovaniOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ctverec c1 = new Ctverec(5);
            Obdelnik o1 = new Obdelnik(6, 2);
            Krychle k1 = new Krychle(3);
            Kvadr kv1 = new Kvadr(3, 6, 3);
            Koule ko1 = new Koule(1.3);
            Trojuhelnik t1 = new Trojuhelnik(4, 3, 5);

            string tmp = "";
            tmp += $"{c1}{Environment.NewLine}";
            tmp += $"{o1}{Environment.NewLine}";
            tmp += $"{k1}{Environment.NewLine}";
            tmp += $"{kv1}{Environment.NewLine}";
            tmp += $"{ko1}{Environment.NewLine}";
            tmp += $"{t1}{Environment.NewLine}";

            MessageBox.Show(tmp);
        }
    }
}