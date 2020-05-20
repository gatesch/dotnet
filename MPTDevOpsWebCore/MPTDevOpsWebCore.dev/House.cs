using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace MPTDevOpsWebCore
{
    public class House
    { 
        public House()
        {
            HCode = string.Empty;
            string a = string.Empty;
        }

        private string m_code;
        private string m_villagename;
        private int m_price;

        public int Price
        {
            get
            { return m_price; }
            set
            {
                if (value < 0)
                {
                    m_price = 0;
                }
                else
                {
                    m_price = value;
                }
            }
        }


        public string HCode
        {
            get { return m_code; }
            set { m_code = value; } //
        }

        [ExcludeFromCodeCoverage]
        public string Location { get; set; }
        public string VillageName
        {
            get { return m_villagename; }
            set { m_villagename = value; }
        }

    }
}
