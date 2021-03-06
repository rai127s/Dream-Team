using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoard
{
    public class MemberInfo
    {
        public static List<MemberInfo> MemberList = new List<MemberInfo>();


        public int memberID {get;set;}
        public string username { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public MemberInfo(int memberID, string userName, string Fname, string Sname, string email, int phone, string address, int age)
        {
            this.memberID = memberID;
            this.username = userName;
            this.Fname = Fname;
            this.Sname = Sname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.age = age;
        }

        public MemberInfo() { }


        public static void AddMemberToList(MemberInfo member)
        {
            MemberList.Add(member);
        }
        
    }
}
