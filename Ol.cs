using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalc
{
    class Ol
    {
        private Form1 myform;
        public string c1;
        public string c2;
        public string c3;
        public string c4;

        public string f1;
        public string f2;
        public string f3;

        public decimal c7, d7, e7, f7;
        public decimal c8, d8, e8, f8;
        public decimal c9, d9, e9, f9;
        public decimal c10, d10, e10, f10;

        public decimal d13;
        public decimal d14;

        public decimal c17, d17, e17, f17;
        public decimal c18, d18, e18, f18;
        public decimal c19, d19, e19, f19;
        public decimal c20, d20, e20, f20;

        public decimal sum_c17_f17;
        public decimal sum_c18_f18;
        public decimal sum_c19_f19;
        public decimal sum_c20_f20;

        public decimal sum_c17_f20;
        public decimal sum_c17_f18;

        public decimal sum_c7_f8;
        public decimal sum_c7_f7;
        public decimal sum_c8_f8;
        public decimal sum_c7_f10;
        public decimal sum_i17_j18;
        public decimal sum_c23_f23;
        public decimal sum_c24_f24;
        public decimal sum_c25_f25;
        public decimal sum_c26_f26;

        public decimal c23, d23, e23, f23;
        public decimal c24, d24, e24, f24;
        public decimal c25, d25, e25, f25;
        public decimal c26, d26, e26, f26;

        public decimal c28;
        public string c30;
        public decimal c32;
        public decimal c34;

        public decimal i2;
        public decimal i3;

        public decimal i6, i7, i8, i9, i10;

        public bool i12;

        public decimal i17, j17;
        public decimal i18, j18;
        public decimal i19, j19;
        public decimal i20, j20;

        public decimal i22;
        public decimal i23;


        public Ol(Form1 inputForm)
        {
            myform = inputForm;

            Init();
        }

        private void Init()
        { 

            c1 = myform.res.Text;
            c2 = myform.nomerTP.Text;
            c3 = myform.tipRU.Text;
            c4 = myform.month.Text;

            f1 = myform.dataOtkl.Text;
            f2 = myform.filial.Text;
            f3 = myform.podryad.Text;

            sum_c7_f10 = 0;
            sum_c7_f7 = 0;
            sum_c8_f8 = 0;

            var rows = myform.podchChet.Rows;
            sum_c7_f7 += setDecimalsFromRow(rows[0], ref c7, ref d7, ref e7, ref f7);
            sum_c8_f8 += setDecimalsFromRow(rows[1], ref c8, ref d8, ref e8, ref f8);
            sum_c7_f10 += setDecimalsFromRow(rows[2], ref c9, ref d9, ref e9, ref f9);
            sum_c7_f10 +=setDecimalsFromRow(rows[3], ref c10, ref d10, ref e10, ref f10);

            sum_c7_f8 = sum_c7_f7 + sum_c8_f8;
            sum_c7_f10 += sum_c7_f8;

            d13 = getDecimalFromString(myform.rastDver1.Text);
            d14 = getDecimalFromString(myform.rastDver2.Text);

            sum_c17_f17 = 0;
            sum_c18_f18 = 0;
            sum_c19_f19 = 0;
            sum_c20_f20 = 0;

            sum_c17_f18 = 0;
            sum_c17_f20 = 0;

            rows = myform.kolvoVidChetch.Rows;
            sum_c17_f17 += setDecimalsFromRow(rows[0], ref c17, ref d17, ref e17, ref f17);
            sum_c18_f18 += setDecimalsFromRow(rows[1], ref c18, ref d18, ref e18, ref f18);
            sum_c19_f19 += setDecimalsFromRow(rows[2], ref c19, ref d19, ref e19, ref f19);
            sum_c20_f20 += setDecimalsFromRow(rows[3], ref c20, ref d20, ref e20, ref f20);

            sum_c17_f18 += sum_c17_f17 + sum_c18_f18;
            sum_c17_f20 += sum_c17_f18 + sum_c19_f19 + sum_c20_f20;

            sum_c23_f23 = 0;

            rows = myform.tiporazmerShkafov.Rows;
            sum_c23_f23 += setDecimalsFromRow(rows[0], ref c23, ref d23, ref e23, ref f23);
            sum_c24_f24 += setDecimalsFromRow(rows[1], ref c24, ref d24, ref e24, ref f24);
            sum_c25_f25 += setDecimalsFromRow(rows[2], ref c25, ref d25, ref e25, ref f25);
            sum_c26_f26 += setDecimalsFromRow(rows[3], ref c26, ref d26, ref e26, ref f26);

            c28 = getDecimalFromString(myform.sredRastMdPU.Text);
            c30 = myform.tipMontazha.Text;
            c32 = getDecimalFromString(myform.rastTTdoShkafa.Text);
            c34 = getDecimalFromString(myform.rastOtMestaUstDoShkafa.Text);

            i2 = getDecimalFromString(myform.f3ChetchPryamVkl.Text);
            i3 = getDecimalFromString(myform.f1ChetchPryamVkl.Text);

            var dg = myform.uzelNarachKabel;
            setDecimalsDromCell(dg, ref i6, ref i7, ref i8, ref i9, ref i10);

            i12 = myform.svaya.Checked;

            sum_i17_j18 = 0;

            rows = myform.kolvoChetVShkafu.Rows;
            sum_i17_j18 += setDecimalsFromRow(rows[0], ref i17, ref j17);
            sum_i17_j18 += setDecimalsFromRow(rows[1], ref i18, ref j18);
            setDecimalsFromRow(rows[2], ref i19, ref j19);
            setDecimalsFromRow(rows[3], ref i20, ref j20);

            i22 = getDecimalFromString(myform.kabelDlyaNarach.Text);
            i23 = getDecimalFromString(myform.zazhimDlyNarach.Text);


        }

        private decimal getDecimalFromString(string str)
        {

            string s = str.Replace(".", ",");
            s = s.Replace(" ", "");

            if (s == "")
            {
                s = "0";
            }

            decimal result = 0;

            if (System.Decimal.TryParse(s, out result))
            {
                return result;
            }

            throw new Exception(@"ошибка преобразования строки '" + s + @"' в число!");

        }

        private decimal setDecimalsFromRow(System.Windows.Forms.DataGridViewRow row, ref decimal v1, ref decimal v2, ref decimal v3, ref decimal v4)
        {
            v1 = getDecimalFromString(row.Cells[1].Value.ToString());
            v2 = getDecimalFromString(row.Cells[2].Value.ToString());
            v3 = getDecimalFromString(row.Cells[3].Value.ToString());
            v4 = getDecimalFromString(row.Cells[4].Value.ToString());

            return v1 + v2 + v3 + v4;
        }

        private decimal setDecimalsFromRow(System.Windows.Forms.DataGridViewRow row, ref decimal v1, ref decimal v2)
        {
            v1 = getDecimalFromString(row.Cells[1].Value.ToString());
            v2 = getDecimalFromString(row.Cells[2].Value.ToString());

            return v1 + v2;
        }

        private void setStringsFromRow(System.Windows.Forms.DataGridViewRow row, ref string v1, ref string v2, ref string v3, ref string v4)
        {
            v1 = row.Cells[1].Value.ToString();
            v2 = row.Cells[2].Value.ToString();
            v3 = row.Cells[3].Value.ToString();
            v4 = row.Cells[4].Value.ToString();
        }

        private void setDecimalsDromCell(System.Windows.Forms.DataGridView dg, ref decimal v1, ref decimal v2, ref decimal v3, ref decimal v4, ref decimal v5)
        {
            v1 = getDecimalFromString(dg.Rows[0].Cells[1].Value.ToString());
            v2 = getDecimalFromString(dg.Rows[1].Cells[1].Value.ToString());
            v3 = getDecimalFromString(dg.Rows[2].Cells[1].Value.ToString());
            v4 = getDecimalFromString(dg.Rows[3].Cells[1].Value.ToString());
            v5 = getDecimalFromString(dg.Rows[4].Cells[1].Value.ToString());

        }



    }
}
