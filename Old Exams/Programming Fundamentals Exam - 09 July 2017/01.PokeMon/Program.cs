﻿using System;
using System.Collections.Generic;

namespace _01.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustuonFactorY = int.Parse(Console.ReadLine());
            int N = pokePowerN;
            int result = 0;
            int count = 0;

            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                count++;

                if (exhaustuonFactorY != 0)
                {
                    if (pokePowerN == N * 0.5)
                    {
                        pokePowerN = pokePowerN / exhaustuonFactorY;
                    }
                }
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(count);
        }
    }
}
