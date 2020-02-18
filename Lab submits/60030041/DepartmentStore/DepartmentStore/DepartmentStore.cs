
public class DepartmentStore
{
    static void Main()
    {
        StoreItem si = new StoreItem();

        si.itemNumber = 12081254;
        si.itemName = "Wireless Mouse Logitec 1542";
        si.size = "4";
        si.unitPrice = 1250;

        System.Console.WriteLine("Department Store");
        System.Console.Write("Item #:     ");
        System.Console.WriteLine(si.itemNumber);
        System.Console.Write("Item Name:  ");
        System.Console.WriteLine(si.itemName);
        System.Console.Write("Item Size:  ");
        System.Console.WriteLine(si.size);
        System.Console.Write("Unit Price: ");
        System.Console.WriteLine(si.unitPrice);

        System.Console.ReadKey();
    }
}