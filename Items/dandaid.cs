using eleenstrinkets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
    internal class dandaid : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe() // now better recipe; requires effort.
                .AddIngredient(ItemID.Sapphire, 10)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.Silk, 30)
                .AddIngredient(ItemID.CobaltBar, 8) // Yep, cobalt because it's blue
                .AddTile(TileID.MythrilAnvil) // yes, hardmode required.
                .Register();
            CreateRecipe() //now to add the opposite HM ore
                .AddIngredient(ItemID.Sapphire, 10)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ItemID.Silk, 30)
                .AddIngredient(ItemID.PalladiumBar, 8) // Yep, palladium because compatibility is cool
                .AddTile(TileID.MythrilAnvil) // mythril anvil. bc i want to ensure you ain't gettin' this post-hardmode
                .Register();
        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true; // Accessory! Yes. Because the main point of the mod is, accessories. Duh.
        }
        // Dandaid is a reference to a roblox game; Dandy's World. So, this item should replicate it's effect somehow.
        // The plan is to make it give Life Regen, at the cost to movement speed.
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen += 80; // 80 = 20 life per second. Why the hell is terraria life regen so weird?
            player.moveSpeed -= 0.08f; // screw your movement speed, either stand and fight, or die where you stand coward.
        }
    }
}
