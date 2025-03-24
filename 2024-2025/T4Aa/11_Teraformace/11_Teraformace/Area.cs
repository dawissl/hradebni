using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Teraformace
{
    class Area : Label
    {
        private FactoryUnit unit;
        public FactoryUnit Unit
        {
            get { return unit; }
            set
            {
                if(BackColor == Color.Blue)
                {
                    MessageBox.Show("Cannot be placed on water tile");
                    return;
                }
                unit = value;
                Text = unit.Type.Substring(0, 1);
            }
        }
        public Area(bool water)
        {
            BackColor = water ? Color.Blue : Color.SandyBrown;
            Font = new Font("Arial", 20);
            Text = water ? "" : "-";
            Size = new Size(50, 50);
            TextAlign = ContentAlignment.MiddleCenter;
        }

    }
    public struct FactoryUnit
    {
        public string Type { get; }

        public FactoryUnit(string type)
        {
            Type = type;
        }

    }
}
