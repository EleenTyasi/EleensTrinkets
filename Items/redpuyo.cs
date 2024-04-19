using eleenstrinkets;
using eleenstrinkets.Players;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
  public class redpuyo : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int manaRegen = 3;
        public static readonly int moveSpeed = 11;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LavaBucket, 1)
                .AddIngredient(ItemID.LifeCrystal, 1)
                .AddIngredient(ModContent.ItemType<nuisancepuyo>(), 1)
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
            player.GetModPlayer<redpuyoplayer>().redpuyobool = true;
            player.moveSpeed += 0.11f;
        }
    }
}
