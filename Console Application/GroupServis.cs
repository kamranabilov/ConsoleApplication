using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class GroupServis : IGroupServis
    {        

        //private List<Group> _groups = new List<Group>();
        //private string no;
        //public List<Group> Groups => _groups;
        private Group[] groups;
        public Group[] _groups;

        public Group[] Groups => throw new NotImplementedException();

        //public Group[] Groups => _groups;
        public GroupServis()
        {
            _groups = new Group[0];
            //_groups = new List<Group>();
        }                    
        public void AllStuListShow(string fullname, string groupno, bool isonline)
        {
            throw new NotImplementedException();
        }

        public void CreatenewGroup(string groupno, string fullname, bool isonline)
        {
            Array.Resize(ref _groups, _groups.Length + 1);
            _groups[_groups.Length - 1] = new Group(groupno, fullname, isonline);
        }
        //public string CreateNewGroup(string groupno,string fullname)
        //{
        //    string Group = null;
        //    if (Group == groupno )
        //    {
        //        return "Please choose correct groupno or fullname";
        //    }
        //    Group group = new Group();
        //    _groups.Add(group);
        //    return group.No;
        //}       
        public void CreateStudent(string groupno, string fullname, SType sType)
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
                Student student = new Student(groupno, fullname, sType);
                group.CreatedStudent(student);                
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
                        Console.WriteLine("no limit");
                    }

                    group.groupType = groupType;
                    group.No = group.No.Replace(groupno[0], char.ToUpper(groupType.ToString()[0]));

                    foreach (Student student in group.Students)
                    {
                        student.GroupNo = groupno;
                    }
                    return;
                }
               
            }            
            Console.WriteLine("Group no find");

            //if (group.No.ToLower().Trim() == groupno.ToLower().Trim())
            //{
            //    existedgroup = group;
            //}

            //if ( existedgroup == null)
            //{
            //    Console.WriteLine("Please coose correct groupno");
            //    return;
            //}
            //foreach (Group group in _groups)
            //{
            //    if (group.No.ToLower().Trim() == newGroupNo.ToLower().Trim())
            //    {
            //        Console.WriteLine($"{newGroupNo} already group exist");
            //        return;
            //    }
            //}
            //existedgroup.No = newGroupNo.ToUpper();
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

        public void GroupsListSHow(string AllGroupno, SType sType, int limit)
        {
            throw new NotImplementedException();
        }

        public void GroupStulist(string groupno, string newGroupNo)
        {
            throw new NotImplementedException();
        }

        public void CreateNewGroup(string groupno, string fullname, bool isonline)
        {
            throw new NotImplementedException();
        }

        public void GroupsListShow(string AllGroupno, int limit)
        {
            throw new NotImplementedException();
        }

        public void GroupEdit(string groupno, string newGroupNo)
        {
            throw new NotImplementedException();
        }

        public void GroupStulist()
        {
            throw new NotImplementedException();
        }

        void IGroupServis.CreateStudent(string groupno, string fullname, SType sType)
        {
            throw new NotImplementedException();
        }        
        //public string CreatenewGroup(string groupno, string fullname, bool isonline)
        //{
        //    Array.Resize(ref _groups, _groups.Length + 1);
        //    _groups[_groups.Length - 1] = new Group(groupno, fullname, isonline);
        //}
    }
}
