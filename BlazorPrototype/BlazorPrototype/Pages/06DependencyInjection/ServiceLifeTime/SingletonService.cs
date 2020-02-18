using System;

namespace BlazorPrototype
{
    public class SingletonService : ISingletonService
    {
        public SingletonService()
        {
            ServiceId = Guid.NewGuid();
        }

        public Guid ServiceId { get; set; }
    }
}