using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Teraformace
{
    class Planet
    {
        private double oxygen;
        private double temperature;
        private double waterAmount;
        private Area[,] land;


        public Planet(int size)
        {
            land = new Area[size, size];
            GenerateLandTypes();
            temperature = -24;
            oxygen = 0;

        }
        public Planet(int size, double o2, double temp)
        {
            land = new Area[size, size];
            oxygen = o2;
            temperature = temp;
            GenerateLandTypes();
        }
        private void GenerateLandTypes()
        {
            double waterTiles = 0;
            Random rnd = new Random();
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    bool w = rnd.Next(0, 100) >= 75;
                    if (w) waterTiles++;
                    land[i, j] = new Area(w);
                    land[i, j].Location = new Point(10 + 55 * i, 10 + 55 * j);
                }
            }
            waterAmount = waterTiles / (land.GetLength(0) * land.GetLength(1));
            waterAmount *= 10;
        }

        public double Oxygen { get => oxygen; set => oxygen = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public double WaterAmount { get => waterAmount; set => waterAmount = value; }
        public Area[,] Land { get => land; }

        public bool isTerraType()
        {
            return oxygen > 12.0 && temperature > 8 && waterAmount > 15;
        }

        public void NextYearUpdate()
        {
            double oxygenFactor = 0;
            double waterFactor = 0;
            double temperatureFactor = 0;
            foreach (Area area in land)
            {
                switch (area.Unit.Type)
                {
                    case "WATER":
                        waterFactor += 0.15;
                        break;
                    case "OXYGEN":
                        oxygenFactor += 0.2;
                        break;
                    case "TEMPERATURE":
                        temperatureFactor += 0.4;
                        break;

                }
            }
            temperature += Math.Max(Math.Abs(temperature * (1 - temperatureFactor)),
                Math.Abs(1 - temperatureFactor));

            oxygen += Math.Max(oxygen * (1 - oxygenFactor), 1 - oxygenFactor);
            waterAmount += waterAmount * (1 - waterFactor);
            oxygen = Math.Min(oxygen, 100);
            waterAmount = Math.Min(waterAmount, 100);


        }
        public override string ToString()
        {
            return $"temperature: {Math.Round(temperature, 2)}°C{Environment.NewLine}oxygen: {Math.Round(oxygen, 2)}%{Environment.NewLine}water: {Math.Round(waterAmount, 2)}%";
        }
    }
}
