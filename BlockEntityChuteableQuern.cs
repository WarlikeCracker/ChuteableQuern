using System.Reflection;
using Vintagestory.GameContent;

namespace ChuteableQuern;

public class BlockEntityChuteableQuern : BlockEntityQuern
{
	private static readonly FieldInfo inventoryField;
	private static readonly MethodInfo methodInfo;

	static BlockEntityChuteableQuern()
	{
		inventoryField = typeof(BlockEntityQuern).GetField("inventory", BindingFlags.NonPublic | BindingFlags.Instance);
		methodInfo = typeof(BlockEntityQuern).GetMethod("OnSlotModifid", BindingFlags.NonPublic | BindingFlags.Instance);
	}
	
	public BlockEntityChuteableQuern() : base()
	{
		var inventory = new InventoryChuteableQuern(null, null);
		inventoryField.SetValue(this, inventory);
		inventory.SlotModified += OnSlotModified;
	}
	
	private void OnSlotModified(int slotId) => methodInfo.Invoke(this, new object[] {slotId});
	
}