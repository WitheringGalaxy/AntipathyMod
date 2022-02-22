using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.Graphics.Shaders;

namespace AntipathyMod.Projectiles.Ammo
{
    public class DartProjectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.Size = new Vector2(13, 13);

            aiType = ProjectileID.PoisonDartBlowgun;
            projectile.aiStyle = 1;
            projectile.friendly = true;         //Can the projectile deal damage to enemies?

            projectile.ignoreWater = false;
            projectile.extraUpdates = 0;

            projectile.ranged = true;           //Is the projectile shot by a ranged weapon?
            projectile.penetrate = 1;           //How many monsters the projectile can penetrate. NEVER SET TO 0!!!
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Dig, projectile.position);
            Dust dust;
            for (int i = 0; i <= 3 + Main.rand.Next(1, 1); i++)
            {
                dust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Stone, 0, 0, 150, new Color(140, 140, 140), 0.8f)];
            }
        }
    }
}
