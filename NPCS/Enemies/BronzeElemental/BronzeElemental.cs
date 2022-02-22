using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.NPCS.Enemies.BronzeElemental
{
	public class BronzeElemental : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Elemental");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GraniteFlyer];
		}

		public override void SetDefaults()
		{
			npc.Size = new Microsoft.Xna.Framework.Vector2(20, 30);
			drawOffsetY = 16; //Adjust hitbox Y value
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath6;

			npc.aiStyle = 91;
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;

			banner = npc.type;
			bannerItem = ModContent.ItemType<Items.Placeables.Banners.BronzeElementalBanner>();

			npc.damage = 26;
			npc.defense = 10;
			npc.lifeMax = 45;
			npc.knockBackResist = 0.5f;
			npc.value = Item.buyPrice(silver: 5);
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Venom] = true;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Confused] = true;
		}

        public override void NPCLoot()
        {
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Materials.BronzeOre>(), Main.rand.Next(1, 3));
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (NPC.CountNPCS(ModContent.NPCType<BronzeElemental>()) == 0 && spawnInfo.spawnTileType == TileID.Marble && TileID.Marble >= 25 && spawnInfo.spawnTileY >= WorldGen.rockLayer)
            {
				return SpawnCondition.Cavern.Chance * 0.2f;
			}
			else return 0f;
		}

	}

}