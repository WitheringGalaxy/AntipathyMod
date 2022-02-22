using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Armor.BronzeSet
{
	[AutoloadEquip(EquipType.Body)] //What type of armor to match
	public class BronzeArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Chainmail");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(18, 18);
			item.value = Item.sellPrice(silver: 45);
			item.rare = ItemRarityID.White;

			item.defense = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}