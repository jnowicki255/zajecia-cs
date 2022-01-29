using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_OverridingOperators
{
    internal class ComplexNumber
    {
        public double Re { get; init; }
        public double Im { get; init; }

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Re - c2.Re, c1.Im - c2.Im);
        }

        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Re == c2.Re && c1.Im == c2.Im;
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2){
            double re = (c1.Re * c2.Re) - (c1.Im * c2.Im);
            double im = (c1.Re * c2.Im) + (c2.Re * c1.Im);

            return new ComplexNumber(re, im);
        }

        public override string ToString()
        {
            if (Im >= 0)
                return $"{Re} + {Im}i";
            return $"{Re} - {Math.Abs(Im)}i";
        }
    }
}
