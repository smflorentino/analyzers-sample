using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkLegacy
{
    class SomeObject
    {
        public SomeObject(int value)
        {
            IntField = value;
            StringField = value.ToString();
        }

        public string StringField { get; set; }

        public bool BoolField { get; set; }

        public int IntField { get; set; }

        public override string ToString()
        {
            return StringField;
        }
    }
}
