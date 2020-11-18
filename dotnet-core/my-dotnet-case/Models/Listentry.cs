using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_dotnet_case.Models
{
    public class Listentry //: IEquatable<Listentry>
    {
        private String Name { get; set; }
        private int Price { get; set; }

        public Listentry(String inputName, int inputPrice)
        {
            Name = inputName;
            Price = inputPrice;
        }
    }
}
