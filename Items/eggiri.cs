using eleenstrinkets;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items
{
    internal class eggiri : ModItem
    {
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Goldfish, 8)
                .AddIngredient(ItemID.VineRope, 30)
                .AddIngredient(ItemID.GreaterHealingPotion, 6)
                .AddIngredient(ModContent.ItemType<yellowpuyo>(), 1)
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
            player.GetDamage(DamageClass.Summon) += 0.22f;
            player.maxMinions += 4;
            player.potionDelayTime -= 1600;
            player.meleeEnchant = 5; // coat an enemy in egg, they take more damage lol
        }
    }
}
