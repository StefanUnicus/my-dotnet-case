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
        //Built a list to take the role of database, storing entries 

        bool filled = false; //quick solution to make sure the list is seeded the first time the service is called
        //Should be replaced with a seeding function triggered in initialization

        public List<Listentry> GetListentries()
        {
            if (filled == false)
            {
                FillList();
                filled = true;
            }

            return falsedatabase;
        }

        public string AddEntry(Listentry listentry)
        {
            if (filled == false) {
                FillList();
                filled = true;
            }

            falsedatabase.Add(listentry);

            return listentry.ToString() + " has been added!";
        }

        public void FillList() //throws in some data into the fake database as if it was pre-existing
        {
            falsedatabase.Add(new Listentry("MC", 50000));
            falsedatabase.Add(new Listentry("Car", 150000));
            falsedatabase.Add(new Listentry("Van", 250000));
            falsedatabase.Add(new Listentry("Truck", 500000));
        }
    }
}
