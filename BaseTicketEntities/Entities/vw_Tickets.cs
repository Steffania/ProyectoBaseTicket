
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 21/10/2018 - 07:45 p. m.
// This is a partial class file. The other one is vw_TicketsEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace BaseTicketRules.Entities
{
    /// <summary>
    /// This class represents the vw_Tickets entity.
    /// </summary>
    [Serializable]
    public partial class vw_Tickets
        // : IValidable
    {
        // /// <summary>
        // /// When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        // /// </summary>
        // public void Validate()
        // {
        //     //Example:
        //     if (string.IsNullOrEmpty(this.Name)) throw new RuleValidationException("Name can't be null");
        // }
    }

    /// <summary>
    /// This class represents a collection of vw_Tickets entity.
    /// </summary>
    public partial class vw_TicketsList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<vw_Tickets, vw_TicketsList> Exporter = new ObjectListHelper<vw_Tickets, vw_TicketsList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace BaseTicketRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of vw_Tickets entities.
    /// </summary>
    public partial class vw_TicketsListView
    {
    }
}

