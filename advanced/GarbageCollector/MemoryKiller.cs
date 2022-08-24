using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class MemoryKiller
    {
        public MemoryKiller(Int32 id, DateTime createdDate, Int32 maxCapacity)
        {
            this.Id = id;
            this.CreatedDate = createdDate;
            this.MaxCapacity = maxCapacity;
        }

        public Int32 Id { get; set; }
        private DateTime _createdDate;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
        private Int32 _maxCapacity;

        public Int32 MaxCapacity
        {
            get { return _maxCapacity; }
            set
            {
                if (value < 0)
                    _maxCapacity = 0;
                else
                    _maxCapacity = value;
            }
        }

    }
}
