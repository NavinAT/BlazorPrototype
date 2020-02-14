using System;

namespace EmployeeManagement
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