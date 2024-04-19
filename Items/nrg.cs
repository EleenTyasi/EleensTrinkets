using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class nrg : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxLife = 0.10f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SwiftnessPotion, 6)
                .AddIngredient(ItemID.Gel, 50)
                .AddIngredient(ItemID.BottledWater, 1)
                .AddIngredient(ItemID.LavaBucket, 1)
                .AddTile(TileID.Bottles)
                .Register();
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 3;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 -= (int)(player.statLifeMax2 * maxLife);
            player.moveSpeed += 0.015f;

        }
    }
}