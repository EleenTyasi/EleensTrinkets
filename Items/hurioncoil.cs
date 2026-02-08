using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
namespace eleenstrinkets.Items
{
  public class hurioncoil : ModItem
    {
        // By declaring these here, changing the values will alter the effect, and the tooltip
        // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Gel, 15)
                .AddIngredient(RecipeGroupID.IronBar, 1) //why does this not exist for the hardmode ores. tmodloader pls
                .AddIngredient(ItemID.WaterBucket, 1)
                .AddIngredient(ItemID.FallenStar, 3)
                .AddCondition(Condition.NearWater)
                .AddTile(TileID.Tables)
                .Register();

        }
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.rare = 3;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.jumpSpeedBoost += 2.50f;
            player.noFallDmg = true;
            player.accFlipper = true;
            player.GetJumpState<SimpleExtraJump>().Enable();
        }
    }
    public class SimpleExtraJump : ExtraJump
    {
        public override Position GetDefaultPosition() => new After(BlizzardInABottle);

        public override float GetDurationMultiplier(Player player)
        {
            // Use this hook to set the duration of the extra jump
            // The XML summary for this hook mentions the values used by the vanilla extra jumps
            return 3.25f;
        }

        public override void UpdateHorizontalSpeeds(Player player)
        {
            // Use this hook to modify "player.runAcceleration" and "player.maxRunSpeed"
            // The XML summary for this hook mentions the values used by the vanilla extra jumps
            player.runAcceleration *= 1.75f;
            player.maxRunSpeed *= 2f;
        }

        public override void OnStarted(Player player, ref bool playSound)
        {
            // Use this hook to trigger effects that should appear at the start of the extra jump
            // This example mimicks the logic for spawning the puff of smoke from the Cloud in a Bottle
            int offsetY = player.height;
            if (player.gravDir == -1f)
                offsetY = 0;

            offsetY -= 16;

            for (int i = 0; i < 10; i++)
            {
                Dust dust = Dust.NewDustDirect(player.position + new Vector2(-34f, offsetY), 102, 32, DustID.Cloud, -player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 100, Color.Gray, 1.5f);
                dust.velocity = dust.velocity * 0.5f - player.velocity * new Vector2(0.1f, 0.3f);
            }

            SpawnCloudPoof(player, player.Top + new Vector2(-16f, offsetY));
            SpawnCloudPoof(player, player.position + new Vector2(-36f, offsetY));
            SpawnCloudPoof(player, player.TopRight + new Vector2(4f, offsetY));
        }

        private static void SpawnCloudPoof(Player player, Vector2 position)
        {
            Gore gore = Gore.NewGoreDirect(player.GetSource_FromThis(), position, -player.velocity, Main.rand.Next(11, 14));
            gore.velocity.X = gore.velocity.X * 0.1f - player.velocity.X * 0.1f;
            gore.velocity.Y = gore.velocity.Y * 0.1f - player.velocity.Y * 0.05f;
        }

        public override void ShowVisuals(Player player)
        {
            // Use this hook to trigger effects that should appear throughout the duration of the extra jump
            // This example mimics the logic for spawning the dust from the Blizzard in a Bottle
            int offsetY = player.height - 6;
            if (player.gravDir == -1f)
                offsetY = 6;

            Vector2 spawnPos = new Vector2(player.position.X, player.position.Y + offsetY);

            for (int i = 0; i < 2; i++)
            {
                SpawnBlizzardDust(player, spawnPos, 0.1f, i == 0 ? -0.07f : -0.13f);
            }

            for (int i = 0; i < 3; i++)
            {
                SpawnBlizzardDust(player, spawnPos, 0.6f, 0.8f);
            }

            for (int i = 0; i < 3; i++)
            {
                SpawnBlizzardDust(player, spawnPos, 0.6f, -0.8f);
            }
        }

        private static void SpawnBlizzardDust(Player player, Vector2 spawnPos, float dustVelocityMultiplier, float playerVelocityMultiplier)
        {
            Dust dust = Dust.NewDustDirect(spawnPos, player.width, 12, DustID.Snow, player.velocity.X * 0.3f, player.velocity.Y * 0.3f, newColor: Color.Purple);
            dust.fadeIn = 1.5f;
            dust.velocity *= dustVelocityMultiplier;
            dust.velocity += player.velocity * playerVelocityMultiplier;
            dust.noGravity = true;
            dust.noLight = true;
        }
    }
}
