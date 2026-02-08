using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using eleenstrinkets.Items;
using eleenstrinkets.Projectiles;
//important: use stardust kitty item in crafting

namespace eleenstrinkets.Items.weapons
{
    public class magebubblestaff : ModItem
    {
        public override void SetDefaults()
        {

            Item.DefaultToStaff(ModContent.ProjectileType<magebubble>(), 10, 13, 3); // fuck YOU, c#.
            Item.width = 34;
            Item.height = 40;
            Item.UseSound = SoundID.Item71;
            Item.shoot = ModContent.ProjectileType<magebubble>(); // duh. fire the mage bubble.
            Item.SetWeaponValues(15, 3, 4);

            Item.SetShopValues(ItemRarityColor.LightRed4, 10000);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Glass, 20)
                .AddIngredient(ModContent.ItemType<stardustkitty>(),1)
                .AddIngredient(ItemID.Amethyst, 10)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}