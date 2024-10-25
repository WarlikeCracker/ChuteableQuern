using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo("Chuteable Quern", "chuteablequern",
	Authors = new [] {"WarlikeCracker"},
	Description = "Allows you to use chutes to retrieve items from the querns",
	Version = "1.0.0",
	Side = "Server",
	RequiredOnClient = false)]

namespace ChuteableQuern;

public class ChuteableQuernModSystem : ModSystem
{
	public override void StartServerSide(ICoreServerAPI api)
	{
		api.RegisterBlockEntityClass("Quern", typeof(BlockEntityChuteableQuern));
	}

	public override bool ShouldLoad(EnumAppSide forSide) => forSide == EnumAppSide.Server;
}