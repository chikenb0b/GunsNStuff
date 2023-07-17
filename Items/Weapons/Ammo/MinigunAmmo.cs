using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using GunsNStuff.Items.Projectiles;

namespace GunsNstuff.Items.Weapons.Ammo
{
	public class MinigunAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}
		public override void SetDefaults()
		{
			Item.width = 8;
			Item.height = 8;
			Item.damage = 4;
			Item.DamageType = DamageClass.Ranged;
			Item.knockBack = 1f;
			Item.maxStack = 9999;
			Item.consumable = true;
            Item.ammo = Item.type;
			Item.shoot = ModContent.ProjectileType<MinigunAmmoProjectile>();
			Item.value = Item.buyPrice(silver: 1);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddIngredient(ItemID.MusketBall, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}