using System;

namespace BlazorPrototype
{
    public interface ISingletonService
    {
        Guid ServiceId { get; set; }
    }

    public interface IScopedService
    {
        Guid ServiceId { get; set; }
    }

    public interface ITransientService
    {
        Guid ServiceId { get; set; }
    }
}