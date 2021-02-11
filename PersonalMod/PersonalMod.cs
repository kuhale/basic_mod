using Terraria.ModLoader;

namespace PersonalMod
{
	class PersonalMod : Mod
	{
		public PersonalMod()
		{

			Properties  = new ModProperties(){
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
