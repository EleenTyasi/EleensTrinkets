using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class ionorb : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.FallenStar, 10)
                .AddIngredient(ItemID.Topaz, 15)
                .AddIngredient(ItemID.ManaPotion, 3)
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
            player.GetDamage(DamageClass.Summon) += 0.12f;
            player.GetAttackSpeed(DamageClass.SummonMeleeSpeed) += 0.12f;
            player.maxMinions += 3;
        }
    }
}