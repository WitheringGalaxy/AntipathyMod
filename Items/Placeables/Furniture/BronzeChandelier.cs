using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Placeables.Furniture
{
    public class BronzeChandelier: ModItem
    {
		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(20, 20);
			item.maxStack = 999;
			item.consumable = true;

			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.autoReuse = true;
			item.placeStyle = 0;

			item.createTile = ModContent.TileType<Tiles.Furniture.Chandelier>();

			item.value = Item.sellPrice(copper: 1);
			item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Torch, 4);
			recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 4);
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}
