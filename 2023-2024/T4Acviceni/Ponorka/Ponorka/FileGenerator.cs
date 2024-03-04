using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponorka
{
    public class FileGenerator
    {
        private int start, end;

        public FileGenerator(string path, int s, int e)
        {
            start = s;
            end = e;
            if (e < s) { MessageBox.Show("Invalid input"); return; }           
            CreateData($"{path}.csv");
        }

        private void CreateData(string path)
        {
            Random rnd = new Random();

            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("TIMESTAMP(minute);DEPTH(meter)");
                for(int i = start;i <= end; i++)
                {
                    // create data loss
                    int tmp = rnd.Next(1, 101);
                    if (tmp < 20) continue;
                    // submarine interval of cruise depth <20;200>
                    sw.WriteLine($"{i};{rnd.Next(20,201)}");
                }
                sw.Close();
            }
        }
    }
}
