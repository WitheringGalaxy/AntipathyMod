using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Tools
{
	public class CroissantPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Croissant.'");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(32, 32);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(silver: 15, copper: 50);
			item.rare = ItemRarityID.Orange;

			item.pick = 9999;
			item.useTime = 1; //Mining Speed
			item.useAnimation = 40; //Swing Speed
			item.tileBoost = 50;

			item.melee = true;
			item.damage = 150000;
			item.knockBack = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.Hay, 25);
			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}