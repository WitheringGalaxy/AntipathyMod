using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Items.Weapons.Melee
{
	public class StabbyStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stabby Stone");
			Tooltip.SetDefault("'Stab x3'");
		}

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(24, 24);
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.Stabbing;

			item.value = Item.sellPrice(silver: 5);
			item.rare = ItemRarityID.Blue;

			item.melee = true;
			item.damage = 5;
			item.useTime = 7; //in frames per second ----v
			item.useAnimation = 7;
			item.knockBack = 1;
	
		}
	}
}