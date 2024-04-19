using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class abberantlightshard : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip

        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ManaPotion, 50)
                .AddIngredient(ItemID.Book, 10)
                .AddIngredient(ItemID.ManaRegenerationPotion, 10)
                .AddIngredient(ItemID.CrystalShard, 18)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 4;
            Item.accessory = true;
        }
        // Update the accessory to 
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Ranged) -= 0.75f;
            player.GetAttackSpeed(DamageClass.Ranged) -= 0.75f;
            player.GetDamage(DamageClass.Magic) += 0.35f;
            player.manaCost -= 0.35f;
            player.GetDamage(DamageClass.Melee) -= 0.75f;
            player.GetAttackSpeed(DamageClass.Melee) -= 0.75f; 
        }

    }
}