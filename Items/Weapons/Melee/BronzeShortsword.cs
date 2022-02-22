using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Melee
{
	public class BronzeShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Shortsword");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(37, 37); //keep 37x37
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.useStyle = ItemUseStyleID.Stabbing;

			item.value = Item.sellPrice(silver: 12, copper: 25);
			item.rare = ItemRarityID.White;

			item.melee = true;
			item.damage = 11;
			item.useTime = 11; //in frames per second ----v
			item.useAnimation = 11;
			item.knockBack = 5;
	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}