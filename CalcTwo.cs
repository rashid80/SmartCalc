using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalc
{
    class CalcTwo
    {

        private Ol ol;
        private CalcOne calcOne;

        public string b1;
        public decimal b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25, b26, b27, b28, b29, b30, b31;

        public decimal c8, d8, c13, d13, c15, d15, c16, d16, c17, d17, c18, d18, c31, d31;

        public CalcTwo(Ol inputOl, CalcOne inputCalcOne)
        {
            ol = inputOl;
            calcOne = inputCalcOne;

            Init();
        }

        private void Init()
        {
            b1 = ol.f3;
            b2 = ol.sum_c17_f17;
            b3 = ol.sum_c18_f18;
            b4 = ol.sum_c19_f19;
            b5 = ol.sum_c20_f20;
            b6 = calcOne.c9;
            b7 = calcOne.c10;

            c8 = 11;

            decimal sum_b2_b3 = b2 + b3;

            d8 = sum_b2_b3 * 2;
            b8 = c8 + d8;
            b9 = 2;
            b10 = sum_b2_b3;
            b11 = sum_b2_b3 * 3;
            b12 = b6 * 2;

            c13 = 0.5M;
            d13 = sum_b2_b3;
            b13 = c13 * d13;

            b14 = 3;

            c15 = 0.5M;
            d15 = sum_b2_b3 * 10;
            b15= c15 * d15;

            c16 = 0.5M;
            d16 = sum_b2_b3;
            b16 = c16 * d16;

            c17 = 1;
            d17 = sum_b2_b3;
            b17 = c17 * d17;

            c18 = 1;
            d18 = sum_b2_b3;
            b18 = c18 * d18;

            b19 = 5;
            b20 = 5;
            b21 = 5;
            b22 = 5;
            b23 = 5;

            b24 = 1;
            b25 = 2;
            b26 = 1;
            b27 = 10;
            b28 = 10;
            b29 = 10;
            b30 = 10;

            c31 = 0.1M;
            d31 = sum_b2_b3 * 2;
            b31 = c31 * d31;

        }
    }
}
