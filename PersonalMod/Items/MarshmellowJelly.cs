using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PersonalMod.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class MarshmellowJelly : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marshmellow Jelly");
			Tooltip.SetDefault("Vanity\nYou did this");
		}
		public override void SetDefaults()
		{
			item.rare = 9;
			item.value = 0;
			item.width = 40;
			item.height = 30;
			item.vanity = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient();
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool DrawHead()
        {
            return false;     //this make so the player head does not disappear when the vanity mask is equipped.  return false if you want to not show the player head.
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;  //this make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
	}
}
