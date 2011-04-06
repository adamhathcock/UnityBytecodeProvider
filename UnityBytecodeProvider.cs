using System;
using Microsoft.Practices.Unity;
using NHibernate.Bytecode;
using NHibernate.Properties;
using NHibernate.Type;

namespace UnityBytecodeProvider
{
    public class UnityBytecodeProvider : IBytecodeProvider
    {
        private readonly IUnityContainer container;

        public UnityBytecodeProvider(IUnityContainer container)
        {
            this.container = container;
            CollectionTypeFactory = new DefaultCollectionTypeFactory();
            ObjectsFactory = new UnityObjectsFactory(container);
            ProxyFactoryFactory = new UnityProxyFactoryFactory();
        }

        #region IBytecodeProvider Members

        public ICollectionTypeFactory CollectionTypeFactory { get; private set; }

        public IReflectionOptimizer GetReflectionOptimizer(Type clazz, IGetter[] getters, ISetter[] setters)
        {
            return new UnityReflectionOptimizer(container, clazz, getters, setters);
        }

        public IObjectsFactory ObjectsFactory { get; private set; }

        public IProxyFactoryFactory ProxyFactoryFactory { get; private set; }

        #endregion
    }
}