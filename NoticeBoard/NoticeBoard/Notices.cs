using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoard
{
    public class Notices
    {
        private int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateOf { get; set; }
        public int Importance { get; set; }
        public string Type { get; set; }
        public string PostedBy { get; set; }

        public Notices(int id, string title, string text, DateTime dposted, DateTime dof, int importance, string type, string pby)
        {
            this.ID = id;
            this.Title = title;
            this.Text = text;
            this.DatePosted = dposted;
            this.DateOf = dof;
            this.Importance = importance;
            this.Type = type;
            this.PostedBy = pby;
        }
    }
}
