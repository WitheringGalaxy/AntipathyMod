using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Materials
{
    public class MagicDust : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Dust");
            Tooltip.SetDefault("'Unconcentrated Arcane Powder'\n" +
                "Can be aqcuired in its concentrated form with later advancement");
        }

        public override void SetDefaults()
        {
            item.Size = new Microsoft.Xna.Framework.Vector2(16, 16);
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 3);
            item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Mysticite>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 2);
        }
    }
}
