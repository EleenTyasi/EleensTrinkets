using eleenstrinkets;
using eleenstrinkets.Players;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
    internal class rapperrepose : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe() 
                .AddIngredient(RecipeGroupID.IronBar, 30)
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddIngredient(ItemID.MythrilBar, 15)
                .AddIngredient(ItemID.ChlorophyteBar, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
            CreateRecipe() 
                .AddIngredient(RecipeGroupID.IronBar, 30)
                .AddIngredient(ItemID.Glass, 35)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddIngredient(ItemID.OrichalcumBar, 15)
                .AddIngredient(ItemID.ChlorophyteBar, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true; // Accessory! Yes. Because the main point of the mod is, accessories. Duh.
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaRegen += 12; // 6 mana per second; because mana regen is just as weird as life regen... WHY?
            player.moveSpeed -= 0.06f; // Slightly slows you. 
            player.manaCost -= 0.12f; // sing yo' fecken spells, i wanna see more magic (12% manacost reduce, fuuuuck yes)
        }
    }
}
