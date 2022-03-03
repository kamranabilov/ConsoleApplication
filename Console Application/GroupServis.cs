using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class GroupServis : IGroupServis
    {
        private List<Group> _groups;
        public List<Group> Groups => _groups;

        public void AllStuList()
        {
            throw new NotImplementedException();
        }

        public string CreateGroup(string groupno,string fullname, Categories category)
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
        }

        public void GroupList()
        {
            throw new NotImplementedException();
        }

        public void GroupStulist()
        {
            throw new NotImplementedException();
        }
    }
}
