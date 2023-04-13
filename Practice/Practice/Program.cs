/*using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

public class Generic
{
    static void Ymat()
    {
        Console.WriteLine("This is Ymat Method");
    }
    public static string xmat()
    {
        Console.WriteLine("This is Xmat Method");
        string var = "Hello World";
        return var;
    }
   static  void Main()
    {
        String[] stringArr = new string[10];
        stringArr[1]= "Prince";
        stringArr[2] = "yadav";

        Ymat();
        xmat();

      
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "Beer");
        dict.Add(2, "Whisky");
        dict.Add(3, "Rum");
        dict.Add(4, "Soda");

        foreach (KeyValuePair<int, string> k in dict)
        {
            Console.WriteLine(k.Key + "  " + k.Value);
        }

        SortedList<int, string> slist = new SortedList<int, string>();
        slist.Add(1, "Beer");
        slist.Add(2, "Whisky");
        slist.Add(3, "Rum");
        slist.Add(4, "Soda");

        foreach (KeyValuePair<int, string> sl in slist)
        {
            Console.WriteLine(sl.Key + "  " + sl.Value);
        }
    }
}

*/