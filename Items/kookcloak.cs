using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class kookcloak : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip

        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 50)
                .AddIngredient(ItemID.OrichalcumRepeater, 1)
                .AddIngredient(ItemID.AmmoReservationPotion, 10)
                .AddIngredient(ItemID.OrichalcumBar, 5)
                .AddTile(TileID.MythrilAnvil)
                .Register();
            CreateRecipe()
                .AddIngredient(ItemID.WoodenArrow, 50)
                .AddIngredient(ItemID.MythrilRepeater, 1)
                .AddIngredient(ItemID.AmmoReservationPotion, 10)
                .AddIngredient(ItemID.MythrilBar, 5)
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
            player.GetDamage(DamageClass.Ranged) += 0.35f;
            player.GetArmorPenetration(DamageClass.Ranged) += 8;
            player.GetDamage(DamageClass.Magic) -= 0.75f;
            player.manaCost += 0.75f;
            player.GetDamage(DamageClass.Melee) -= 0.75f;
            player.GetKnockback(DamageClass.Melee) -= 0.75f;
        }

    }
}