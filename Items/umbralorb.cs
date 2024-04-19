using eleenstrinkets;
using eleenstrinkets.Players;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
  public class umbralorb : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int manaRegen = 3;
        public static readonly int moveSpeed = 11;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            // Create Recipe. Recipe 1: corruption 
            CreateRecipe() // corruption recipe! uses demonite bars.
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.DemoniteBar, 10)
                .AddIngredient(ItemID.ManaCrystal, 10)
                .AddIngredient(ItemID.Gel, 15)
                .AddTile(TileID.WorkBenches)
                .Register();
            CreateRecipe() // crimson recipe! uses crimtane bars.
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.CrimtaneBar, 10)
                .AddIngredient(ItemID.ManaCrystal, 10)
                .AddIngredient(ItemID.Gel, 15)
                .AddTile(TileID.WorkBenches)
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
            player.GetModPlayer<umbralorbplayer>().umbralorbbool = true; // why the beans is the umbral orb shadowflame effect not working?
            player.moveSpeed += 0.11f; // 11% movement speed
            player.manaRegen += 6; // 3 mana per second
        }
    }
}
