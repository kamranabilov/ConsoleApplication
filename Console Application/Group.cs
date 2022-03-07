using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {                
        public string No;
        public GroupType groupType { get; set; }
        public int Limit { get; set; }
        public Student[] Students;
        private static int _count = 100;
        public GroupType GetGroupType()
        {
            return groupType;
        }
        public void SetGroupType(GroupType value)
        {
            groupType = value;
        }                
        public Group( GroupType groupType, int limit)
        {
            Students = new Student[0];
            SetGroupType(groupType);
            Limit = limit;
            _count++;
            No = $"{char.ToUpper(groupType.ToString()[0])}{_count}";                                             
        }
        public Group(string groupno)
        {
        }       
        public void CreatedStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                return;
            }
            else
            {
                Console.WriteLine("no pleace group");
            }
        }
        public override string ToString()
        {
            return $"GroupNo: {No}/nGroupType: {GetGroupType()}/nLimit: {Limit}";
        }
        public class GroupType
        {
        }
    }
}
