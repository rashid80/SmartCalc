using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalc
{
    class CalcOne
    {
        private Ol ol;

        public string c2, c3, c4, c5, c6, c7, c8, c101;
        public decimal c9, c10, c11, c12, c13, c18, c31, c32, c33, c34, c35, c36, c37, c38, c39, c40, c41, c42, c44, c45, c46, c47, c48, c49, c50, c51, c52, c53, c54, c55, c56, c57, c59, c60, c61, c62, c63;
        public decimal c64, c65, c66, c67, c68, c69, c70, c71, c72, c73, c74, c75, c76, c77, c78, c79, c80, c81, c82, c83, c84, c85, c86, c87, c88, c89, c90, c91, c92, c93, c94, c95, c96, c97, c98, c99, c100;

        private decimal d18, e18;
        private decimal d31, e31, f31;
        private decimal d32, e32;
        private decimal d33, e33;
        private decimal d41, d42, d44, d45, d56, d57, d58, d59, d60, d61;

    

        public CalcOne(Ol inputOl)
        {
            ol = inputOl;

            Init();
        }

        private void Init()
        {
            c5 = ol.c3;
            c7 = ol.f3;
            c8 = ol.f2;
            c2 = ol.c1;
            c4 = ol.f1;
            c3 = ol.c4;

            c6 = ol.c2;

            c9 = ol.sum_c17_f18;

            c10 = (ol.sum_c17_f18 <= 9) ? 2 : 4;
            c11 = (ol.sum_c17_f18 <= 9) ? 45 : 60;
            c12 = (ol.sum_c17_f18 <= 9) ? 2 : 4;
            c13 = (ol.sum_c17_f18 <= 9) ? 2 : 4;

            d18 = ol.c28;
            e18 = (ol.sum_c17_f20 > 0) ? 8 : 0;
            c18 = d18 + e18;

            d31 = ol.d13;
            e31 = ol.d14;
            f31 = (ol.sum_c17_f20 > 0) ? 2 : 0;
            c31 = d31 + e31 + f31;

            d32 = ol.c32;
            e32 = ol.sum_c7_f8;
            c32 = d32 * e32;

            d33 = ol.c34;
            e33 = ol.sum_c7_f7;
            c33 = d33 * e33;

            c34 = 8; //fix
            c35 = 6;

            c36 = c33 + c18; //fix
            c37 = c36;
            c38 = c32;
            c39 = c38;

            bool snaruzhi = (ol.c30 == "снаружи");

            c40 = (snaruzhi) & (ol.c3 == "БКТП" | ol.c3 == "ЗРУ") ? 1 : 0;

            d41 = Math.Ceiling(ol.sum_c8_f8 / 8); //fix
            c41 = (ol.sum_i17_j18 < 8) ? 0 : d41;

            d44 = c37 + c39 + c41;
            c44 = (ol.c3 == "СТП" | ol.c3 == "КТП") ? d44 : 0;

            d45 = ol.sum_c7_f10 * 3;
            c45 = (snaruzhi) ? d45 : 0;


            d42 = c37 + c39 + c41;

            switch (ol.c3)
            {
                case "КТП":
                    c42 = d42;
                    c46 = 1;
                    c49 = 0;
                    break;
                case "СТП":
                    c42 = d42;
                    c46 = 0;
                    c49 = 2;
                    break;
                case "БКТП":
                    c42 = 0;
                    c46 = 1;
                    c49 = 0;
                    break;
                case "ЗРУ":
                    c42 = 0;
                    c46 = 1;
                    c49 = 0;
                    break;
                default:
                    c42 = 0;
                    c46 = 0;
                    c49 = 0;
                    break;
            }

            c47 = ol.sum_c7_f7;
            c48 = snaruzhi ? 1 : 1;
            

            c50 = 6;
            c51 = 20;
            c52 = 20;
            c53 = 10;
            c54 = 10;
            c55 = 10;

            bool svaya = ol.i12;

        
            d56 = (ol.sum_c7_f10 <= 9) ? 1 : 2;
            c56 = (svaya) ? d56 : 0;

            d57 = c56 * 9;
            c57 = (svaya) ? d57 : 0;

            d58 = (ol.sum_c7_f10 <= 9) ? 1 : 2;
            //c58 = (svaya) ? d58 : 0;

            d59 = (ol.sum_c7_f10 <= 9) ? 1 : 2;
            c59 = (svaya) ? d59 : 0;

            d60 = (ol.sum_c7_f10 <= 9) ? 1 : 2;
            c60 = (svaya) ? d60 : 0;

            d61 = (ol.sum_c7_f10 <= 9) ? 2 : 4;
            c61 = (svaya) ? d61 : 0;

            c62 = c61 * 10;
            c63 = c61 * 10;
            c64 = c61 * 10;
            c65 = c61 * 10;
            c66 = c61 * 10;

            switch (ol.c3)
            {
                case "СТП":
                    c67 = 1;
                    c68 = 2;
                    c69 = 10;
                    c70 = 10;
                    break;
                case "КТП":
                    c67 = 0;
                    c68 = 0;
                    c69 = 0;
                    c70 = 0;
                    break;
                case "БКТП":
                    c67 = 0;
                    c68 = 0;
                    c69 = 0;
                    c70 = 0;
                    break;
                case "ЗРУ":
                    c67 = 0;
                    c68 = 0;
                    c69 = 0;
                    c70 = 0;
                    break;
                default:
                    c67 = 0;
                    c68 = 0;
                    c69 = 0;
                    c70 = 0;
                    break;
            }


            c71 = 5;
            c72 = 5;
            c73 = 5;

            c74 = ol.i6 * 3;
            c75 = ol.i7 * 3;
            c76 = ol.i8 * 3;
            c77 = ol.i9 * 3;
            c78 = ol.i10 * 3;

            c79 = ol.i6 * 27;
            c80 = ol.i7 * 27;
            c81 = ol.i8 * 27;
            c82 = ol.i9 * 27;
            c83 = ol.i10 * 27;

            c84 = (ol.i6 + ol.i7 + ol.i8) * 1;
            c85 = (ol.i9 + ol.i10) * 1;

            decimal sum_c74_c83 = c74 + c75 + c76 + c77 + c78 + c79 + c80 + c81 + c82 + c83;

            c86 = sum_c74_c83 * 2;
            c87 = sum_c74_c83 * 2;
            c88 = sum_c74_c83 * 2;

            c89 = ol.sum_c23_f23 * 54 + ol.sum_c24_f24 * 96 + ol.sum_c25_f25 * 206 + ol.sum_c26_f26 * 276;
            c90 = 30;

            c91 = (ol.i22 > 0) ? 4 : 0;
            c92 = ol.i22;

            c93 = ol.i17;
            c94 = ol.i18;
            c95 = ol.i19;
            c96 = ol.i20;
            c97 = ol.j17;
            c98 = ol.j18;
            c99 = ol.j19;
            c100 = ol.j20;

            string pos1 = "ЩУ";
            string pos2 = "  ";
            string pos3 = (ol.i17 + ol.j17).ToString();
            string pos4 = (ol.i18 + ol.j18).ToString();
            string pos5 = (ol.i19 + ol.j19).ToString();
            string pos6 = (ol.i20 + ol.j20).ToString();
            string pos7 = "  ";

            if (ol.sum_c23_f23 > 0)
            {
                pos2 = "0,8";
                pos7 = "А";
            }
            if (ol.sum_c24_f24 > 0)
            {
                pos2 = "1";
                pos7 = "Б";
            }
            if (ol.sum_c25_f25 > 0)
            {
                pos2 = "1,8";
                pos7 = "В";
            }
            if (ol.sum_c26_f26 > 0)
            {
                pos2 = "2";
                pos7 = "Г";
            }

            c101 = pos1 + "-" + pos2 + "-" + pos3 + "." + pos4 + "." + pos5 + "." +pos6 + "(" + pos7 + ")";

        }

    }
}
