using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmartCalc
{
    static class Service
    {
        public static string getVersion()
        {
            return "SmartCalc v.1.04";
        }


        private static string getValidUTFStringFromByteArray(byte[] ba)
        {

            string s = System.Text.Encoding.UTF8.GetString(ba);

            //Удаляем BOM потому что Notepad его добавляет в файл при записи в UTF8
            if ((int)s[0] == 65279)
            {
                s = s.Remove(0, 1);
            }

            return s;

        }

        public static string[] getStringArrayFromJsonResources(byte[] ba)
        {

            string s = getValidUTFStringFromByteArray(ba);

            string[] m = JsonConvert.DeserializeObject<string[]>(s);
            return m;
        }


        public static Dictionary<string, int> getDictionaryFromJsonResources(byte[] ba)
        {

            string s = getValidUTFStringFromByteArray(ba);

            Dictionary<string, int> m = JsonConvert.DeserializeObject<Dictionary<string, int>>(s);
            return m;
        }
    }
}
