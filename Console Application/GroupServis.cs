using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class GroupServis : IGroupServis
    {
        private List<Group> _groups;
        public List<Group> Groups => _groups;

        Group[] IGroupServis.Groups => throw new NotImplementedException();

        public void AllStuList()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("groupno nayn");
                return;
            }
            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public string CreateNewGroup(string groupno,string fullname, Categories category)
        {
            if (groupno != groupno || fullname != fullname )
            {
                return "Please choose correct groupno or fullname";
            }
            Group group = new Group(groupno, fullname, category);
            _groups.Add(group);
            return group.No;
        }

        public string CreateStudent()
        {
            throw new NotImplementedException();
        }

        public void GroupEdit(string groupno, string newGroupNo)
        {
            Group existedgroup = null;
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == groupno.ToLower().Trim())
                {
                    existedgroup = group;
                }
            }
            if ( existedgroup == null)
            {
                Console.WriteLine("Please coose correct groupno");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.No.ToLower().Trim() == newGroupNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newGroupNo} already group exist");
                    return;
                }
            }
            existedgroup.No = newGroupNo.ToUpper();
        }
        
    }
}
