using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using eleenstrinkets.Items;
// load up this bitch
// we'll need our namespace's items
// obviously.

namespace eleenstrinkets.Items.Armor // HAHA! fuck YOU!!!
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Head)]
	// what, no head?
	public class catwitchbonnet : ModItem
	{
		// apparently, statmanamax2 is so stupid, that it has to do this shitfuckery in order to work.
		public static readonly float maxMana = 0.15f;
		// You bitch.

		public static LocalizedText SetBonusText { get; private set; }

		public override void SetStaticDefaults() {
            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true; // Hides part of the player's hairstyle. 
        }
		// Man, do i HATE setstaticdefaults; why is it such a cunt?
		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(platinum:1,gold: 6); // How many coins the item is worth
			Item.rare = ItemRarityID.Red; // The rarity of the item
			Item.defense = 20; // The amount of defense the item will give when equipped
		}

		// UpdateArmorSet is fucken useless.
		// this 'armor' set has only one item.

		// So we use UpdateEquip instead!
		public override void UpdateEquip(Player player) {
			player.GetDamage(DamageClass.Magic) += 15 / 100f; // Increase dealt damage for all weapon classes by 20%
			player.statManaMax2 += (int)(player.statManaMax2 * maxMana); // Increase max mana by 15%
			player.manaCost -= 0.10f; // mana cost reducing cat hat, bitch!
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			// gee i sure do love making recipes
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<stardustkitty>(), 1) // Stardust Kitty: Accessory. 
				.AddIngredient(ItemID.Silk, 15) // Crafting Material
				.AddIngredient(ItemID.WhiteString, 3) // Crafting Material
				.AddTile(TileID.HeavyWorkBench) // because fuck hand crafting
				.Register();
		}
	}
}
