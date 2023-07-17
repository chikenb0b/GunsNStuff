using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using GunsNstuff.Items.Weapons.Ammo;

namespace GunsNStuff.Items.Weapons
{
    public class Minigun : ModItem
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
			Item.damage = 3;
			Item.knockBack = 1f;
			Item.noMelee = true;
			Item.shootSpeed = 1000f;
			Item.value = Item.buyPrice(gold: 10);
            
			//shooting stuff
			Item.shoot = ModContent.ProjectileType<Projectiles.MinigunAmmoProjectile>();
            Item.useAmmo = ModContent.ItemType<MinigunAmmo>();
			//Item.shoot = ProjectileID.Bullet;
			//Item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IllegalGunParts, 2);
			recipe.AddIngredient(ItemID.IronBar, 30);
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddIngredient(ItemID.CopperBar, 10);
            Recipe recipe1 = recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
