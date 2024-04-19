using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eleenstrinkets.Players
{
    public class umbralorbplayer : ModPlayer
    {
        public bool umbralorbbool;

        // Always reset the accessory field to its default value here.
        public override void ResetEffects()
        {
            umbralorbbool = false;
        }


        public override void OnHitNPCWithItem(Item item, NPC npc, NPC.HitInfo hit, int damageDone)
        {
            if (umbralorbbool)
            {
               npc.AddBuff(BuffID.ShadowFlame, 2300);
            }
        }
    }
}