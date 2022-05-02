using Optsol.EventDriven.Components.Driven.Infra.Data;

namespace EventDriven.Arch.Driven.Infra.Data;

public class PersistentEvent : PersistentEvent<string>
{
    public Guid ModelId { get; private init; }
    public int ModelVersion { get; private init; }
    public DateTime When { get; private init; }
    public string? EventType { get; private init; }
    public string? Data { get; private init; }

    public static PersistentEvent Create(Guid id, int version, DateTime when, string eventType, string data) =>
        new PersistentEvent
        {
            ModelId = id,
            ModelVersion = version,
            When = when,
            EventType = eventType,
            Data = data
        };
}