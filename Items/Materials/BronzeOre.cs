using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Materials
{
	public class BronzeOre : ModItem
	{
		public override void SetStaticDefaults()
		{

		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(16, 16);
			item.maxStack = 999;
			item.consumable = true;

			item.value = Item.sellPrice(silver: 2, copper: 75);
			item.rare = ItemRarityID.White;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.createTile = ModContent.TileType<Tiles.Ore.BronzeOre>();
		}

		public override void AddRecipes()
		{

		}

	}
}
