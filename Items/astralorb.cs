using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class astralorb : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {   // Workbench, 35 glass, 10 fallen stars, 15 gel; no boss requirement
            CreateRecipe()
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.FallenStar, 10)
                .AddIngredient(ItemID.Gel, 15)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.07f;// 7% movespeed, works
            player.statDefense += 4; // 4 def, this actually works
            player.lifeRegen += 6; // 3 hp/s regen; questionable if this even works
            player.GetDamage(DamageClass.Summon) += 0.07f; // works!
            player.GetAttackSpeed(DamageClass.SummonMeleeSpeed) += 0.07f; // yay!
            player.maxMinions += 2; // looks like it works!
        }
    }
}