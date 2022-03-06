using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Text.RegularExpressions;

namespace Console_Application
{
    class Program
    {
        public static int ChooseNum;

        static void Main(string[] args)
        {
            GroupServis groupServis = new GroupServis();
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
                Console.WriteLine("7. Exit");

                string Choose = Console.ReadLine();
                int ChooseNum;

                string strselection = Console.ReadLine();
                bool result = int.TryParse(strselection, out Selection);
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

                    default:
                        break;
                }                       
            } 
            while (true);                                  
        }

        public static void CreateStudent(ref GroupServis groupServis)
        {
            if (groupServis.Groups.Length > 0)
            {
                Console.WriteLine("Group Enter");
                foreach (Group group in groupServis.Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("Zzz");
                return;
            }

            Console.WriteLine("Enter Group name");
            string groupno = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(groupno))
            {
                Console.WriteLine("correct enter groupno");
                groupno = Console.ReadLine();
            }
            Console.WriteLine("Group type enter");
            foreach (var item in Enum.GetValues(typeof(OlGroupType)))
            {
                Console.WriteLine($"{(int)item} = {item}");
            }

            string grouptypestr = Console.ReadLine();
            int grouptypeNum;
            while (!int.TryParse(grouptypestr, out grouptypeNum) || grouptypeNum <1 || grouptypeNum >3)
            {
                Console.WriteLine("Correct choose enter");
                grouptypestr = Console.ReadLine();
            }
            OlGroupType groupType = (OlGroupType)grouptypeNum;
            Console.WriteLine("Group limit enter");
            string limitstr = Console.ReadLine();
            int limitNum;

            while (!int.TryParse(limitstr, out limitNum) || limitNum < 10 || grouptypeNum > 15)
            {
                Console.WriteLine("Correct choose enter");
                limitstr = Console.ReadLine();
            }

            groupServis.CreatenewGroup(groupno, groupType, limitNum);
            
        }        
        public static void AllStuListShow(ref GroupServis groupServis)
        {
            if (groupServis.Groups.Length >0 )
            {
                Console.WriteLine("Group LIst show");
                foreach (Group group in groupServis.Groups)
                {
                    Console.WriteLine(group);
                }
            }
        }

        public static void GroupStulis(ref GroupServis groupServis)
        {
            if (groupServis.Groups.Length > 0)
            {
                Console.WriteLine("Group List");
                foreach (Group group in groupServis.Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("Group list add");
                return;
            }
            Console.WriteLine("Stu Add GroupNo");
            string groupno = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(groupno))
            {
                Console.WriteLine("Correct GroupNo enter");
                groupno = Console.ReadLine();
            }
            Console.WriteLine("Student name and surname enter");
            string fullname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("Correct name and surname enter");
                fullname = Console.ReadLine();
            }

            Console.WriteLine("Student type choose");
            foreach (var item in Enum.GetValues(typeof(StudentType)))
            {
                Console.WriteLine($"{(int)item} = {item}");
            }

            string studenttypestr = Console.ReadLine();
            int studenttypeNum;

            while (!int.TryParse(studenttypestr, out studenttypeNum) || studenttypeNum < 1 || studenttypeNum > 2)
            {
                Console.WriteLine("Correct choose enter");
                studenttypestr = Console.ReadLine();
            }

            StudentType studentType1 = new StudentType();
            StudentType studentType = studentType1;

            Console.WriteLine("isonline y/n");
            string isonlinestr = Console.ReadLine();

            while (isonlinestr.ToLower() != "y" && isonlinestr.ToLower() != "n")
            {
                Console.WriteLine("Correct choose enter");
                isonlinestr = Console.ReadLine();
            }

            bool isonline = isonlinestr.ToLower() == "y";
            groupServis.GroupStulist(groupno, isonline, fullname);
        }

        public static void GroupEdit(ref GroupServis groupServis)
        {
            Console.WriteLine("Correct");
        }

        public static void GroupList(ref GroupServis groupServis)
        {
            Console.WriteLine("List");
        }

        public static void CreateNewGroup(ref GroupServis groupServis)
        {
            Console.WriteLine("New Group Enter");
        }
    }

    internal class StudentType
    {
    }
}
