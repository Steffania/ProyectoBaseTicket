
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 21/10/2018 - 07:40 p. m.
// This is a partial class file. The other one is vw_TicketsGateway.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using BaseTicketRules.Objects;
using Cooperator.Framework.Core;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using System.Data.Common;
using System.Reflection;
using System;

namespace BaseTicketRules.Gateways
{

    /// <summary>
    /// Gateway between vw_TicketsObject class and vw_Tickets table.
    /// This class provide CRUD methods for vw_Tickets table.
    /// </summary>
    public partial class vw_TicketsGateway
    {
        // /// <summary>
        // /// Enables GetObjectBySQLText and GetObjectListBySQLText methods.
        // /// </summary>
        //protected override bool SQLQueriesEnabled()
        //{
        //    return true;
        //}


        // /// <summary>
        // /// Checks for security ritghs
        // /// </summary>
        //protected override bool CheckForSecurityRights(SecurityRights action, vw_TicketsObjectList ObjectListOrEntityList)
        //{
        //    switch (action)
        //    {
        //        case SecurityRights.Read:
        //            return true;
        //        case SecurityRights.Insert:
        //            return true;
        //        case SecurityRights.Update:
        //            return true;
        //        case SecurityRights.Delete:
        //            return true;
        //    }
        //    return false;
        //}

    }

}


