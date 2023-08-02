using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Square:Shape
    {
        private double _length;
        public double Length { get { return _length; } set { _length = value; } }
        private double _width;
        public double Width { get { return _width; } set { _width = value; } }
        public Square(double lenght,double width)
        { this.Length= lenght; this.Width = width; }
        public override double Area()
        { 
            return this.Length*this.Width;
        }
        public override double Perimeter()
        {
            return (this.Length + this.Width) * 2;
        }

    }
}
