using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Text.RegularExpressions;

namespace Console_Application
{
    class Program
    {
        private static int ChooseNum;

        static void Main(string[] args)
        {
            GroupServis groupServis = new GroupServis();
            Console.WriteLine("Course Application");
            //int Selection;
            do
            {
                Console.WriteLine("1. CreateNewGroup");
                Console.WriteLine("2. GroupList");
                Console.WriteLine("3. GroupEdit");
                Console.WriteLine("4. GroupStuEdit");
                Console.WriteLine("5. AllStuList");
                Console.WriteLine("6. CreateStudent");
                Console.WriteLine("7. Exit");

                string Choose = Console.ReadLine();
                int ChooseNum;

                //string strselection = Console.ReadLine();
                //bool result = int.TryParse(strselection, out Selection);
                while (!int.TryParse(Choose, out ChooseNum) || ChooseNum < 1 || ChooseNum > 7)
                {
                    Console.WriteLine("correct choose");
                    Choose = Console.ReadLine();
                }
                Console.Clear();

                switch (ChooseNum)
                {
                    case 1:
                        CreateNewGroup(ref groupServis);
                        break;
                    case 2:
                        GroupList(ref groupServis);
                        break;
                    case 3:
                        GroupEdit(ref groupServis);
                        break;
                    case 4:
                        GroupStulis(ref groupServis);
                        break;
                    case 5:
                        AllStuListShow(ref groupServis);
                        break;
                    case 6:
                        CreateStudent(ref groupServis);
                        break;
                    case 7:
                        return;
                }

            } while (true);                                  
        }

        private static void CreateStudent(ref GroupServis groupServis)
        {
            Console.WriteLine("Group Enter:\n");
        }

        private static void AllStuListShow(ref GroupServis groupServis)
        {
            Console.WriteLine();
        }

        private static void GroupStulis(ref GroupServis groupServis)
        {
            Console.WriteLine();
        }

        private static void GroupEdit(ref GroupServis groupServis)
        {
            Console.WriteLine("Correct");
        }

        private static void GroupList(ref GroupServis groupServis)
        {
            Console.WriteLine("List");
        }

        private static void CreateNewGroup(ref GroupServis groupServis)
        {
            Console.WriteLine("New Group Enter");
        }
    }
}
