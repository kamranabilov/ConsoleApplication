using Microsoft.Office.Interop.Outlook;
using System;
using System.Text.RegularExpressions;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Course Application");
            int Selection;
            do
            {
                Console.WriteLine("1. CreateNewGroup");
                Console.WriteLine("2. GroupList");
                Console.WriteLine("3. GroupEdit");
                Console.WriteLine("4. GroupStuEdit");
                Console.WriteLine("5. AllStuList");
                Console.WriteLine("6. CreateStudent");
                Console.WriteLine("0. Exit");

                string strselection = Console.ReadLine();
                bool result = int.TryParse(strselection, out Selection);

            } while (true); 
            
                

                if ()
                {                    
                    foreach (Categories cat in Enum.GetValues(typeof(Categories)))
                    {
                        Console.WriteLine($"{(int)cat}. {cat}");
                    }
                    int category;
                    string CatStr = Console.ReadLine();
                    bool resultcat = int.TryParse(CatStr, out category);
                    if (resultcat)
                    {
                        string groupno = null;
                        string fullname = null;
                        switch (category)
                        {
                        case 1:
                                GroupServis groupServis = new GroupServis();
                                string no = groupServis.CreateNewGroup( groupno, fullname, Categories.Programming);
                            Console.WriteLine($"{groupno} group correct created");

                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Plase coohse correct category");
                    }
                    

                }
            
        }
    }
}
