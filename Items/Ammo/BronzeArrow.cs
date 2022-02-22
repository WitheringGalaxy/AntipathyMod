using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Ammo
{
	public class BronzeArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increased armor penetration");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(8, 8);

			item.consumable = true; //You need to set the item consumable so that the ammo would automatically consumed
			item.maxStack = 999;

			item.value = Item.sellPrice(copper: 5);
			item.rare = ItemRarityID.White;

			item.ranged = true;
			item.noMelee = true;
			item.damage = 9;
			item.knockBack = 2.3f;

			item.shoot = ModContent.ProjectileType<Projectiles.Ammo.BronzeArrowProjectile>(); //The projectile shoot when your weapon using this 
			item.shootSpeed = 3f;
			item.ammo = AmmoID.Arrow; //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}