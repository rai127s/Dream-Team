using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeBoard
{
    class Events
    {
        public int EventID { get; set; }
        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public string EventLocation { get; set; }
        public DateTime DatePosted { get; set; }
        public string EventHost { get; set; }
        public string EventType { get; set; }
        public int EventHostContact { get; set; }

        public Events(int EventID, string EventTitle, string EventText, string EventLocation, DateTime DatePosted, string EventHost, string EventType, int EventHostContact)
        {
            this.EventID = EventID;
            this.EventTitle = EventTitle;
            this.EventText = EventText;
            this.EventLocation = EventLocation;
            this.DatePosted = DatePosted;
            this.EventHost = EventHost;
            this.EventType = EventType;
            this.EventHostContact = EventHostContact;
        }

    }
}
