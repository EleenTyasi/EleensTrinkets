using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class fastforwardtimegem : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Emerald, 20)
                .AddIngredient(ItemID.Book, 10)
                .AddIngredient(ItemID.ManaCrystal, 2)
                .AddTile(TileID.MythrilAnvil)
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
            player.GetDamage(DamageClass.Ranged) += 0.35f;
            player.GetArmorPenetration(DamageClass.Ranged) += 4;
        }

    }
}