﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No10
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
    }
        //public class Circle : Shape
        //{
        //   public int r;
        //   public double result;
        //   public Circle(int r)
        //   { 
        //    this.r = r;
        //   }
        //   public override void CalculateArea()
        //   {
        //     result = (double)r * r * 3.14;
        //   }
        //   public override string ToString()
        //   {
        //    return $"Area of circle is {result}";
        //   }
        //}
        public class Rectangle : Shape
        {
        public int l;
        public int b;
        public int result;
        public Rectangle(int l,int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            result = l * b;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is {result}";
        }
    }

}
