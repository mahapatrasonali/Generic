﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Genericmaximum<T> where T : IComparable
    {
        public T[] value;
        public Genericmaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values) 
        {
          Array.Sort( values);
            return values;
        }
        public T MaxValue(params T[] values) 
        {
          var sorted_values = Sort(values);
            return sorted_values[0];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void printMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }

    }
  
}
