using System;

namespace BlazorPrototype
{
    public class TransientService : ITransientService
    {
        public TransientService()
        {
            ServiceId = Guid.NewGuid();
        }

        public Guid ServiceId { get; set; }
    }
}