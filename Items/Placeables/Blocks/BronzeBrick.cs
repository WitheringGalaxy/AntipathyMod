using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Placeables.Blocks
{
	public class BronzeBrick : ModItem
	{
		public override void SetStaticDefaults()
		{

		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(16, 16);
			item.maxStack = 999;
			item.value = Item.sellPrice(copper: 0);
			item.rare = ItemRarityID.White;
			item.consumable = true;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.createTile = ModContent.TileType<Tiles.Blocks.BronzeBrick>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeOre>(), 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}