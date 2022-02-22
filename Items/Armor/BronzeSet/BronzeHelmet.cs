using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Armor.BronzeSet
{
	[AutoloadEquip(EquipType.Head)] //What type of armor to match
	public class BronzeHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Helmet");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(18, 18);
			item.value = Item.sellPrice(silver: 27);
			item.rare = ItemRarityID.White;

			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BronzeArmor>() && legs.type == ModContent.ItemType<BronzeLegs>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = " 5% increased damage";
			player.allDamageMult += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}