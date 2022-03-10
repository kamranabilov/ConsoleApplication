using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    interface IGroupServis
    {        
        public void CreateGroup(string groupno, bool isonline, bool categories);

        public void GroupShow();

        public void EditGroup(string groupno, string newGroupNo);

        public void GroupStulist(string groupno);

        public void AllStuListShow();

        public void CreateStudent(string groupno, string fullname, SType sType, string isOnline);        
    }
}
