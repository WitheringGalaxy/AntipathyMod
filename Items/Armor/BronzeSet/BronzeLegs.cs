using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Armor.BronzeSet
{
	[AutoloadEquip(EquipType.Legs)] //What type of armor to match
	public class BronzeLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Greaves");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(18, 18);
			item.value = Item.sellPrice(silver: 35);
			item.rare = ItemRarityID.White;

			item.defense = 3;
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