﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator Model2.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using NTier.Common.Domain.Model;
using NTier.Server.Domain.Repositories;
using TableInheritance.Common.Domain.Model.TableInheritanceDemoDB;

namespace TableInheritance.Server.Domain.Repositories
{
    public partial class TableInheritanceDemoDBRepository : NTier.Server.Domain.Repositories.EntityFramework.Repository, ITableInheritanceDemoDBRepository
    {
        #region Constructors

        public TableInheritanceDemoDBRepository()
            : base("name=TableInheritanceDemoDBEntities", "TableInheritanceDemoDBEntities")
        {
        }

        public TableInheritanceDemoDBRepository(string connectionString, string containerName = "TableInheritanceDemoDBEntities")
            : base(connectionString, containerName)
        {
        }

        public TableInheritanceDemoDBRepository(EntityConnection connection, string containerName = "TableInheritanceDemoDBEntities")
            : base(connection, containerName)
        {
        }

        #endregion Constructors

        #region EntitySets

        public IEntitySet<Person> People
        {
            get { return _people  ?? (_people = CreateEntitySet<Person>("People")); }
        }
        private IEntitySet<Person> _people;

        #endregion EntitySets
    }
}