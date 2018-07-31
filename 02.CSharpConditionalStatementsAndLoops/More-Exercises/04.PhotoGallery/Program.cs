using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double sizeInBytes = double.Parse(Console.ReadLine());
            int resolutionWidth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minute:d2}");
            if(sizeInBytes < 1000)
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }
            else if (sizeInBytes <= 1000000)
            {
                Console.WriteLine($"Size: {sizeInBytes / 1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {(sizeInBytes / 1000) / 1000}MB");
            }
            if (resolutionWidth > resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (landscape)");
            }
            else if (resolutionWidth == resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (square)");
            }
            else
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (portrait)");
            }
        
        }
    }
}
