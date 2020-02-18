using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepartmentStore
{
    static void Main()
    {
        StoreItem si = new StoreItem();

        si.CreateItem();
        si.Describe();

        System.Console.ReadKey();
    }
}