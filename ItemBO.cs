using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
   class ItemBo
    {

        SubCategory scobj1 = new SubCategory();

    public static List<SubCategory> ls = new List<SubCategory>();
    public static List<Item> litem = new List<Item>();

    public void AddItem(int iid, int cid, int scid, string iname, string cname, string scname, int stock, string idesc, string scdesc, string rem, int iprice)
    {

        SubCategory cat = new SubCategory(cid, cname, scid, scname, scdesc);
        Item item = new Item(iid, iname, idesc, stock, rem, iprice);
        ls.Add(cat);
        litem.Add(item);
        Console.WriteLine("Given details  are added..!! ");
    }
    public void DisplayProducts()
    {

        foreach (Categories caty in ls)
        {
            Console.WriteLine("\nCategory Id :" + caty.cid + "\nCategory Desc :" + caty.cname);
        }
        Console.WriteLine("Enter Cid for which you want to go to Subcategory");
        int ch = int.Parse(Console.ReadLine());

        foreach (SubCategory sub in ls)
        {
            if (sub.cid == ch)
            {

                Console.WriteLine("\nSubCategory Id : " + sub.scid + "\nSubCategory Name :" + sub.scname + "\nSubCategory Desc :" + sub.scdes);
            }
        }
        Console.WriteLine("Enter scid for which you want to go to Items");
        int ch1 = int.Parse(Console.ReadLine());

        foreach (SubCategory sub in ls)
        {
            foreach (Item it in litem)
            {
                if (sub.scid == ch1)
                {

                    Console.WriteLine("Item Id : " + it.item_id + "\nItem Name : " + it.iname + "\n Item Quantity : " + it.istock + "\nItem Description : " + it.irem + "\nItem Price : " + it.iprice);
                }
            }
        }
    }
    public void Search()
    {
        Console.WriteLine("1.Search By Item Number");
        Console.WriteLine("2.Search By Item Name");
        Console.WriteLine("Enter Your Choice");
        int ch = int.Parse(Console.ReadLine());
        String s = "";
        int f = 0;
        if (ch == 1)
        {
            Console.WriteLine("Enter Item NO that you want to search");
            int n = int.Parse(Console.ReadLine());
            foreach (Item i in litem)
            {
                if (i.item_id == n)
                {

                    s = "Item Id : " + i.item_id + "\nItem Name : " + i.iname + "\n Item Quantity : " + i.istock + "\nItem Description : " + i.irem + "\nItem Price : " + i.iprice;
                    break;
                }
                else
                    f = 1;
            }
        }
        else
        {
            Console.WriteLine("Enter Item Name that you want to search");
            String name = Console.ReadLine();

            foreach (Item i in litem)
            {
                if (i.iname == name)
                {
                    s = "Item Id :" + i.item_id + "\nItem Name : " + i.iname + "\n Item Quantity : " + i.istock + "\nItem Description : " + i.irem + "\nItem Price : " + i.iprice;
                    break;
                }
                else
                    f = 1;
            }
        }
        if (f == 1)
            Console.WriteLine("Item Not Found");

    }
}
}
