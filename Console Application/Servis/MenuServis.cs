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
            Console.WriteLine("Choose Category group");
            Console.WriteLine("1. Programming");
            Console.WriteLine("2. Design");
            Console.WriteLine("3.System_administration");            
            int category;
            string categstr = Console.ReadLine();
            bool resultCat = int.TryParse(categstr, out category);
            //Categories category1 = Categories.Programming;
            if (resultCat)
            {
                switch (category)
                {
                    case (int) Categories.Programming:
                        //category1 = groupServis.p(groupno,isonline,category);
                        
                        Console.WriteLine($"{category} group created");
                        break;
                    case (int)Categories.Design:
                        //category1 = groupServis.CreateGroup(Categories.Design);
                        Console.WriteLine($"{category} group created");
                        break;
                    case (int)Categories.System_administrtion:
                        //category1 = groupServis.CreateGroup(Categories.System_administrtion);
                        Console.WriteLine($"{category} group created");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("correct valid category");
            }
        }

        public static void EditGroupMenu()
        {
            Console.WriteLine("choose group no");
            string no = Console.ReadLine();
            Console.WriteLine("choose new group no");
            string newNo = Console.ReadLine();
            groupServis.EditGroup(no, newNo);
        }

        public static void CreateStudentMenu()
        {
            Console.WriteLine("choose group no");
            string no = Console.ReadLine();
            Console.WriteLine("fullname add");
            string fullname = Console.ReadLine();
            Console.WriteLine("sType");
            bool sType;
            string sTypestr = Console.ReadLine();
            bool result = bool.TryParse(sTypestr, out sType);
            Console.WriteLine("isonlie");
            bool isonline;
            string isonlinestr = Console.ReadLine();
            bool result1 = bool.TryParse(isonlinestr, out isonline);
            //groupServis.CreateStudent(no, fullname, sType, isonline);
        }

        public static void GroupsListSHowMenu()
        {
            groupServis.GroupShow();            
        }

        public static void AllStuListShowMenu()
        {
            groupServis.AllStuListShow();
        }

        public static void GroupStulistMenu()
        {
            Console.WriteLine("plase group no");
            string groupno = Console.ReadLine();
            groupServis.GroupStulist(groupno);
        }
    }
}
