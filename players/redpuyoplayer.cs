using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace eleenstrinkets.Players
{
    public class redpuyoplayer : ModPlayer
    {
        public bool redpuyobool;

        // Always reset the accessory field to its default value here.
        public override void ResetEffects()
        {
            redpuyobool = false;
        }


        public override void OnHitNPCWithItem(Item item, NPC npc, NPC.HitInfo hit, int damageDone)
        {
            if (redpuyobool)
            {
               npc.AddBuff(BuffID.OnFire, 2300);
            }
        }
    }
}