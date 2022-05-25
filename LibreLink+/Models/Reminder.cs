using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibreLink_.Models
{
    public class Reminder
    {
        private ICollection<Diary> _diaries;
        public Reminder()
        {
            _diaries = new List<Diary>();
        }
        public int ReminderId { get; set; }
        public String ReminderTime { get; set; }
        public String ReminderMessage { get; set; }
        public virtual ICollection<Diary> Diaries
        {
            get { return _diaries; }
            set { _diaries = value; }
        }
    }
}