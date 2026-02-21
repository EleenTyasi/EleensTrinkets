// setup bullshit
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// setup the namespace.

namespace eleenstrinkets.Items.weapons
{
    // here comes the shitshow
    public class pepperbladenm : ModItem
    {
        public override void SetDefaults()
        {
            // item stats and sprite details
            Item.width = 55; // tall asf pepper. 
            Item.height = 55; // this is the item's sprite size; lol
            // Swingspeed, and use style
            Item.useStyle = ItemUseStyleID.Swing; // Smack that bitch.
            Item.useTime = 30; // Somewhat slow swing speed.
            Item.useAnimation = 30; // suggested from ExampleMod/Content/Items/Weapons/ExampleSword to be same as usetime
            Item.autoReuse = true; // it's a sword. swing that shit
            // stats
            Item.DamageType = DamageClass.Melee;
            Item.damage = 55;
            Item.knockBack = 4;
            Item.crit = 8;
            // rarity and value
            Item.value = 10440;
            Item.rare = 4;
            Item.UseSound = SoundID.Item1;
        }
        // This pepper is spicy af. 
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Inflict a harsh burn for 3s.
            // 60f = 1s, so 60x3
            target.AddBuff(BuffID.OnFire, 180);
        }
    }

}