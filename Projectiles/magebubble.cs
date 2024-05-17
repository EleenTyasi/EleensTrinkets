using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace eleenstrinkets.Projectiles
{
    public class magebubble : ModProjectile
    {
        private Color trailColor;

        public override void SetDefaults()
        {
            Projectile.width = 16; //The width of projectile hitbox
            Projectile.height = 16; //The height of projectile hitbox
            Projectile.aiStyle = 1; //The ai style of the projectile, please reference the source code of Terraria
            Projectile.friendly = true; //Can the projectile deal damage to enemies?
            Projectile.hostile = false; //Can the projectile deal damage to the player?
            Projectile.DamageType = DamageClass.Magic; //Is the projectile shoot by a ranged weapon?
            Projectile.ignoreWater = true; //Does the projectile's speed be influenced by water?
            Projectile.tileCollide = true; //Can the projectile collide with tiles?
            Projectile.alpha = 0;

            AIType = ProjectileID.Bullet; // the projectile is a bubble of magic. it sure is a bullet.
        }
        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation(); // you fucking cunty whooooooorrre. fuck offffffff
        }

    }
}