using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToDoList
{
    class Deal
    {
        private string content;
        private int data;

        public string Content
        {
            get { return content; }
        }
        public int Data
        {
            get { return data; }
        }
        public Deal(string content, int data)
        {
            this.content = content;
            this.data = data;
        }
        //public Deal(string c, int d)
        //{
        //    content = c;
        //    data = d;
        //}

    }
}
