using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace AntipathyMod.Tiles.Ore
{
	public class Mysticite : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 255; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = true;


			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Mysticite");
			AddMapEntry(new Color(233, 230, 250), name);
			dustType = DustID.Platinum; //Change sometime

			soundType = SoundID.Tink;
			soundStyle = 1;
			animationFrameHeight = 268;
			//mineResist = 4f;
			//minPick = 200;
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			// Spend 9 ticks on each of 6 frames, looping
			if (++frameCounter >= 9)
			{
				frameCounter = 0;
				frame = ++frame % 6;
			}
		}

		public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
				Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MagicDust"), Main.rand.Next(1, 3));
        }
    }
}