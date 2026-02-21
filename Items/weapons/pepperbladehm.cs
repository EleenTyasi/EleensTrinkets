// setup bullshit
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// setup the namespace.

namespace eleenstrinkets.Items.weapons
{
    // here comes the shitshow
    public class pepperbladehm : ModItem
    {
        public override void SetDefaults()
        {
            // item stats and sprite details
            Item.width = 71; // tall asf pepper. 
            Item.height = 70; // this is the item's sprite size; lol
            // Swingspeed, and use style
            Item.useStyle = ItemUseStyleID.Swing; // Smack that bitch.
            Item.useTime = 20; // Somewhat slow swing speed.
            Item.useAnimation = 20; // suggested from ExampleMod/Content/Items/Weapons/ExampleSword to be same as usetime
            Item.autoReuse = true; // it's a sword. swing that shit
            // stats
            Item.DamageType = DamageClass.Melee;
            Item.damage = 435;
            Item.knockBack = 4;
            Item.crit = 9;
            // rarity and value
            Item.value = 20440;
            Item.rare = 6;
            Item.UseSound = SoundID.Item1;
        }
        // This pepper is spicy af. 
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Inflict a harsh burn for 6s.
            target.AddBuff(BuffID.OnFire, 360);
        }
    }

}