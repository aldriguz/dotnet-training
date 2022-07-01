using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Service
{
    public class ScopedService : IScopedService
    {
        private long Ticks { get; set; }

        public ScopedService()
        {
            this.Ticks = DateTime.Now.Ticks;
        }

        public long GetTimeTicks()
        {
            return this.Ticks;
        }
    }
}
