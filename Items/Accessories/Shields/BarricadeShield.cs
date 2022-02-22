using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AntipathyMod.Items.Accessories.Shields
{
    [AutoloadEquip(EquipType.Shield)]
    public class BarricadeShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barricade Shield");
            Tooltip.SetDefault("10% decreased movement speed\n" +
                "Immunity to knockback and +5% damage reduction while not moving");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(30, 56);

            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 5, copper: 50);
            item.accessory = true;

            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed -= player.moveSpeed * 0.1f;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.velocity == Vector2.Zero)
            {
                player.endurance += 0.05f;
                player.noKnockback = true;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 10);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddIngredient(ItemID.Chain, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
