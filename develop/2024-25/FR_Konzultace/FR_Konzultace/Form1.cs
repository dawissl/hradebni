namespace FR_Konzultace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Funkce()
        {
            int[] pole = new int[50];
            pole[35] = 77;
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(560);
            int promenna = list[1];
            pole[35]++;
            list[1]++;
            int a, b, c;
            int[] vek = new int[3];
            MojeTrida abc = new MojeTrida();
            MojeTrida def = new MojeTrida(Color.Red);

            def.Barva = Color.Green;
            List<MojeTrida> razitka = new List<MojeTrida>();
            razitka.Add(def);
            razitka.Add(abc);
            List<string> slova = new List<string>();
            slova.Contains("ahoj");
            abc.Funkce();
            def.Funkce();
            razitka[1].Funkce();
        }
    }
}