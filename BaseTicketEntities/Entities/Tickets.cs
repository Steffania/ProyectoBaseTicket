
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 20/10/2018 - 12:37 p. m.
// This is a partial class file. The other one is TicketsEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace BaseTicketRules.Entities
{
    /// <summary>
    /// This class represents the Tickets entity.
    /// </summary>
    [Serializable]
    public partial class Tickets
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
    /// This class represents a collection of Tickets entity.
    /// </summary>
    public partial class TicketsList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<Tickets, TicketsList> Exporter = new ObjectListHelper<Tickets, TicketsList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace BaseTicketRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of Tickets entities.
    /// </summary>
    public partial class TicketsListView
    {
    }
}


