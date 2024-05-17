using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using eleenstrinkets.Items;
using eleenstrinkets.Projectiles;
using eleenstrinkets.Items.weapons;
//important: use stardust kitty item in crafting

namespace eleenstrinkets.Items.weapons
{
    public class magebubblestaffm2 : ModItem
    {
        public override void SetDefaults()
        {

            Item.DefaultToStaff(ModContent.ProjectileType<magebubble2>(), 5, 15, 12);
            Item.width = 34;
            Item.height = 40;
            Item.UseSound = SoundID.Item71;

            Item.SetWeaponValues(45, 0, 4);
            Item.shoot = ModContent.ProjectileType<magebubble2>();
            Item.SetShopValues(ItemRarityColor.LightRed4, 8);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Glass, 20)
                .AddIngredient(ModContent.ItemType<magebubblestaff>(), 1)
                .AddIngredient(ItemID.DemoniteBar, 10)
                .AddIngredient(ItemID.ManaCrystal, 1)
                .AddTile(TileID.Anvils)
                .Register();
            CreateRecipe()
               .AddIngredient(ItemID.Glass, 20)
               .AddIngredient(ModContent.ItemType<magebubblestaff>(), 1)
               .AddIngredient(ItemID.CrimtaneBar, 10)
               .AddIngredient(ItemID.ManaCrystal, 1)
               .AddTile(TileID.Anvils)
               .Register();
        }
    }
}