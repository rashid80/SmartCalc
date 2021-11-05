using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalc
{

    class Reports
    {
        private Ol ol;
        private CalcOne calcOne;
        private CalcTwo calcTwo;

        private DateTime currTime;

        private string fileName_BSH = "1.xlsx";
        private string fileName_MPOT = "2.xlsx";
        private string fileName_PE = "3.xlsx";
        private string fileName_SZ = "4.xlsx";

        private string title_BSH = @"ЗАЯВКА ""МОНТАЖ В СУЩЕСТВУЮЩИЕ ШКАФЫ"" БШ-3";
        private string title_MPOT = @"Заявка ""Монтаж ТТ"" МПОТ - 1";
        private string title_PE = @"ЗАЯВКА ""СБОРКА ТТ"" ПЭ - 22";
        private string title_SZ = @"Заявка СЗ - 3";

        public Reports(Ol olInput)
        {
            ol = olInput;

            Init();
        }

        private void Init()
        {

            currTime = DateTime.Now;

            calcOne = new CalcOne(ol);
            calcTwo = new CalcTwo(ol, calcOne);

        }



        private List<string> getheadList(string repName)
        {

            var ar1 = new List<string>();

            switch (repName)
            {
                case "BSH":
                    ar1 = getHeaderAsStringListForReport_BSH();
                    break;
                case "MPOT":
                    ar1 = getHeaderAsStringListForReport_MPOT();
                    break;
                case "PE":
                    ar1 = getHeaderAsStringListForReport_PE();
                    break;
                case "SZ":
                    ar1 = getHeaderAsStringListForReport_SZ();
                    break;
                default:
                    break;
            }

            return ar1;
        }

        private Tuple<bool, string> AddStringToReport(string folderName, string fileName_Rep, string title_Rep, List<string> varList, string repName)
        {

            string fileName = folderName + @"\" + fileName_Rep;

            if (!System.IO.File.Exists(fileName))
            {
                var t1 = ExcelWork.CreateExcelFile(fileName);
                if (t1.Item1) //err == true
                {
                    return t1;
                }

                var ar0 = new List<string> { title_Rep };
                t1 = ExcelWork.SaveStringArrayAsExcelFileRow(ar0, fileName, 1, 1);
                if (t1.Item1) //err == true
                {
                    return t1;
                }

                ar0[0] = " ";
                t1 = ExcelWork.SaveStringArrayAsExcelFileRow(ar0, fileName, 2, 1, false);
                if (t1.Item1) //err == true
                {
                    return t1;
                }

                var headList = getheadList(repName);
                headList.Add("Дата добавления");

                t1 = ExcelWork.SaveStringArrayAsExcelFileRow(headList, fileName);
                if (t1.Item1) //err == true
                {
                    return t1;
                }

            }

            varList.Add(currTime.ToString());

            var t2 = ExcelWork.SaveStringArrayAsExcelFileRow(varList, fileName);
            return t2;

        }


        private List<string> getVariablesAsStringListForReport_BSH()
        {
            var sl = new List<string>
            {
                calcOne.c2.ToString(),
                calcOne.c7.ToString(),

                calcTwo.b2.ToString(),
                calcTwo.b3.ToString(),
                calcTwo.b4.ToString(),
                calcTwo.b5.ToString(),
                calcTwo.b6.ToString(),

                calcTwo.b7.ToString(),
                calcTwo.b8.ToString(),
                calcTwo.b9.ToString(),
                calcTwo.b10.ToString(),
                calcTwo.b11.ToString(),

                calcTwo.b12.ToString(),
                calcTwo.b13.ToString(),
                calcTwo.b14.ToString(),
                calcTwo.b15.ToString(),
                calcTwo.b16.ToString(),

                calcTwo.b17.ToString(),
                calcTwo.b18.ToString(),
                calcTwo.b19.ToString(),
                calcTwo.b20.ToString(),
                calcTwo.b21.ToString(),

                calcTwo.b22.ToString(),
                calcTwo.b23.ToString(),
                calcTwo.b24.ToString(),
                calcTwo.b25.ToString(),
                calcTwo.b26.ToString(),

                calcTwo.b27.ToString(),
                calcTwo.b28.ToString(),
                calcTwo.b29.ToString(),
                calcTwo.b30.ToString(),
                calcTwo.b31.ToString()
            };

            return sl;

        }

        private List<string> getHeaderAsStringListForReport_BSH()
        {
            var sl = new List<string>
            {
                "РЭС",
                "Подрядчик",

                "Счетчик электроэнергии трехфазный трансформаторного включения (МАСТЕР)",
                "Счетчик электроэнергии трехфазный трансформаторного включения (ЛИНЕЙНЫЙ)",
                "3ф (AM550-TD1), шт.",
                "1ф (AM550-ED0), шт.",
                "Коробка клеммная испытательная переходная",

                "DIN рейка 300 мм",
                "Клемма проходная  2.5 кв",
                "Заглушка для клеммы проходной",
                "Сальник PG для гофротрубы 32 мм",
                "Саморез по металлу 4,2х13",

                "Саморез по металлу 4,2х30",
                "Кабель витая пара FTP 2x2x0.5",
                "Кабель контрольный КВВГнг 4х0,75 Цветной",
                "Кабель ПУВ 1х2,5 Белый",
                "Кабель ПУВ 1х2,5 Синий",

                "Кабель ПУВ 1х1,5 Белый",
                "Кабель ПУВ 1х1,5 Синий",
                "Винт 4х50",
                "Гайка М4",
                "Шайба М4 расширенная",

                "Шайба М4 гровер",
                "Шайба М4 Каучук",
                "Шинка заземления винтовая на 12 присоединений на DIN рейку",
                "Кабель канал 30х40; м",
                "Концевой выключатель",

                "Шайба усиленная М8 DIN 9021; шт",
                "Гайка М8 DIN 934; шт",
                "Болт М8х30 DIN 934; шт",
                "Шайба М8 гровер DIN 127",
                "Кембрик для маркировки кабеля; метры"
            };


            return sl;

        }

        public Tuple<bool, string> AddStringToReport_BSH(string folderName)
        {

            var varList = getVariablesAsStringListForReport_BSH();
            var t1 = AddStringToReport(folderName, fileName_BSH, title_BSH, varList, "BSH");

            return t1;

        }


        private List<string> getVariablesAsStringListForReport_MPOT()
        {
            var sl = new List<string>
            {
                calcOne.c5.ToString(),
                calcOne.c6.ToString(),
                calcOne.c7.ToString(),
                calcOne.c8.ToString(),
                calcOne.c2.ToString(),

                calcOne.c4.ToString(),
                calcOne.c3.ToString(),
                calcOne.c18.ToString(),
                calcOne.c31.ToString(),
                calcOne.c32.ToString(),

                calcOne.c33.ToString(),
                calcOne.c34.ToString(),
                calcOne.c35.ToString(),
                calcOne.c36.ToString(),
                calcOne.c37.ToString(),

                calcOne.c38.ToString(),
                calcOne.c39.ToString(),
                calcOne.c40.ToString(),
                calcOne.c41.ToString(),
                calcOne.c45.ToString(),

                calcOne.c47.ToString(),
                calcOne.c48.ToString(),
                calcOne.c49.ToString(),
                (calcOne.c46 + calcOne.c60 + calcOne.c67).ToString(),
                calcOne.c56.ToString(),

                calcOne.c57.ToString(),
                //sl.Add(calcOne.c58.ToString());
                calcOne.c59.ToString(),
                calcOne.c42.ToString(),
                calcOne.c44.ToString(),

                (calcOne.c50 + calcOne.c61 + calcOne.c68).ToString(),
                (calcOne.c51 + calcOne.c64 + calcOne.c69 + calcOne.c62).ToString(),
                (calcOne.c52 + calcOne.c63 + calcOne.c55 + calcOne.c70 + calcOne.c72).ToString(),
                (calcOne.c66 + calcOne.c53).ToString(),
                calcOne.c54.ToString(),

                calcOne.c55.ToString(),
                calcOne.c71.ToString(),
                calcOne.c74.ToString(),
                calcOne.c75.ToString(),
                calcOne.c76.ToString(),

                calcOne.c77.ToString(),
                calcOne.c78.ToString(),
                calcOne.c79.ToString(),
                calcOne.c80.ToString(),
                calcOne.c81.ToString(),

                calcOne.c82.ToString(),
                calcOne.c83.ToString(),
                calcOne.c84.ToString(),
                calcOne.c85.ToString(),
                calcOne.c86.ToString(),

                calcOne.c87.ToString(),
                calcOne.c88.ToString(),
                calcOne.c89.ToString(),
                calcOne.c90.ToString(),
                calcOne.c91.ToString(),

                calcOne.c92.ToString()
            };

            return sl;

        }

        private List<string> getHeaderAsStringListForReport_MPOT()
        {
            var sl = new List<string>
            {
                "Тип распределительного устройства",
                "Номер ТП",
                "Подрядчик",
                "Филиал",
                "РЭС",

                "Дата отключения",
                "Месяц",
                "Кабель витая пара FTP 2x2x0.5",
                "Кабель контрРасчетьный КВВГнг 4х0,75",
                "Кабель контрРасчетьный КВВГнг 10х2,5",

                "Кабель силовой ВВГнг 2х1,5",
                "Кабель ПУВ 1х2,5 Желто - зеленый",
                "Кабель ПУВ 1х6 Желто-зеленый",
                "Гофротруба диаметром 16 мм",
                "Держатель клипса гофр. Трубы 16 мм",

                "Гофротруба диаметром 32 мм",
                "Держатель клипса гофр. Трубы 32 мм",
                "ПНД 110 SDR 41 толщина стенки 2,7 мм L = 300 мм или его аналог",
                "Пластиковый кабель канал 100х60",
                "Гофротруба ПНД диаметром 32мм",

                "Шкаф ИБП в сборе",
                "Выключатель путевой ВП-15К - 21 Б - 2.3.1 - 54 У2.8(рычаг с рРасчетиком)",
                "Профиль К243УХЛ2,5; шт",
                "Профиль К241УХЛ2,5; шт",
                "Свая диаметр ствола 57 мм толщина 3 мм длина 2000 мм",

                "Песко-цементная смесь марки М100; кг",
                //sl.Add("Труба ГОСТ 3262-75 Нар. Диам 47 мм L=1500");
                "Труба ГОСТ 3262-75 Нар. Диам 47 мм L=3000",
                "Дюбель-гвоздь 6х40",
                "Саморез по металлу 4,2х30",

                "Шпилька М10 DIN 975; 1000 мм",
                "Шайба усиленная М10 DIN 9021; шт",
                "Гайка М10 DIN 934; шт",
                "Болт М10х50 DIN 934; шт",
                "Саморез кровельный по металлу 5,5х25 с усиленным сверлом и шестигранной головкой",

                "Фасадный анкер М10х80",
                "Болт М10х30 DIN 934; шт",
                "ГМЛ 25",
                "ГМЛ 35",
                "ГМЛ 50",

                "ГМЛ 70",
                "ГМЛ 95",
                "ТМЛ 25-8-7",
                "ТМЛ 35-10-9",
                "ТМЛ 50-10-11",

                "ТМЛ 70-10-13",
                "ТМЛ 95-10-15",
                "ТУТ 28/11; м",
                "ТУТ 30/15; м",
                "М10х30",

                "Гайка  М10",
                "Шайба  М10",
                "Бирка маркировочная треугРасчетьная  E-136 (55х58)",
                "Нейлоновый хомут 3,6х200",
                "Сжим ответвительный У-734М 16-35/16-25",

                "Кабель АВВГ 4х25"
            };


            return sl;

        }

        public Tuple<bool, string> AddStringToReport_MPOT(string folderName)
        {

            var varList = getVariablesAsStringListForReport_MPOT();
            var t1 = AddStringToReport(folderName, fileName_MPOT, title_MPOT, varList, "MPOT");

            return t1;

        }


        private List<string> getVariablesAsStringListForReport_PE()
        {
            decimal sum_calcOne_c93_c100 = calcOne.c93 + calcOne.c94 + calcOne.c95 + calcOne.c96 + calcOne.c97 + calcOne.c98 + calcOne.c99 + calcOne.c100;

            var sl = new List<string>
            {
                calcOne.c5.ToString(),
                calcOne.c6.ToString(),
                calcOne.c7.ToString(),
                calcOne.c8.ToString(),
                calcOne.c2.ToString(),

                calcOne.c4.ToString(),
                calcOne.c3.ToString(),
                calcOne.c93.ToString(),
                calcOne.c94.ToString(),
                calcOne.c95.ToString(),

                calcOne.c96.ToString(),
                calcOne.c97.ToString(),
                calcOne.c98.ToString(),
                calcOne.c99.ToString(),
                calcOne.c100.ToString(),

                calcOne.c101.ToString(),
                sum_calcOne_c93_c100.ToString(),
                "".ToString(),
                "".ToString()
            };

            return sl;

        }

        private List<string> getHeaderAsStringListForReport_PE()
        {
            var sl = new List<string>
            {
                "Тип распределительного устройства",
                "Номер ТП",
                "Подрядчик",
                "Филиал",
                "РЭС (полное наименование)",

                "Дата отключения",
                "Месяц",
                "Мастер 1 ",
                "ТТ Линейный",
                "3ф (AM550-TD1), шт.",

                "1ф (AM550-ED0), шт.",
                "Мастер 2",
                "ТТ линейный",
                "3ф (AM550-TD1), шт.",
                "1ф (AM550-ED0), шт.",

                "ШКАФ",
                "Количество счетчиков монтирумых в существующие шкафы",
                "Тип монтажа внутри Ру",
                "Тип монтажа снаружи Ру"
            };

            return sl;

        }

        public Tuple<bool, string> AddStringToReport_PE(string folderName)
        {

            var varList = getVariablesAsStringListForReport_PE();
            var t1 = AddStringToReport(folderName, fileName_PE, title_PE, varList, "PE");

            return t1;

        }


        private List<string> getVariablesAsStringListForReport_SZ()
        {
            var sl = new List<string>
            {
                calcOne.c7.ToString(),
                calcOne.c8.ToString(),
                calcOne.c2.ToString(),
                calcOne.c3.ToString(),
                calcOne.c6.ToString(),

                calcOne.c42.ToString(),
                calcOne.c44.ToString(),
                (calcOne.c50 + calcOne.c61 + calcOne.c68).ToString(),
                (calcOne.c51 + calcOne.c64 + calcOne.c69 + calcOne.c62).ToString(),
                (calcOne.c52 + calcOne.c63 + calcOne.c55 + calcOne.c70 + calcOne.c72).ToString(),

                (calcOne.c66 + calcOne.c53).ToString(),
                calcOne.c54.ToString(),
                calcOne.c55.ToString(),
                calcOne.c71.ToString(),
                calcOne.c74.ToString(),

                calcOne.c75.ToString(),
                calcOne.c76.ToString(),
                calcOne.c77.ToString(),
                calcOne.c78.ToString(),
                calcOne.c79.ToString(),

                calcOne.c80.ToString(),
                calcOne.c81.ToString(),
                calcOne.c82.ToString(),
                calcOne.c83.ToString(),
                calcOne.c84.ToString(),

                calcOne.c85.ToString(),
                calcOne.c86.ToString(),
                calcOne.c87.ToString(),
                calcOne.c88.ToString(),
                calcOne.c89.ToString(),

                calcOne.c90.ToString()
            };

            return sl;

        }

        private List<string> getHeaderAsStringListForReport_SZ()
        {
            var sl = new List<string>
            {
                "Подрядчик",
                "Филиал",
                "РЭС (полное наименование)",
                "Месяц",
                "Номер ТП",

                "Дюбель-гвоздь 6х40",
                "Саморез по металлу 4,2х30",
                "Шпилька М8 DIN 975; 1000 мм",
                "Шайба усиленная М8 DIN 9021; шт",
                "Гайка М8 DIN 934; шт",

                "Болт М8х50 DIN 934; шт",
                "Саморез кровельный по металлу 5,5х25 с усиленным сверлом и шестигранной головкой",
                "Фасадный анкер М10х80",
                "Болт М8х30 DIN 934; шт",
                "ГМЛ 25",

                "ГМЛ 35",
                "ГМЛ 50",
                "ГМЛ 70",
                "ГМЛ 95",
                "ТМЛ 25-8-7",

                "ТМЛ 35-10-9",
                "ТМЛ 50-10-11",
                "ТМЛ 70-10-13",
                "ТМЛ 95-10-15",
                "ТУТ 28/11; м",

                "ТУТ 30/15; м",
                "БРасчетт М10х30",
                "Гайка  М10",
                "Шайба  М10",
                "Бирка маркировочная треугРасчетьная  E-136 (55х58)",

                "Нейлоновый хомут 3,6х200"
            };

            return sl;

        }

        public Tuple<bool, string> AddStringToReport_SZ(string folderName)
        {

            var varList = getVariablesAsStringListForReport_SZ();
            var t1 = AddStringToReport(folderName, fileName_SZ, title_SZ, varList, "SZ");

            return t1;

        }



    }
}
