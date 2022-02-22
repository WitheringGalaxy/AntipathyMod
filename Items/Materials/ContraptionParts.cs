using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Materials
{
	public class ContraptionParts : ModItem
	{
		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(20, 20);
			item.maxStack = 999;
			item.value = Item.sellPrice(silver: 15);
			item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			//Dart
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DartTrap, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			//Geyser
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GeyserTrap, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			//Detonator
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Detonator, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}