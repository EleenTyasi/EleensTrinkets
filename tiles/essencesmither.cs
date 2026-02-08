
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace eleenstrinkets.tiles
{
    internal class essencesmither : ModTile
    {
        public override void SetStaticDefaults()
        {
            // make this shit not die
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            // fuck yo smart cursor
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);
            TileObjectData.addTile(Type);

            AddMapEntry(new Microsoft.Xna.Framework.Color(126, 32, 5), CreateMapEntryName());
        }
        // hey microsoft, what the fuck is this C# bs?
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(
                new EntitySource_TileBreak(i, j),
                i * 16,
                j * 16,
                129, 
                124,
                ModContent.ItemType<Items.placeable.furniture.essencesmither>()
               );
        }

    }
}
