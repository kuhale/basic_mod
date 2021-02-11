using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PersonalMod.Items
{
    public class TestingSword : ModItem {

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Testing Sword");
			Tooltip.SetDefault("Testing sword");
		}

		public override void SetDefaults() {
			item.damage = 100;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}



		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
