using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string GroupNo;
        public string Fullname;

        public SType SType { get; }

        public bool IsOnline;
        public SType sType;

        public Student(string groupno, string fullname, bool isonline, SType sType)
        {
            GroupNo = groupno;
            Fullname = fullname.Trim().ToUpper();
            SType = sType;
            IsOnline = isonline;            
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
