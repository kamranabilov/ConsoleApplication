using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {        
        public static int count = 100;
        public string No;  
        public GroupType groupType { get; set; }
        public int Limit { get; set; }
        public Student[] Students;
        


        public Group(GroupType groupType, int limit)
        {
            Students = new Student[0];
            GroupType = groupType;
            Limit = limit;
            count++;
            No = $"{char.ToUpper(groupType.ToString()[0])}{count}";
                                             
        }
        public void CreatedStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("no group");
            }
        }
        public override string ToString()
        {
            return $"GroupNo": { }
        }


    }
}
