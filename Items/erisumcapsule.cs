using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class erisumcapsule : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxLife = 0.10f;
        public static readonly float maxMana = 0.20f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DartTrap, 1)
                .AddIngredient(ItemID.Stinger, 15)
                .AddIngredient(ItemID.TissueSample, 4)
                .AddIngredient(ItemID.GlassBowl, 2)
                .AddTile(TileID.Bottles)
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
            player.GetDamage(DamageClass.Melee) -= 0.06f;
            player.GetAttackSpeed(DamageClass.Melee) -= 0.06f;
            player.statLifeMax2 -= (int)(player.statLifeMax2 * maxLife);
            player.statManaMax2 += (int)(player.statManaMax2 * maxMana);
            player.GetDamage(DamageClass.Ranged) += 0.06f;
            player.GetAttackSpeed(DamageClass.Ranged) += 0.06f;
            player.GetDamage(DamageClass.Magic) += 0.06f;
            player.manaCost -= 0.06f;
        }

    }
}