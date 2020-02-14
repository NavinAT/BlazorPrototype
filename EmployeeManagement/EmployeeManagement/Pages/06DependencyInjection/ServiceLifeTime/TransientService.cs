using System;

namespace EmployeeManagement
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