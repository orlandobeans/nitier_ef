﻿//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator DemoModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ConcurrencyDemo.Common.Domain.Model.ConcurrencyTest;
using NTier.Common.Domain.Model;

namespace ConcurrencyDemo.Common.Domain.Service.Contracts
{
    [ServiceContract]
    public partial interface IConcurrencyTestDataService
    {
        [OperationContract]
        QueryResult<ARecord> GetARecords(ClientInfo clientInfo, Query query);

        [OperationContract]
        QueryResult<BRecord> GetBRecords(ClientInfo clientInfo, Query query);

        [OperationContract]
        QueryResult<CRecord> GetCRecords(ClientInfo clientInfo, Query query);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        ConcurrencyTestResultSet SubmitChanges(ClientInfo clientInfo, ConcurrencyTestChangeSet changeSet);
    }
}