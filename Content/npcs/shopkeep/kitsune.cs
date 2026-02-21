using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Personalities;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using eleenstrinkets.Items.weapons;
using eleenstrinkets.Items;


namespace eleenstrinkets.Content.npcs.shopkeep
{
    public class Kitsune : ModNPC
    {
        public const string ShopName = "Shop";
        public override void SetStaticDefaults()
        {
            
            Main.npcFrameCount[Type] = 25;

            NPCID.Sets.ExtraFramesCount[Type] = 9;
            NPCID.Sets.HatOffsetY[Type] = 3;
            // NPCID.Sets.ShimmerTownTransform = false; it's naturally false

            NPC.Happiness
                .SetBiomeAffection<SnowBiome>(AffectionLevel.Love)
                .SetBiomeAffection<DesertBiome>(AffectionLevel.Hate)
                .SetBiomeAffection<HallowBiome>(AffectionLevel.Like)
                .SetBiomeAffection<DungeonBiome>(AffectionLevel.Dislike)
                .SetNPCAffection(NPCID.Guide, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Demolitionist, AffectionLevel.Like)
                .SetNPCAffection(NPCID.TaxCollector, AffectionLevel.Hate)
                .SetNPCAffection(NPCID.BestiaryGirl, AffectionLevel.Love) // WHAT THE FUCK DO YOU MEAN TERRARIA
                .SetNPCAffection(NPCID.ArmsDealer, AffectionLevel.Like); // semicolon minded
        }
        public override void SetDefaults()
        {
            NPC.townNPC = true; // yeah, dumbass, it's a shop
            NPC.friendly = true; // bro has no beef
            NPC.width = 19;
            NPC.height = 40;
            NPC.aiStyle = NPCAIStyleID.Passive;
            NPC.damage = 15;
            NPC.defense = 9999;
            NPC.lifeMax = 500;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            // hehe funny
            AnimationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs){
            // murk the eye of cthulu, then we'll talk my guy
            return NPC.downedBoss1;
        }
        public override List<string> SetNPCNameList()
        {
            return new List<string>()
            {
                "Ricky"  // LITERALLY THE CHARACTERS NAME.
            };
        }
        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();
            chat.Add(Language.GetTextValue("Mods.eleenstrinkets.NPCs.Kitsune.Dialogue.Standard1"));
            chat.Add(Language.GetTextValue("Mods.eleenstrinkets.NPCs.Kitsune.Dialogue.Standard2"));
            chat.Add(Language.GetTextValue("Mods.eleenstrinkets.NPCs.Kitsune.Dialogue.Standard3"));
            chat.Add(Language.GetTextValue("Mods.eleenstrinkets.NPCs.Kitsune.Dialogue.Standard4"));
            chat.Add(Language.GetTextValue("Mods.eleenstrinkets.NPCs.Kitsune.Dialogue.Standard5"));

            return chat;
        }
        // is it shop time, i think it's shop time, luna is it shop time?
        public override void AddShops()
        {
            var npcShop = new NPCShop(Type, ShopName)
                .Add<Items.weapons.pepperbladenm>(Condition.PreHardmode)
                .Add<Items.weapons.pepperbladehm>(Condition.Hardmode)
                .Add<Items.dimiandaraseal>()
                .Add<Items.bluepuyo>()
                .Add<Items.redpuyo>()
                .Add<Items.greenpuyo>()
                .Add<Items.yellowpuyo>()
                .Add<Items.purplepuyo>()
                .Add<Items.strategyguide>(Condition.DownedMoonLord); // hehehe, frick you
            npcShop.Register();
        }
        public override void SetChatButtons(ref string button, ref string dummy)
        {
            button = Language.GetTextValue("LegacyInterface.28");
        }
        public override void OnChatButtonClicked(bool firstButton, ref string shop)
        {
            if (firstButton)
            {
                shop = ShopName; // wow such shop, much wow
            }
        }
    }
}
