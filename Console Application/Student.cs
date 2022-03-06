using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string GroupNo { get; set; }
        public string Fullname { get; set; }
        public SType SType { get; set; }
        public bool IsOnline { get; set; }        
        public Student(string groupno, string fullname, bool isonline, SType sType)
        {
            GroupNo = groupno;
            Fullname = fullname.Trim().ToUpper();
            SType = sType;
            IsOnline = isonline;            
        }

        public Student(string groupno, string fullname, bool isonline)
        {
            GroupNo = groupno;
            Fullname = fullname;
            IsOnline = isonline;
        }

        public Student(string groupno, string fullname, SType sType)
        {
            GroupNo = groupno;
            Fullname = fullname;
            SType = sType;
        }

        public override string ToString()
        {
            string isGarantee = (int)SType == 1 ? "Garanati" : "NoGarantee";
            string isOnline = IsOnline ? "Online" : "Ofline";

            Console.WriteLine($"GroupNo: {GroupNo}/nFullname: {Fullname}/nGaranteetip: {isGarantee}/nSType: {SType}");
            return Fullname;
        }
    }
}
