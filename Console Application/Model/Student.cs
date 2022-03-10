using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string Fullname;     
        public bool SType;
        public bool isOnline;
        public string GroupNo;   

        public Student(string fullname, bool sType, string groupno)
        {
            Fullname = fullname;
            SType = sType;
            GroupNo = groupno;                       
        }

        public Student(string fullname, bool sType, bool isOnline)
        {
            Fullname = fullname;
            SType = sType;
            IsOnline = isOnline;
        }

        public Student(string fullname, SType sType, string isOnline1)
        {
            Fullname = fullname;
        }

        public Student(string groupno, string fullname, SType sType, bool isOnline)
        {
            GroupNo = groupno;
            Fullname = fullname;
        }

        public Student(string groupno, string fullname, bool sType, bool isOnline)
        {
            GroupNo = groupno;
            Fullname = fullname;
            SType = sType;
            IsOnline = isOnline;
        }

        public bool IsOnline { get; }

        public override string ToString()
        {
            string status = SType ? "Garanati" : "No Garantee";            
            return $"Fullname: {Fullname}/nSType: {SType}/nGroup No: {GroupNo}/nStatus: {status}";
        }
    }
}
