﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.CherepanovVS.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
               multSeries = multSeries * Math.Pow((1 / Math.Pow(value, startValue)),3);
                startValue++;
            }
            return (Math.Round(multSeries, 3));
        }
    }
}
