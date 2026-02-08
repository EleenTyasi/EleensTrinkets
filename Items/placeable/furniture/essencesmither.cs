
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace eleenstrinkets.Items.placeable.furniture
{

        public class essencesmither : ModItem
        {
            public override void SetDefaults()
            {
                // ModContent.TileType<Tiles.Furniture.ExampleWorkbench>() retrieves the id of the tile that this item should place when used.
                // DefaultToPlaceableTile handles setting various Item values that placeable items use
                // Hover over DefaultToPlaceableTile in Visual Studio to read the documentation!
                Item.DefaultToPlaceableTile(ModContent.TileType<tiles.essencesmither>());
                Item.width = 129; // The item texture's width
                Item.height = 124; // The item texture's height
                Item.value = 150;
            }

            public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
            {
                itemGroup = ContentSamples.CreativeHelper.ItemGroup.CraftingObjects;
            }

            // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
            public override void AddRecipes()
            {
            CreateRecipe() // cobalt recipe
                .AddIngredient(ItemID.Wood, 30)
                .AddIngredient(RecipeGroupID.IronBar, 40)
                .AddIngredient(ItemID.Sapphire, 10)
                .AddIngredient(ItemID.Ruby, 10)
                .AddIngredient(ItemID.Emerald, 10)
                .AddIngredient(ItemID.CobaltBar, 20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
            CreateRecipe() // palla recipe
               .AddIngredient(ItemID.Wood, 30)
               .AddIngredient(RecipeGroupID.IronBar, 40)
               .AddIngredient(ItemID.Sapphire, 10)
               .AddIngredient(ItemID.Ruby, 10)
               .AddIngredient(ItemID.Emerald, 10)
               .AddIngredient(ItemID.PalladiumBar, 20)
               .AddTile(TileID.MythrilAnvil)
               .Register();
        }
        }
}
