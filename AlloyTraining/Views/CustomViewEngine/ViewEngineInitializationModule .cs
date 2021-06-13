using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Mvc;

namespace AlloyTraining.Views.CustomViewEngine
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ViewEngineInitializationModule : IInitializableModule

    {
        public void Initialize(InitializationEngine context)
        {
            ViewEngines.Engines.Add(new EpiserverViewEngine());
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}