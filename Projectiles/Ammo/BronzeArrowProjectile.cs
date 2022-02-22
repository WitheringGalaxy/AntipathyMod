using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AntipathyMod.Projectiles.Ammo
{
    public class BronzeArrowProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.Size = new Vector2(10, 10);
            drawOffsetX = -2;

            aiType = ProjectileID.WoodenArrowFriendly;
            projectile.aiStyle = 1;
            projectile.arrow = true;
            projectile.friendly = true;         //Can the projectile deal damage to enemies?

            projectile.ignoreWater = false;
            projectile.extraUpdates = 0;

            projectile.ranged = true;           //Is the projectile shot by a ranged weapon?
            projectile.penetrate = 1;           //How many monsters the projectile can penetrate. NEVER SET TO 0!!!
        }
        private static int statArmorPenetration = 3;
        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (target.defense >= statArmorPenetration)
            {
                damage += statArmorPenetration;
            }
            else if (Math.Abs(target.defense) < statArmorPenetration)
            {
                damage += Math.Abs(target.defense);
            }
            else damage *= 1;
            return;
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Dig, projectile.position);
            Dust dust;
            for (int i = 0; i <= 3 + Main.rand.Next(1, 5); i++)
            {
                dust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Stone, 0, 0, 150, new Color(255, 155, 0), 0.9f)];
            }
        }
    }
}