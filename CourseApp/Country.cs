using System;

namespace CourseApp
{
    public class Country
    {
        private int population;
        private int area;
        private double density;

        public Country()
        {
            this.population = 0;
            this.area = 0;
            this.density = 0;
        }

        public Country(int population, int area, double density)
        {
            this.population = population;
            this.area = area;
            this.density = density;
        }

        public void AllInfo()
        {
            Console.WriteLine($"Насление: {this.population} , площадь: {this.area} , плотность насление: {this.density} ");
        }

        public void PopulationInfo()
        {
            Console.WriteLine($"Население: {this.population}");
        }

        public void AreaInfo()
        {
            Console.WriteLine($"Площадь: {this.area}");
        }

        public void DensityInfo()
        {
            Console.WriteLine($"Плотность населения: {this.density}");
        }
    }
}