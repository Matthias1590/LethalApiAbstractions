using LethalCompany;
using LethalCompanyImplementation;
using System.Reflection;

namespace BootStrapper
{
	// Generated
	public class BepinexPluginOrSomething
    {
        public void OnLoad()
        {
            TypeMap.RegisterImplementationAssembly(Assembly.Load("LethalCompanyImplementation"));

            // All static classes would be created when the bootstrapper loads.
            Static.HUDManager = new WSHUDManager();
        }
    }
}
