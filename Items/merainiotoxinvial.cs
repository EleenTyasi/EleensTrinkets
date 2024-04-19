using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using eleenstrinkets.Items;

namespace eleenstrinkets.Items
{
    public class merainiotoxinvial : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly int genericDamage = 20;
        public static readonly int genericCrit = -10;
        public static readonly float maxLife = 0.80f;
        public static readonly float maxMana = 0.50f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(genericDamage, genericCrit);

        public override void AddRecipes()
        {
            CreateRecipe()
                    .AddIngredient(ItemID.VialofVenom, 4)
                    .AddIngredient(ModContent.ItemType<misiumcapsule>(), 1)
                    .AddIngredient(ItemID.TissueSample, 4)
                    .AddIngredient(ItemID.LifeCrystal, 1)
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
        {
            player.GetDamage(DamageClass.Magic) -= 0.12f;
            player.manaCost += 0.12f;
            player.statLifeMax2 += (int)(player.statLifeMax2 * maxLife);
            player.statManaMax2 -= (int)(player.statManaMax2 * maxMana);
            player.GetDamage(DamageClass.Ranged) += 0.12f;
            player.ammoCost75 = true;
            player.GetDamage(DamageClass.Melee) += 0.12f;
            player.GetAttackSpeed(DamageClass.Melee) += 0.12f;
        }

    }
}