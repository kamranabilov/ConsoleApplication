using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Text.RegularExpressions;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupServis groupServis = new GroupServis();

            Console.WriteLine("Course Application");
            int Selection;
            do
            {
                Console.WriteLine("1. CreateGroup");
                Console.WriteLine("2. GroupList");
                Console.WriteLine("3. GroupEdit");
                Console.WriteLine("4. GroupStuShow");
                Console.WriteLine("5. AllStuList");
                Console.WriteLine("6. CreateStudent");
                Console.WriteLine("0. Exit");

                string strselection = Console.ReadLine();
                bool result = int.TryParse(strselection, out Selection);
                switch (Selection)
                {
                    case 1:
                        MenuServis.CreateGroupMenu();
                        break;
                    case 2:
                        MenuServis.EditGroupMenu();
                        break;
                    case 3:
                        MenuServis.GroupStulistMenu();
                        break;
                    case 4:
                        MenuServis.GroupsListSHowMenu();
                        break;
                    case 5:
                        MenuServis.AllStuListShowMenu();
                        break;
                    case 6:
                        MenuServis.CreateStudentMenu();
                        break;
                    default:
                        break;
                }

            } while (true);
        }
}   }
    
    


        

