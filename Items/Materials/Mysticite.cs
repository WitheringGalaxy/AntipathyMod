using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Materials
{
	public class Mysticite : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Contains powerful forces within'");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(16, 16);
			item.maxStack = 999;
			item.consumable = true;

			item.value = Item.sellPrice(silver: 15);
			item.rare = ItemRarityID.Orange;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.createTile = ModContent.TileType<Tiles.Ore.Mysticite>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.MagicDust>(), 4);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}
