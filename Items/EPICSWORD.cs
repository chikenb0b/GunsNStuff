using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//hey yall lemme say hey yall
namespace GunsNStuff.Items
{
	public class EPICSWORD : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("EPICSWORD"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 100;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6000;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar, 1000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}