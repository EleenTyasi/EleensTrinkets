using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class strategyguide : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxLife = 0.25f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Book, 1)
                .AddIngredient(ItemID.CobaltBar, 8)
                .AddIngredient(ItemID.AdamantiteBar, 6)
                .AddIngredient(ItemID.Wood, 140)
                .AddTile(TileID.Bookcases)
                .Register();
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true;
        }
        // Update the accessory to 
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.25f;
            player.GetCritChance(DamageClass.Generic) += 25;
            player.statLifeMax2 -= (int)(player.statLifeMax2 * maxLife);
        }

    }
}