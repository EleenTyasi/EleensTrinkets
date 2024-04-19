using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using eleenstrinkets.Items;

namespace eleenstrinkets.Items
{
    public class iskraband : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int lifeRegen = 8;
        public static readonly int manaRegen = 8;
        public static readonly int moveSpeed = 8;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 12)
                .AddIngredient(ItemID.Emerald, 2)
                .AddIngredient(ModContent.ItemType<genesisband>(), 1)
                .AddTile(TileID.HeavyWorkBench)
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
            player.moveSpeed += 0.08f;
            player.lifeRegen += 16;
            player.manaRegen += 16;
        }
    }
}