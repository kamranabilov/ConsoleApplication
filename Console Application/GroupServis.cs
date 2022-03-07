using DocuSign.eSign.Model;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class GroupServis : IGroupServis
    {
        //public Group[] _groups;
        //private List<Group> _groups = new List<Group>();
        //private string no;
        //public List<Group> Groups => _groups;
        private Group[] _groups;        
        public Group[] Groups => _groups;        
        public GroupServis()
        {
            _groups = new Group[0];
            //_groups = new List<Group>();
        }                            

        public void CreatenewGroup(string groupno, Group.GroupType groupType, int limit)
        {

            Array.Resize(ref _groups, _groups.Length + 1);
            _groups[_groups.Length - 1] = new Group(groupType, limit);
            return;

        }           
        public void CreateStudent(string groupno, string fullname, SType sType, bool isOnline)
        {            
            Group group = null;

            foreach (Group item in _groups)
            {
                if (item.No == groupno.Trim().ToUpper())
                {
                    group = item;
                }
            }
            if (group != null)
            {
                Student student = new Student(groupno, fullname, sType, isOnline);
                group.CreatedStudent(student);
                return;
            }
            Console.WriteLine("group no find");
            
        }

        public void GroupEdit(string groupno, Group.GroupType groupType, int limit)
        {                       

            foreach (Group group in _groups)
            {
                if (group.No == groupno.Trim().ToUpper())
                {
                    if (group.Students.Length <= limit)
                    {
                        group.Limit = limit;
                    }
                    else
                    {
                        Console.WriteLine("new limit no find");
                    }

                    group.groupType = groupType;
                    group.No = group.No.Replace(groupno[0], char.ToUpper(groupType.ToString()[0]));

                    foreach (Student student in group.Students)
                    {
                        student.Fullname = groupno;
                    }
                    return;
                }
               
            }            
            Console.WriteLine("GroupNo no find");            
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        public void AllStuListShow()
        {
            Console.WriteLine();
        }

        internal void CreatenewGroup(string groupno, OlGroupType groupType, int limitNum)
        {
            Console.WriteLine();
        }        

        public void GroupsListSHow(int limit)
        {
            string no = null;
            Group group = FindGroup(no);
            if (group == null)
            {
                Console.WriteLine("Please choose valid group no");
                return;
            }
            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }
        }        

        public void CreateNewGroup(string groupno, string fullname, bool isonline)
        {
            Console.WriteLine();
        }

        public void GroupsListShow(string AllGroupno, int limit)
        {
            Console.WriteLine();
        }

        public void GroupEdit(string groupno, string newGroupNo)
        {
            Console.WriteLine();
        }

        public void GroupStulist(string groupno)
        {
            Console.WriteLine();
        }

        void IGroupServis.CreateStudent(string groupno, string fullname, SType sType)
        {
            Console.WriteLine();
        }                
    }
}
