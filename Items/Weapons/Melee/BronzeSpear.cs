using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Melee
{
    public class BronzeSpear : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Spear");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(38, 38);
			item.useStyle = ItemUseStyleID.HoldingOut;

			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(silver: 17, copper: 50);

			item.damage = 13;
			item.useAnimation = 28;
			item.useTime = 28;
			item.knockBack = 5.5f;

			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<Projectiles.Melee.Spears.BronzeSpearProjectile>();
			item.shootSpeed = 3f;

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = false; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()
		}

        public override void AddRecipes()
        {
            base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Spear, 1);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}