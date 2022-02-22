using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace AntipathyMod.Tiles.Walls
{
    public class BronzeBrickWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = DustID.Copper;
            drop = ModContent.ItemType<Items.Placeables.Walls.BronzeBrickWall>();
            AddMapEntry(new Color(252, 197, 151));
        }
    }
}
