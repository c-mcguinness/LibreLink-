using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibreLink_.Models
{
    public class LevelGuide
    {
        private ICollection<Diary> _diaries;
        public LevelGuide()
        {
            _diaries = new List<Diary>();
        }
        public int LevelGuideId { get; set; }
        public String LevelGuideColour { get; set; }
        public String LevelGuideBounder { get; set; }
        public virtual ICollection<Diary> Diaries
        {
            get { return _diaries; }
            set { _diaries = value; }
        }
    }
}