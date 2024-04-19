using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using eleenstrinkets.Items;

namespace eleenstrinkets.Items
{
    public class terainiotoxinvial : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxLife = 0.50f;
        public static readonly float maxMana = 0.50f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            // Terainio Toxin Vial Recipe; Only Craftable at Demon Altar; The only vial that's available in both world types (Crimson and Corruption)
            CreateRecipe()
            .AddIngredient(ItemID.VialofVenom, 4)
            .AddIngredient(ModContent.ItemType<deseiumcapsule>(), 1)
            .AddIngredient(ItemID.HunterPotion, 4)
            .AddIngredient(ItemID.AmmoReservationPotion, 4)
            .AddIngredient(ItemID.ManaCrystal, 1)
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
            // Update the accessory to grant the effect
        { 
            player.GetDamage(DamageClass.Ranged) -= 0.12f; // Decrease ranged damage by 12%
            player.GetAttackSpeed(DamageClass.Ranged) -= 0.12f; // Decrease ranged attack speed by 12%
            player.statLifeMax2 += (int)(player.statLifeMax2 * maxLife); // Increase max life by 50%
            player.statManaMax2 += (int)(player.statManaMax2 * maxMana); // Increase max mana by 50%
            player.GetDamage(DamageClass.Magic) += 0.06f; // Increase magic damage by 6%
            player.manaCost -= 0.06f; // Decrease mana cost by 6%
            player.GetDamage(DamageClass.Melee) += 0.06f; // Increase melee damage by 6%
            player.GetAttackSpeed(DamageClass.Melee) += 0.06f; // Increase melee attack speed by 6%
        }

    }
}