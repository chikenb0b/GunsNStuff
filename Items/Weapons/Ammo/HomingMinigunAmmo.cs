using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using GunsNStuff.Items.Projectiles;


namespace GunsNstuff.Items.Weapons.Ammo
{
	public class HomingMinigunAmmo : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}
		public override void SetDefaults()
		{
			Item.width = 8;
			Item.height = 8;
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.knockBack = 2f;
			Item.maxStack = 9999;
			Item.consumable = true;
            Item.ammo = Item.type;
			Item.shoot = ModContent.ProjectileType<HomingMinigunAmmoProjectile>();
			Item.value = Item.buyPrice(silver: 10);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MythrilBar, 1);
			recipe.AddIngredient(ItemID.MusketBall, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}