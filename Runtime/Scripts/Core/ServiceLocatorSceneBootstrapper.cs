using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndieGabo.HandyServiceLocator
{
    [AddComponentMenu("Handy Service Locator/ServiceLocator [Scene]")]
    public class ServiceLocatorSceneBootstrapper : ServiceBootstrapper
    {
        protected override void Bootstrap()
        {
            Container.ConfigureAsScene();
        }
    }
}