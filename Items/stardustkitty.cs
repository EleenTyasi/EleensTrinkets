using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class stardustkitty : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip

        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FallenStar, 50)
                .AddIngredient(ItemID.ManaCrystal, 15)
                .AddIngredient(ItemID.PixieDust, 25)
                .AddIngredient(ItemID.LivingWoodWand, 1)
                .AddIngredient(ItemID.ManaPotion, 5)
                .AddCondition(Condition.TimeNight)
                .AddTile(TileID.BewitchingTable)
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
            player.GetDamage(DamageClass.Magic) += 0.15f;
            player.GetCritChance(DamageClass.Magic) += 15.0f;
        }

    }
}