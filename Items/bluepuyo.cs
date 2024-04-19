﻿using eleenstrinkets;
using eleenstrinkets.Players;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
  public class bluepuyo : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int manaRegen = 3;
        public static readonly int moveSpeed = 11;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        { // OK, this kinda works. Good.
            CreateRecipe()
                .AddIngredient(ItemID.Sapphire, 1)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ModContent.ItemType<nuisancepuyo>(), 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
        public override void SetDefaults()
        { // set the item's rarity; and the fact that it's indeed an accessory.
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.12f; // works.
            player.GetCritChance(DamageClass.Magic) += 12.0f; // only .12%?? what the fuck?
            player.manaRegen += 6; // i swear to god, why are all the regen ones broken?
        }
    }
}
