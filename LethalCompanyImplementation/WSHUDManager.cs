using LethalCompany;

namespace LethalCompanyImplementation
{
	// Generated
	public class WSHUDManager : ISHUDManager
	{
		public IHUDManager Instance
		{
			get => WrapperFactory.Wrap<IHUDManager>(HUDManager.Instance);
		}

		public int someStaticField
		{
			// HUDManager doesn't have a static field but if
			// it did this is where you'd set and get it.
			get => 0 /* HUDManager.someStaticField */;
			set { } /* HUDManager.someStaticField = value */
		}
	}
}
