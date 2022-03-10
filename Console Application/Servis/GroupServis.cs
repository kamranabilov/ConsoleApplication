using DocuSign.eSign.Model;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class GroupServis : IGroupServis
    {
        private List<Group> _group = new List<Group>();
        public List<Group> Groups => _group;
        private List<Student> _student = new List<Student>();
        public List<Student> Students => _student;
        
        public void CreateGroup(string groupno, bool isonline, bool categories)
        {
            Enum.Categories category = default;
            Group group = new Group(category, isonline);
            Groups.Add(group);            
        }

        public void EditGroup(string groupno, string newGroupNo)
        {
            Group existedgroup = FindGroup(groupno);

            if (existedgroup == null)
            {
                Console.WriteLine("choose correct group no");
            }
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == newGroupNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newGroupNo} group already exist");
                    return;
                }

            }
            ////////existedgroup.No = newGroupNo.ToUpper();
            Console.WriteLine($"{groupno} group change to {newGroupNo}");
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

        public void CreateStudent(string groupno, string fullname, SType sType, string isOnline)
        {
            Student student1 = new Student(fullname,sType, isOnline);
            Students.Add(student1); ;
            foreach (Group item in Groups)
            {
                if (item.No == groupno.Trim().ToUpper())
                {
                    item.Students.Add(student1);
                }
                else
                {
                    Console.WriteLine("no group");
                }
            }            
            Console.WriteLine("group no find");
        }  
        
        public void GroupShow()
        {
            foreach (Group group in Groups)
            {
                Console.WriteLine(group);
            }
        } 
        
        public void AllStuListShow()
        {
            foreach (Group group in Groups)
            {
                Console.WriteLine(group.Students);
            }
        }
        public void GroupStulist(string groupno)
        {
            Group group = Groups.Find(x => x.No.ToLower().Trim() == groupno.ToLower().Trim());
            if (group != null)
            {
                Console.WriteLine(group.Students);
            }
           
            
        }
        //void IGroupServis.CreateStudent(string groupno, string fullname, SType sType)
        //{
        //    Group group = null;

        //    foreach (Group item in _groups)
        //    {
        //        if (item.No == groupno.Trim().ToUpper())
        //        {
        //            group = item;
        //        }
        //    }
        //    if (group != null)
        //    {
        //        bool isOnline = false;
        //        Student student = new Student(groupno, fullname, sType, isOnline);
        //        group.CreatedStudent(student);
        //        return;
        //    }
        //    Console.WriteLine("group no find");
        //}
        //public void CreateGroup(string groupno, bool isonline, int limit)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AllStuListShow(int limit)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
