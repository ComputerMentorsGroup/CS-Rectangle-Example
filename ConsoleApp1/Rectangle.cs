using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        private float _width;
        private float _height;

        public float Width {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new FormatException();
            }
        }
        public float Height
        {
            get => _height;
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new FormatException();
            }
        }

        public float Area
        {
            get
            {
                return _width * _height;
            }
        }


    }
}
