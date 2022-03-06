using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    interface IGroupServis
    {
        Group[] Groups { get; }
        //public List<Group> Group { get; }

        public void CreateNewGroup(string groupno, string fullname, bool isonline);

        public void GroupsListShow(string AllGroupno, int limit);

        public void GroupEdit(string groupno, string newGroupNo);

        public void GroupStulist();

        public void AllStuListShow();

        public void CreateStudent(string groupno, string fullname, SType sType);
        
    }
}
