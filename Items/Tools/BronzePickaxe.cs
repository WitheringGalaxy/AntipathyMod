using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Tools
{
	public class BronzePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Can Mine Meteorite");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(32, 32);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(silver: 15, copper: 50);
			item.rare = ItemRarityID.White;

			item.pick = 53;
			item.useTime = 18; //Mining Speed
			item.useAnimation = 20; //Swing Speed

			item.melee = true;
			item.damage = 6;
			item.knockBack = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 12);
			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}