using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace eleenstrinkets.Items
{
    public class miniglobo : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        public static readonly float maxMana = 0.15f;
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ManaCrystal, 2)
                .AddIngredient(ItemID.Bunny, 1)
                .AddIngredient(ItemID.JungleSpores, 20)
                .AddCondition(Condition.TimeNight)
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
            player.statManaMax2 += (int)(player.statManaMax2 * maxMana);
            player.GetDamage(DamageClass.Magic) += 0.03f;
            player.GetCritChance(DamageClass.Magic) += 3.0f;
           
        }

    }
}