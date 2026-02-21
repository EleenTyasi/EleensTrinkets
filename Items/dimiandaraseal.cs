using rail;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class dimiandaraseal : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int genericDamage = -20;
        public static readonly int genericCrit = 30;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 2)
                .AddIngredient(ItemID.Diamond, 3)
                .AddIngredient(ItemID.Blinkroot, 3)
                .AddTile(TileID.AlchemyTable)
                .Register();
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true;
            Item.value = 10200;
        }
        // Update the accessory to 
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) -= 2.0f; // ??? this is supposed to reduce damage by 20%; not by only .2%???
            player.GetCritChance(DamageClass.Generic) += 30.0f; // meant to be 30%; not .3% T-T;
            player.statDefense += 3; // the only stat that works...

        }

    }
}