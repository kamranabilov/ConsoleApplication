using Console_Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    static class MenuServis
    {
        public static GroupServis groupServis = new GroupServis();
       
        public static void CreateGroupMenu()
        {
            Console.WriteLine("Correct Choose Category");
            Console.WriteLine("1. Programming");
            Console.WriteLine("2. Design");
            Console.WriteLine("3.System_administration");           
            int category;
            string categstr = Console.ReadLine();
            bool resultCat = int.TryParse(categstr, out category);            
            if (resultCat)
            {
                switch (category)
                {
                    case (int) Categories.Programming:                                               
                        Console.WriteLine($"{category} Group Created");
                        break;
                    case (int)Categories.Design:                        
                        Console.WriteLine($"{category} Group Created");
                        break;
                    case (int)Categories.System_administration:                       
                        Console.WriteLine($"{category} Group Created");
                        break;
                    default:
                        Console.WriteLine("Correct Choose Group");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Correct Choose Category");
            }
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Choose Group No");
            string no = Console.ReadLine();
            Console.WriteLine("Choose New Group No");
            string newNo = Console.ReadLine();
            groupServis.EditGroup(no, newNo);
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Choose Group No");
            string no = Console.ReadLine();
            Console.WriteLine("Fullname enter add");
            string fullname = Console.ReadLine();
            Console.WriteLine("SType");
            bool sType;
            string sTypestr = Console.ReadLine();
            bool result = bool.TryParse(sTypestr, out sType);
            Console.WriteLine("isonlie");           
            bool isonline;
            string isonlinestr = Console.ReadLine();
            bool result1 = bool.TryParse(isonlinestr, out isonline);            
        }
        public static void GroupListShowMenu()
        {
            groupServis.GroupShow();            
        }
        public static void AllStuListShowMenu()
        {
            groupServis.AllStuListShow();
        }
        public static void GroupStulistMenu()
        {
            Console.WriteLine("Please choose Group No");
            string groupno = Console.ReadLine();
            groupServis.GroupStulist(groupno);
        }
    }
}
