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
            Console.WriteLine($"Население, площадь и плоность равны 0");
        }

        public Country(int population, int area, double density)
        {
            this.population = population;
            this.area = area;
            this.density = density;
        }

        public void AllInfo()
        {
            if (this.population != 0 || this.area != 0 || this.density != 0)
            {
                Console.WriteLine($"Насление: {this.population} , площадь: {this.area} , плотность: {this.density} ");
            }
            else
            {
                Console.WriteLine($"Ошибка ввода данных");
            }
        }

        public void PopulationInfo()
        {
            if (this.population != 0)
            {
                Console.WriteLine($"Население: {this.population}");
            }
            else
            {
                Console.WriteLine($"Население равна 0");
            }
        }

        public void AreaInfo()
        {
            if (this.area != 0)
            {
                Console.WriteLine($"Площадь: {this.area}");
            }
            else
            {
                Console.WriteLine($"Площадь равна 0");
            }
        }

        public void DensityInfo()
        {
            if (this.density != 0)
            {
                Console.WriteLine($"Плотность населения: {this.density}");
            }
            else
            {
                Console.WriteLine($"Плотность равна 0");
            }
        }
    }
}