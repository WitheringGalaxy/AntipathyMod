using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Placeables.Banners
{
	public class BronzeElementalBanner : ModItem
	{
		public override void SetStaticDefaults()
		{

		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(12, 28);
			item.value = Item.sellPrice(silver: 2);
			item.rare = ItemRarityID.Blue;

			item.consumable = true;
			item.maxStack = 99;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.placeStyle = 0;
			item.useTurn = true;
			item.autoReuse = true;

			item.createTile = ModContent.TileType<Tiles.Banners.EnemyBanner>();
		}

	}
}