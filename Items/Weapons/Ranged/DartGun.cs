using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Ranged
{
	public class DartGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dart Gun");
		}

		public override void SetDefaults()
        {
			item.Size = new Microsoft.Xna.Framework.Vector2(36, 20);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item99;

			item.value = Item.sellPrice(silver: 5); 
			item.rare = ItemRarityID.Blue;

			item.noMelee = true; 
			item.ranged = true; 
            item.damage = 7; 
			item.knockBack = 2;
			item.useTime = 24;
			item.useAnimation = 24; 
			item.autoReuse = true; 
  
			item.shoot = ProjectileID.PurificationPowder; 
			item.useAmmo = AmmoID.Dart; 
			item.shootSpeed = 9f; 
		
	}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddRecipeGroup("Wood", 5);
			recipe.AddIngredient(ModContent.ItemType<Materials.ContraptionParts>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}