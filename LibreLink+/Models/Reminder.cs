using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibreLink_.Models
{
    public class Reminder
    {
        private ICollection<LevelGuide> _levelguides;

        public Reminder()
        {
            _levelguides = new List<LevelGuide>();
        }
        public int DiaryID { get; set; }
        public String DiaryDate { get; set; }
        public int DiaryLevel { get; set; }
        public virtual ICollection<LevelGuide> LevelGuides
        {
            get { return _levelguides; }
            set { _levelguides = value; }
        }
    }
}