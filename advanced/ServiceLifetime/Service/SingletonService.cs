using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Service
{
    public class SingletonService : ISingletonService
    {
        private long Ticks { get; set; }

        public SingletonService()
        {
            this.Ticks = DateTime.Now.Ticks;
        }
        public long GetTimeTicks()
        {
            return this.Ticks;
        }
    }
}
