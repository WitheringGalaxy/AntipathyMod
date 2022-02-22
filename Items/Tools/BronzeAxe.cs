using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Tools
{
	public class BronzeAxe : ModItem
	{
		public override void SetStaticDefaults()
		{

		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(32, 28);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;

			item.value = Item.sellPrice(silver: 14);
			item.rare = ItemRarityID.White;

			item.axe = 11; //1/5 of display number.
			item.useTime = 18; //(Mining Speed) Same as Tungsten
			item.useAnimation = 26; //(Swing Speed)

			item.melee = true;
			item.damage = 7;
			item.knockBack = 4.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 9);
			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}