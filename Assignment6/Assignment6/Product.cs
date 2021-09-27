using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    [Serializable]
    class Product
    {
        public int ProCode { get; set; }
        public string ProName { get; set; }
        //public string ProCategory { get; set; }

        [NonSerialized]
        private string ProCategory;
        public string Category
        {
            get
            {
                return ProCategory;
            }
            set
            {
                ProCategory = value;
            }
        }



    }
}


