using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;
using Console_Application.Enum;


namespace Console_Application
{
    class Group
    {
        public static int count = 1;
        public string No;
        public Enum.Categories Category;
        public bool IsOnline;
        public int Limit = 0;
        public List<Student> Students;
        public Group()
        {
        }
        public Group(Enum.Categories category, bool isonline)
        {
            IsOnline = isonline;
            count++;
            Students = new List<Student>();  
            
            switch (category)
            {
                case Enum.Categories.Programming:
                    No = $"P-{count}";
                    break;
                case Enum.Categories.Design:
                    No = $"D-{count}";
                    break;
                case Enum.Categories.System_administration:
                    No = $"S-{count}";
                    break;
                default:
                    break;
            }
                                    
        }
        public override string ToString()
        {
            //string status = IsOnline ? "isonline" : "Offline";
            return $"Group No: {No}/nCategories: {Category}";
        }

        // No = $"{Categories.Substring(0, 1).ToUpper()}{_count}";
        //No = no;
        //GroupType = grouptype;
        //Limit = limit;
        //IsOnline = isonline;
        //count++;
        //No = $"{char.ToUpper(groupType.ToString()[0])}{_count}";

        //public void CreatedGroup()
        //{
        //}
        //public Group(string groupno)
        //{
        //}
        //public Group(OlGroupType groupType1, int limitNum)
        //{
        //}
        //public void CreatedStudent(Student student)
        //{
        //    if (Students.Length < Limit)
        //    {
        //        Array.Resize(ref Students, Students.Length + 1);
        //        Students[Students.Length - 1] = student;
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("no pleace group");
        //    }
        //}        
    }
}
