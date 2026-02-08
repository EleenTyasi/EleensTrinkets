using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using eleenstrinkets.Items;

namespace eleenstrinkets.Items
{
    public class bearboon : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxLife = 0.05f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.BottledHoney, 3)
            .AddIngredient(ItemID.Hive, 30)
            .AddIngredient(ItemID.HoneyBlock, 30)
            .AddTile(TileID.HoneyDispenser)
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
            player.statLifeMax2 += (int)(player.statLifeMax2 * maxLife); // butt ugly hack; will fix never.
            player.statDefense += 2;
        }

    }
}