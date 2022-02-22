using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Tiles.Blocks
{
	public class BronzeBrick : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBrick[Type] = true;

			dustType = DustID.Copper;
			soundType = SoundID.Tink;
			soundStyle = 1;

			drop = ModContent.ItemType<Items.Placeables.Blocks.BronzeBrick>();
			AddMapEntry(new Color(232, 189, 146));

		}

	}
}