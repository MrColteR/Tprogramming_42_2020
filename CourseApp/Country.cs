using System;

namespace CourseApp
{
    public class Country
    {
        private int population;
        private int area;

        public Country()
        {
            this.population = 0;
            this.area = 0;
        }

        public Country(int population, int area)
        {
            this.population = population;
            this.area = area;
            if (area <= 0 && population <= 0)
            {
                this.area = 1;
                this.population = 1;
            }
        }

        public void Hello()
        {
            Console.WriteLine($"Насление: {population} , площадь: {area} ");
        }
    }
}