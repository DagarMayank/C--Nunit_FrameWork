using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Practice.NewFolder
{
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
        public static void Main(string[] args)
        {
            Ymat();
            xmat();
            Console.WriteLine(xmat());
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
    interface GFG1
    {
        void languages();
    }
    class Geeks1 : GFG1
    {

        // Providing the implementation
        // of languages() method
        public void languages()
        {

            // Creating ArrayList
            ArrayList My_list = new ArrayList();

            // Adding elements in the
            // My_list ArrayList
            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");

            Console.WriteLine("Languages provided by GeeksforGeeks:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    interface GFG2
    {
        void courses();
    }
    // Parent class 2
    class Geeks2 : GFG2
    {

        // Providing the implementation
        // of courses() method
        public void courses()
        {

            // Creating ArrayList
            ArrayList My_list = new ArrayList();

            // Adding elements in the
            // My_list ArrayList
            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("Geeks Classes DSA");
            My_list.Add("Fork Java");

            Console.WriteLine("\nCourses provided by GeeksforGeeks:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    // Child class
    class GeeksforGeeks : GFG1, GFG2
    {

        // Creating objects of Geeks1 and Geeks2 class
        Geeks1 obj1 = new Geeks1();
        Geeks2 obj2 = new Geeks2();

        public void languages()
        {
            obj1.languages();
        }

        public void courses()
        {
            obj2.courses();
        }
    }
    public class GFGFG
    {

        // Main method
        static public void Main()
        {

            // Creating object of GeeksforGeeks class
            GeeksforGeeks obj = new GeeksforGeeks();
            obj.languages();
            obj.courses();
        }
    }
}