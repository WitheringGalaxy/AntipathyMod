using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Ranged
{
	public class BronzeBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Bow");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(16, 32);
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.useStyle = ItemUseStyleID.HoldingOut;

			item.value = Item.sellPrice(silver: 12, copper: 25);
			item.rare = ItemRarityID.White;

			item.ranged = true;
			item.noMelee = true;
			item.damage = 10;
			item.useTime = 26; //in frames per second ----v
			item.useAnimation = 26;
			item.knockBack = 0;

			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 6.6f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}