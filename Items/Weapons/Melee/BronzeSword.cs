using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Melee
{
	public class BronzeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Broadsword");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(50, 50); //Keep 50x50
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.useStyle = ItemUseStyleID.SwingThrow;

			item.value = Item.sellPrice(silver: 15, copper: 75);
			item.rare = ItemRarityID.White;

			item.melee = true;
			item.damage = 12;
			item.useTime = 20; //in frames per second ----v
			item.useAnimation = 20;
			item.knockBack = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}