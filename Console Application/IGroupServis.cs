using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    interface IGroupServis
    {
        Group[] Groups { get; }
        public List<Group> Group { get; }

        public void CreateNewGroup(string groupno, string fullname, Categories category);

        public void GroupsListSHow(string AllGroupno, SType sType, int limit);

        public void GroupEdit(string groupno, string newGroupNo, int limit);

        public void GroupStulist(string groupno, string newGroupNo);

        public void AllStuList(string fullname, string groupno, bool isonline);

        public void CreateStudent(string groupno, string fullanem, SType sType, bool isonline);
    }
}
