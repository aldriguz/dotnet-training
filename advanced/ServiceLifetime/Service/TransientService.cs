using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Service
{
    public class TransientService : ITransientService
    {
        private long Ticks { get; set; }

        public TransientService()
        {
            this.Ticks = DateTime.Now.Ticks;
        }
        
        public long GetTimeTicks()
        {
            return this.Ticks;
        }
    }
}
