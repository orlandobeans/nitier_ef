﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator Northwind.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NTier.Common.Domain.Model;

namespace IntegrationTest.Common.Domain.Model.Northwind
{
    [Serializable]
    [DataContract]
    [KnownType("GetKnownTypes")]
    public partial class NorthwindOptimisticConcurrencyFault : NTier.Common.Domain.OptimisticConcurrencyFault
    {
        public NorthwindOptimisticConcurrencyFault(string message, IEnumerable<Entity> entities)
            : base(message, entities)
        {
        }

        private static Type[] GetKnownTypes()
        {
            var types = typeof(NorthwindOptimisticConcurrencyFault).Assembly.GetTypes()
                .Where(x => x.Namespace == typeof(NorthwindOptimisticConcurrencyFault).Namespace)
                .Where(x => typeof(Entity).IsAssignableFrom(x) )
                .Where(x => x.IsPublic)
                .Where(x => !x.IsAbstract)
                .ToArray();
            return types;
        }
    }
}