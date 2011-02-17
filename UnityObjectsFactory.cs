using System;
using Microsoft.Practices.Unity;
using NHibernate.Bytecode;

namespace UnityBytecodeProvider
{
    public class UnityObjectsFactory : IObjectsFactory
    {
        private readonly IUnityContainer container;

        public UnityObjectsFactory(IUnityContainer container)
        {
            this.container = container;
        }

        public object CreateInstance(Type type, params object[] ctorArgs)
        {
            return Activator.CreateInstance(type, ctorArgs);
        }

        public object CreateInstance(Type type, bool nonPublic)
        {
            return Activator.CreateInstance(type, nonPublic);
        }

        public object CreateInstance(Type type)
        {
            return container.Resolve(type);
        }

    }
}
