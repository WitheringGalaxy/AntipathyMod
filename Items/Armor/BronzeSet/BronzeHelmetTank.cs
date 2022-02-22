using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Armor.BronzeSet
{
	[AutoloadEquip(EquipType.Head)] //What type of armor to match
	public class BronzeHelmetTank : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Faceguard");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(18, 18);
			item.value = Item.sellPrice(silver: 27);
			item.rare = ItemRarityID.White;

			item.defense = 5;
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ModContent.ItemType<BronzeArmor>() && legs.type == ModContent.ItemType<BronzeLegs>();
        }

        public override void UpdateArmorSet(Player player)
		{
			player.setBonus = " 2% increased damage reduction";
			player.endurance += 0.02f;
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