namespace ZOO_OOP
{
    internal class Plaz : Zvire
    {
        
        private bool jedovaty;

        public Plaz(string jmeno, double porodniVaha, bool jedovaty): base(jmeno, porodniVaha)
        {
           
            this.jedovaty = jedovaty;
        }

        public override string ToString()
        {
            return base.ToString() + " (plaz)";
        }
    }
}