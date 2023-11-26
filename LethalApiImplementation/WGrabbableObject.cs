using LethalCompany;

namespace LethalCompanyImplementation
{
	// Generated
	[Wrapper(underlyingType: typeof(GrabbableObject))]
	public class WGrabbableObject : IGrabbableObject
	{
		internal GrabbableObject Underlying { get; }

		public bool itemUsedUp
		{
			get => Underlying.itemUsedUp;
			set => Underlying.itemUsedUp = value;
		}

		public WGrabbableObject(GrabbableObject underlying)
        {
			Underlying = underlying;
		}

		// Methods and properties of GrabbableObject
		// ...
	}
}
