﻿using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class regrowbloon : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int lifeRegen = 12;
        public static readonly float maxLife = 0.50f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SillyBalloonPink, 30)
                .AddIngredient(ItemID.RegenerationPotion, 3)
                .AddIngredient(ItemID.SwiftnessPotion, 3)
                .AddIngredient(ItemID.LifeforcePotion, 3)
                .AddTile(TileID.DemonAltar)
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
            player.lifeRegen += 80;
            player.statLifeMax2 -= (int)(player.statLifeMax2 * maxLife);
            player.moveSpeed += 0.12f;
        }
    }
}