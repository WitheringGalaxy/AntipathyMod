using AntipathyMod.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Ammo
{
	public class Dart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Pointy'");
		}

		public override void SetDefaults()
        {			
			item.Size = new Microsoft.Xna.Framework.Vector2(14, 24);
			
			item.consumable = true;
			item.maxStack = 999;
			
			item.value = 0;
			item.rare = ItemRarityID.White;
			
			item.ranged = true;
			item.noMelee = true;
			item.damage = 5;
			item.knockBack = 1.5f;
			
			item.shoot = ModContent.ProjectileType<Projectiles.Ammo.DartProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 2f;                  //The speed of the projectile
			item.ammo = AmmoID.Dart;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}