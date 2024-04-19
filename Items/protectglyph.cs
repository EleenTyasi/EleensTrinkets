using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
namespace eleenstrinkets.Items
{
    public class protectglyph : ModItem
    {
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Diamond, 8)
                .AddIngredient(ItemID.ManaCrystal, 5)
                .AddIngredient(ItemID.EndurancePotion,5)
                .AddIngredient(ItemID.IronskinPotion,5)
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
        // Update the accessory to 
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 9;
            player.GetCritChance(DamageClass.Generic) += 5f;
        }

    }
}