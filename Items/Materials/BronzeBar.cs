using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Materials
{
	public class BronzeBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(30, 24);
			item.maxStack = 999;
			item.consumable = true;

			item.value = Item.sellPrice(silver: 10, copper: 50);
			item.rare = ItemRarityID.White;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.createTile = ModContent.TileType<Tiles.Blocks.BronzeBar>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperOre, 2);
			recipe.AddIngredient(ItemID.TinOre, 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BronzeOre>(), 2);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}