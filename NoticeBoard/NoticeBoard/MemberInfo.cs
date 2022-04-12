using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoard
{
    public class MemberInfo
    {
        private int memberID {get;set;}
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public DateTime DateJoined { get; set; }
        public int age { get; set; }
        public MemberInfo(int memberID, string Fname, string Sname, string email, int phone, string address, DateTime DateJoined, int age)
        {
            this.memberID = memberID;
            this.Fname = Fname;
            this.Sname = Sname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.DateJoined = DateJoined;
            this.age = age;
        }
    }
}
