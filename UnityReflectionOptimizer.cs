using System;
using Microsoft.Practices.Unity;
using NHibernate.Bytecode.Lightweight;
using NHibernate.Properties;

namespace UnityBytecodeProvider
{
    public class UnityReflectionOptimizer : ReflectionOptimizer
    {
        private IUnityContainer container;

        public UnityReflectionOptimizer(IUnityContainer container, Type mappedType, IGetter[] getters, ISetter[] setters)
            : base(mappedType, getters, setters)
        {
            this.container = container;
        }

        /// <summary>
        /// Ignore this check
        /// </summary>
        /// <param name="type"></param>
        protected override void ThrowExceptionForNoDefaultCtor(Type type)
        {
        }

        public override object CreateInstance()
        {
            return container.Resolve(mappedType);
        }
    }
}
