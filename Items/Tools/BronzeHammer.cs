using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Tools
{
	public class BronzeHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(32, 32);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;


			item.value = Item.sellPrice(silver: 14);
			item.rare = ItemRarityID.White;

			item.hammer = 53;
			item.useTime = 24; //(Mining Speed)
			item.useAnimation = 28; //(Swing Speed)

			item.melee = true;
			item.damage = 9;
			item.knockBack = 5.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 10);
			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}