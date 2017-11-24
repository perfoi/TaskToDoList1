using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToDoList
{
    class DealsMassive
    {
        private int count = 0;
        public Deal[] deals = new Deal[0];

        public int Count
        {
            get { return count; }
        }

        public bool IsEmpty
        {
            get { return (count == 0); }
        }

        public void PutDeal(string value, int data)
        {
            if (value == null)
                throw new Exception("Событие не содержит информации");
            if ((data>31)||(data<=0))
                throw new Exception("Неверный формат даты");
            Array.Resize(ref deals, ++count);
            deals[count - 1] = new Deal(value,data);
        }
        public string Printer()
        {
            int c = 1;
            string result = null;
            for (int i=0;i<deals.Length;i++)
            {
                result = result + c.ToString()+". "+ deals[i].Content + " : " + deals[i].Data.ToString() + "\r\n";
                c++;
            }
            return result;
        }
        public string GetByData(int data)
        {
            if ((data > 31) || (data <= 0))
                throw new Exception("Неверный формат даты");
            int c = 1;
            string result = null;
            for (int i=0;i<deals.Length;i++)
            {
                if(deals[i].Data.Equals(data))
                {
                    result += c.ToString()+". "+deals[i].Content + "\r\n";
                    c++;
                }
            }
            return result;
        }
    }
}
