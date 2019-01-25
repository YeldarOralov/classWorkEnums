using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = (int)StatusCodes.Ok;
            //Console.WriteLine(DayOfWeek.Monday);

            string dayOfWeek = "Friday";
            DayOfWeek dayOfWeekEnums;
            if(Enum.TryParse(dayOfWeek, out dayOfWeekEnums))
            {
                //logika raboty c enum
            }

            Point point = new Point(1, 2);
            ChangePoint(point);
            Console.WriteLine($"{point.X}, {point.Y}");

            Shop shop = new Shop
            {
                Name = null,//"Flip.kz",
                Address = "Караганда, ул. Какая-то",
                MapPoint = null//new Point(45, 12)
            };
            Console.WriteLine(shop.MapPoint.Value.X);


            Console.ReadLine();
        }

        public static void ChangePoint(Point point)
        {
            point.X = 3;
            point.Y = 5;
        }
    }
}
