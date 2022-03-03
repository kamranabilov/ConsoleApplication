using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    interface IGroupServis
    {
        public List<Group> Groups { get; }

        public string CreateGroup(string groupno, string fullname, Categories category);

        public void GroupList();

        public void GroupEdit(string groupno, string newGroupNo);

        public void GroupStulist();

        public void AllStuList();

        public string CreateStudent();
    }
}
