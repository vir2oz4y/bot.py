using System;
using System.Collections.Generic;

namespace laba1_5sem
{
    class DataCheck
    {
        public string Errors { get; set; } = "";
        public bool TovarCheck(string tovarName)
        {
            if (tovarName.Trim().Equals(""))
            {
                Errors += "Название товара не должно быть пустым.";
                return false;
            }
            else
            {
                Errors = "";
                return true;
            }
        }

        public string TovarGet(string tovarName)
        {
            return FirstUp(tovarName);
        }

        public bool PostavshicCheck(string postName, string postCity)
        {
            if (postName.Trim().Equals("") || postCity.Trim().Equals(""))
            {
                Errors += "Название поставщика или название города не должно быть пустым.";
                return false;
            }
            else
            {
                Errors = "";
                return true;
            }
        }

        public List<string> PostavshickGet(string postName, string postCity)
        {
            
            List<string> postavshick=new List<string>();
            postavshick.Add(FirstUp(postName));
            postavshick.Add(FirstUp(postCity));
            return postavshick;

        }
        

        public bool PostCheck(string idt, string idp, string dpr, string sr, string v, string st, string dp)
        {
            if (!IntCheck(idt))
            {
                Errors += "Код товара не число";
                return false;
            }

            if (!IntCheck(idp))
            {
                Errors += "Код поставщика не число";
                return false;
            }

            if (!IntCheck(sr))
            {
                Errors += "Срок годности не число";
                return false;
            }

            if (!DecCheck(v))
            {
                Errors += "Объем не число";
                return false;
            }

            if (!DecCheck(st))
            {
                Errors += "Стоимость не число";
                return false;
            }

            return true;
        }

        private bool IntCheck(string number)
        {
            int numberReturn;
            return (Int32.TryParse(number, out numberReturn)||number=="null") ? true : false;
        }

        private bool DecCheck(string number)
        {
            decimal numberReturn;
            return (Decimal.TryParse(number, out numberReturn) || number == "null") ? true : false;
        }

        private string FirstUp(string word) {
            word = word.ToLower();
            word = char.ToUpper(word[0]) + word.Substring(1, word.Length-1);
            return word;
        }
    }
}
