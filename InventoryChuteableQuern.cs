using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace ChuteableQuern;

public class InventoryChuteableQuern : InventoryQuern
{
	public InventoryChuteableQuern(string inventoryID, ICoreAPI api) : base(inventoryID, api) {}
	public InventoryChuteableQuern(string className, string instanceID, ICoreAPI api) : base(className, instanceID, api) {}

	public override ItemSlot GetAutoPullFromSlot(BlockFacing atBlockFace) => Slots[1];
}