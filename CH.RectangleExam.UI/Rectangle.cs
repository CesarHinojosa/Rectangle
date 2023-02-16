using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.RectangleExam.UI
{
    public class Rectangle
    {
        //properties
        //both are float
        public float Length { get; set; }

        public float Width { get; set; }

        //methods with no parameters
        //both are float
        public float CalculateArea()
        {
            return Length * Width;
        }

        public float CalculatePerimeter()
        {
            
            return (2 * Length) + (2 * Width);
        }
    }
}
