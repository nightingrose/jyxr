using Game.Core.Model;

namespace Game.Application;

public interface IApplicationRuntimeHost
{
    ValueTask<EquipmentInstanceInventoryEntry?> SelectRefinementEquipmentAsync(
        IReadOnlyList<EquipmentInstanceInventoryEntry> entries,
        CancellationToken cancellationToken);
}
