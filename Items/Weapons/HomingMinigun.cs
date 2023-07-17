
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using GunsNstuff.Items.Weapons.Ammo;

namespace GunsNStuff.Items.Weapons
{
    public class HomingMinigun : ModItem
	{
		public override void SetStaticDefaults()
		{
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
		public override void SetDefaults()
		{
			Item.width = 50;
			Item.height = 30;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = true;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 20;
			Item.knockBack = 2f;
			Item.noMelee = true;
			Item.shootSpeed = 1000f;
			Item.value = Item.buyPrice(gold: 20);
            
			//shooting stuff
			Item.shoot = ModContent.ProjectileType<Projectiles.HomingMinigunAmmoProjectile>();
            Item.useAmmo = ModContent.ItemType<HomingMinigunAmmo>();
			//Item.shoot = ProjectileID.Bullet;
			//Item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IllegalGunParts, 10);
			recipe.AddIngredient(ItemID.MythrilBar, 150);
			recipe.AddIngredient(ItemID.OrichalcumBar, 50);
			recipe.AddIngredient(ItemID.Diamond, 10);
            Recipe recipe1 = recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
