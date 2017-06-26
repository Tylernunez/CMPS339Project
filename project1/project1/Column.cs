using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Column
    {
        private string name;
        private Type type;
   
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public Type getType()
        {
            return this.type;
        }

        public void setType(Type type)
        {
            this.type = type;
        }
    }

 
}
