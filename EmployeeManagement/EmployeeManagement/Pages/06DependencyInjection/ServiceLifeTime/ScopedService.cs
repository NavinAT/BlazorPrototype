using System;

namespace EmployeeManagement
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