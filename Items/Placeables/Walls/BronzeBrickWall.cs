using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Placeables.Walls
{
    public class BronzeBrickWall : ModItem
    {
		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(24, 24);
			item.maxStack = 999;
			item.consumable = true;

			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(copper: 0);
			item.rare = ItemRarityID.White;

			item.createWall = ModContent.WallType<Tiles.Walls.BronzeBrickWall>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Blocks.BronzeBrick>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ModContent.ItemType<Blocks.BronzeBrick>(), 1);
			recipe.AddRecipe();
		}
    }
}
