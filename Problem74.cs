using System;
namespace ConsoleApp
{
    public class Glass
    {
        public String color = "transparent";
        public int mass = 350;
        public int capacity = 200;
        public int water = 0;

        public Glass()
        {
        }
        public void showProperties()
        {
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Mass: {0}", mass);
            Console.WriteLine("Capacity: {0}", capacity);
            Console.WriteLine("Water: {0}", water);
            Console.WriteLine();
        }

        public Glass(String colors, int mass, int capacity, int water)
        {
            color = colors;
            this.mass = mass;
            this.capacity = capacity;
            this.water = water;
        }

        public void setWater(int volume)
        {
            this.water = volume;
        }
    }
}
