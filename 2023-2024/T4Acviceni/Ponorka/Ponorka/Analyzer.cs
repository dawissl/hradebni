using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponorka
{
    public class Analyzer
    {
        private List<Record> data = new List<Record>();

        public Analyzer(string path)
        {
            LoadData(path);
        }

        private void LoadData(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // data style (csv) 
                // TIMESTAMP(minutes);DEPTH(meters)
                sr.ReadLine(); // empty ready for deleting of heading
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // get data from line using Split()
                    string[] splitted = line.Split(";", 2);
                    Record newR = new Record(int.Parse(splitted[0]), double.Parse(splitted[1]));
                    data.Add(newR);
                }
                sr.Close();
            }
        }

        public string AnalyzeData(int start, int end)
        {
            List<Record> analyzedData = data.Where(x => x.Time >= start && x.Time <= end).ToList();
            if (analyzedData.Count < 2) { return "Missing data for analyze"; }

            List<double> gradients = new List<double>();

            for (int i = 0; i < analyzedData.Count - 1; i++)
            {
                // compute gradient for next two points
                double grad = (analyzedData[i + 1].Depth - analyzedData[i].Depth) / (analyzedData[i + 1].Time - analyzedData[i].Time);
                gradients.Add(grad);
            }

            double avgGrad = gradients.Average();
            // avg grad is coefficeent of function  
            // https://cs.wikipedia.org/wiki/Sm%C4%9Brnice_p%C5%99%C3%ADmky
            if (avgGrad > 0)
            {
                return "Depth of cruise is increasing";
            }
            if (avgGrad < 0)
            {
                return "Depth of cruise is decreasing";
            }
            return "Depth of cruise is constant";
        }

        public override string ToString()
        {
            string s = "Timestamp, depth (m)"+Environment.NewLine;
            foreach(Record r in data)
            {
                s += r.ToString()+Environment.NewLine;
            }
            return s;
        }
    }
}
