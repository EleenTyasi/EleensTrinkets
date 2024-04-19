using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class genesisband : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip

        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 14)
                .AddIngredient(ItemID.Sapphire, 3)
                .AddIngredient(ItemID.FallenStar, 2)
                .AddTile(TileID.Tables)
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
            player.moveSpeed += 0.03f;
            player.lifeRegen += 6;
            player.manaRegen += 6;
        }
    }
}