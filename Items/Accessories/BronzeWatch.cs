using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Accessories
{
    public class BronzeWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Watch");
            Tooltip.SetDefault("Tells the time");
        }

        public override void SetDefaults()
        {
            item.Size = new Microsoft.Xna.Framework.Vector2(30, 30);

            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 17, copper: 50);
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.accWatch = ItemID.GoldWatch;
        }

        public override void UpdateInventory(Player player)
        {
            player.accWatch = ItemID.GoldWatch;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 1);
            recipe.AddIngredient(ModContent.ItemType<Materials.BronzeBar>(), 10);
            recipe.AddTile(TileID.Tables);
            recipe.AddTile(TileID.Chairs);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.AddIngredient(ItemID.Wire, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Timer1Second, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.AddIngredient(ItemID.DepthMeter, 1);
            recipe.AddIngredient(ItemID.Compass, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.GPS, 1);
            recipe.AddRecipe();
        }
    }
}
