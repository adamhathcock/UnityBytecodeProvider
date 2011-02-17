﻿using System;
using NHibernate.Proxy;

namespace UnityBytecodeProvider
{
    public class UnityProxyTypeValidator : DynProxyTypeValidator
    {

        /// <summary>
        /// Ignore this check
        /// </summary>
        /// <param name="type"></param>
        /// <remarks>Do nothing. Since we're using constructor
        /// injection with NHibernate, our entities will have parameters.</remarks>
        protected override void CheckHasVisibleDefaultConstructor(Type type)
        {
        }
    }
}
