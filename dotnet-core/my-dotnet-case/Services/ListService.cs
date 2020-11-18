using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_dotnet_case.Models;

namespace my_dotnet_case.Services
{
    public class ListService
    {
        List<Listentry> falsedatabase = new List<Listentry>();

        bool filled = false;

        public List<Listentry> GetListentries()
        {
            if (filled == false)
            {
                FillList();
                filled = true;
            }

            return falsedatabase;
        }

        public void AddEntry(Listentry listentry)
        {
            if (filled == false) {
                FillList();
                filled = true;
            }

            falsedatabase.Add(listentry);
        }

        public void FillList()
        {
            falsedatabase.Add(new Listentry("MC", 50000));
            falsedatabase.Add(new Listentry("Car", 150000));
            falsedatabase.Add(new Listentry("Van", 250000));
            falsedatabase.Add(new Listentry("Truck", 500000));
        }
    }
}
