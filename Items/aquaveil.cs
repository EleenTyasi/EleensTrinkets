using rail;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
    public class aquaveil : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Sapphire, 3)
                .AddIngredient(ItemID.BottledWater, 3)
                .AddIngredient(ItemID.WaterBucket, 1)
                .AddIngredient(ItemID.SilverCoin, 4)
                .AddTile(TileID.Anvils)
                .Register();
        }
                

  
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 3;
            Item.accessory = true;
        }
        // Update the accessory to 
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.06f;
            player.statDefense += 5;
            player.statManaMax2 += 20;
        }

    }
}