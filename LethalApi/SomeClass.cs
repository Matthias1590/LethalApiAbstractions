using LethalCompany;
using LethalCompany.Extensions;
using UnityEngine;

namespace LethalApi
{
	public class SomeClass
    {
        public void DoStuff()
        {
			// LethalApi does not depend on the game assemblies, so it can be
			// built without having the game installed. LethalApi interacts
			// with the game through abstractions. The actual implementations
			// get injected by the bootstrapper when it gets loaded.
			
			// Example usage:

			AddScrap(Static.HUDManager.Instance, null);

			var someItemGameObject = (GameObject) null;

			var someItemUsedUp = someItemGameObject
				.GetWrappedComponent<IGrabbableObject>()
				.itemUsedUp;
		}

		void AddScrap(IHUDManager hudManager, IGrabbableObject scrap)
		{
			hudManager.AddNewScrapFoundToDisplay(scrap);
		}
    }
}
