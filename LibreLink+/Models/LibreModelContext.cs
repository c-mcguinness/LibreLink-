using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibreLink_.Models
{
    public class LibreModelContext : DbContext
    {
        public LibreModelContext() : base("LibreModelContext")
        {

        }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<LevelGuide> LevelGuides { get; set; }
    }
}