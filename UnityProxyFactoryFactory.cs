using System;
using NHibernate.Bytecode;
using NHibernate.ByteCode.Castle;
using NHibernate.Proxy;

namespace UnityBytecodeProvider
{
    public class UnityProxyFactoryFactory : IProxyFactoryFactory
    {
        #region IProxyFactoryFactory Members

        public IProxyFactory BuildProxyFactory()
        {
            return new ProxyFactory();
        }

        public bool IsInstrumented(Type entityClass)
        {
            return false;
        }

        public NHibernate.Proxy.IProxyValidator ProxyValidator
        {
            get
            {
                return new UnityProxyTypeValidator();
            }
        }

        #endregion
    }
}
