using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace eleenstrinkets.Items.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Head value here will result in TML expecting a X_Head.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Head)]
	public class catwitchbonnet : ModItem
	{
		public static readonly int AdditiveGenericDamageBonus = 20;

		public static LocalizedText SetBonusText { get; private set; }

		public override void SetStaticDefaults() {
			ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true; // Draw all hair as normal. Used by Mime Mask, Sunglasses
		}

		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(platinum:1,gold: 6); // How many coins the item is worth
			Item.rare = ItemRarityID.Red; // The rarity of the item
			Item.defense = 20; // The amount of defense the item will give when equipped
		}

		// UpdateArmorSet allows you to give set bonuses to the armor.
		public override void UpdateEquip(Player player) {
			player.setBonus = SetBonusText.Value; // This is the setbonus tooltip: "Increases dealt damage by 20%"
			player.GetDamage(DamageClass.Magic) += 15 / 100f; // Increase dealt damage for all weapon classes by 20%
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.Register();
		}
	}
}
