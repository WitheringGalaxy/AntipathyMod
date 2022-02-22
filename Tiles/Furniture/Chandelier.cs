using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace AntipathyMod.Tiles.Furniture
{
    internal class Chandelier : ModTile
    {
        public override void SetDefaults()
        {
            // Main.tileFlame[Type] = true; This breaks it.
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileWaterDeath[Type] = false;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);

            // We need to change the 3x3 default to allow only placement anchored to top rather than on bottom. Also, the 1,1 means that only the middle tile needs to attach
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, 1, 1);
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            // This is so we can place from above.
            TileObjectData.newTile.Origin = new Point16(1, 0);
            TileObjectData.newTile.WaterDeath = false;
            TileObjectData.newTile.WaterPlacement = LiquidPlacement.Allowed;
            TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
            AddMapEntry(new Color(207, 155, 103), Language.GetText("Chandelier")); //Change the rgb color to change how it will display on the map
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 48, 48, ModContent.ItemType<Items.Placeables.Furniture.BronzeChandelier>());
        }

        //All of this is for turning it on and off.
        public override void HitWire(int i, int j)
        {
            Tile tile = Main.tile[i, j];
            int x = i - Main.tile[i, j].frameX / 18 % 3;
            int y = j - Main.tile[i, j].frameY / 18 % 3;
            short frameAdjustment = (short)(tile.frameX >= 54 ? -54 : 54);
            Main.tile[x, y].frameX += frameAdjustment;
            Main.tile[x, y + 1].frameX += frameAdjustment;
            Main.tile[x, y + 2].frameX += frameAdjustment;
            Main.tile[x + 1, y].frameX += frameAdjustment;
            Main.tile[x + 1, y + 1].frameX += frameAdjustment;
            Main.tile[x + 1, y + 2].frameX += frameAdjustment;
            Main.tile[x + 2, y].frameX += frameAdjustment;
            Main.tile[x + 2, y + 1].frameX += frameAdjustment;
            Main.tile[x + 2, y + 2].frameX += frameAdjustment;
            Wiring.SkipWire(x, y);
            Wiring.SkipWire(x, y + 1);
            Wiring.SkipWire(x, y + 2);
            Wiring.SkipWire(x + 1, y);
            Wiring.SkipWire(x + 1, y + 1);
            Wiring.SkipWire(x + 1, y + 2);
            Wiring.SkipWire(x + 2, y);
            Wiring.SkipWire(x + 2, y + 1);
            Wiring.SkipWire(x + 2, y + 2);
            NetMessage.SendTileSquare(-1, x, y + 1, 3, TileChangeType.None);
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            Tile tile = Main.tile[i, j];
            if (tile.frameX == 0)
            {
                // We can support different light colors for different styles here: switch (tile.frameY / 54)
                //RGB for the light. 1f is max 0f is min.
                r = 1f;
                g = 1f;
                b = 1f;
            }
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            if (!Main.gamePaused && Main.instance.IsActive && (!Lighting.UpdateEveryFrame || Main.rand.NextBool(4)))
            {
                Tile tile = Main.tile[i, j];
                short frameX = tile.frameX;
                short frameY = tile.frameY;
                if (Main.rand.NextBool(40) && frameX == 0)
                {
                    int style = frameY / 54;
                    if (frameY / 18 % 3 == 0)
                    {
                        int dustChoice = -1;
                        if (style == 0)
                        {
                            dustChoice = 6; // A flame dust.
                        }
                        // We can support different dust for different styles here
                        if (dustChoice != -1)
                        {
                            int dust = Dust.NewDust(new Vector2(i * 16 + 4, j * 16 + 2), 4, 4, dustChoice, 0f, 0f, 100, default, 1f);
                            if (Main.rand.Next(3) != 0)
                            {
                                Main.dust[dust].noGravity = true;
                            }
                            Main.dust[dust].velocity *= 0.3f;
                            Main.dust[dust].velocity.Y = Main.dust[dust].velocity.Y - 1.5f;
                        }
                    }
                }
            }
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            SpriteEffects effects = SpriteEffects.None;

            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }

            Tile tile = Main.tile[i, j];
            int width = 48;
            int offsetY = 0;
            int height = 48;
            TileLoader.SetDrawPositions(i, j, ref width, ref offsetY, ref height);
            var flameTexture = Main.FlameTexture[3]; // We could also reuse Main.FlameTexture[] textures, but using our own texture is nice.

            ulong num190 = Main.TileFrameSeed ^ (ulong)((long)j << 32 | (long)(uint)i);
            // We can support different flames for different styles here: int style = Main.tile[j, i].frameY / 54;
            for (int c = 0; c < 7; c++)
            {
                float shakeX = Utils.RandomInt(ref num190, -10, 11) * 0.15f;
                float shakeY = Utils.RandomInt(ref num190, -10, 1) * 0.35f;
                //Adjust this to draw the frames differently.
                Main.spriteBatch.Draw(flameTexture, new Vector2(i * 16 - (int)Main.screenPosition.X - (width - 16f) / 2f + shakeX, j * 16 - (int)Main.screenPosition.Y + offsetY + shakeY) + zero, new Rectangle(tile.frameX, tile.frameY, width, height), new Color(100, 100, 100, 0), 0f, default, 1f, effects, 0f);
            }
        }
    }
}