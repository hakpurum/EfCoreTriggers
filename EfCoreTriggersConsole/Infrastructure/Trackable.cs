using EntityFrameworkCore.Triggers;
using System;

namespace EfCoreTriggersConsole.Infrastructure
{
    public abstract class Trackable
    {
        public DateTime Inserted { get; private set; }
        public DateTime Updated { get; private set; }

        static Trackable()
        {
            Triggers<Trackable>.Inserting += entry => entry.Entity.Inserted = entry.Entity.Updated = DateTime.Now;
            Triggers<Trackable>.Updating += entry => entry.Entity.Updated = DateTime.Now;
        }
    }
}
