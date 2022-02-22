using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Magic
{
	public class BronzeStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Twin Staff");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(20, 20);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;

			item.value = Item.sellPrice(silver: 50);
			item.rare = ItemRarityID.Blue;

			item.shoot = ProjectileID.AmethystBolt;
			item.shootSpeed = 8f; //Projectile speed

			item.magic = true;
			item.damage = 17;
			item.mana = 10;
			item.useTime = 36;
			item.useAnimation = 36;
			item.knockBack = 4;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
				Vector2 preturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
				Projectile.NewProjectile(position.X, position.Y, preturbedSpeed.X, preturbedSpeed.Y, ProjectileID.TopazBolt, damage, knockBack, player.whoAmI);
				return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 10);
			recipe.AddIngredient(ItemID.Amethyst, 4);
			recipe.AddIngredient(ItemID.Topaz, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}