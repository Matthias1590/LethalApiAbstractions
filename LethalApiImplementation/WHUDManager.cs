using LethalCompany;

namespace LethalCompanyImplementation
{
	// Generated
	[Wrapper(underlyingType: typeof(HUDManager))]
	public class WHUDManager : IHUDManager
    {
		internal HUDManager Underlying { get; }

		public WHUDManager(HUDManager underlying)
        {
			Underlying = underlying;
		}

		public void AddNewScrapFoundToDisplay(IGrabbableObject grabbableObject)
		{
			Underlying.AddNewScrapFoundToDisplay(((WGrabbableObject)grabbableObject).Underlying);
		}

		// More methods and properties
		// ...
	}
}
