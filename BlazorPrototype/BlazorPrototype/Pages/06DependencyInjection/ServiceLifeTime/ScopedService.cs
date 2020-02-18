using System;

namespace BlazorPrototype
{
    public class ScopedService : IScopedService
    {
        public ScopedService()
        {
            ServiceId = Guid.NewGuid();
        }

        public Guid ServiceId { get; set; }
    }
}