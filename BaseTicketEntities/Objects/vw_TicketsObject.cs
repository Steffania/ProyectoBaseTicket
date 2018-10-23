
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 21/10/2018 - 07:40 p. m.
// This is a partial class file. The other one is vw_TicketsObject.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core;
using Cooperator.Framework.Core.Exceptions;

namespace BaseTicketRules.Objects
{
    /// <summary>
    /// This class represents a Object of vw_Tickets table.
    /// </summary>
    [Serializable]
    public partial class vw_TicketsObject
        // : IValidable
    {

        /// <summary>
        /// Called from class constructor.
        /// </summary>
        protected override void Initialize()
        {
        }

        // /// <summary>
        // /// Called after parameterized constructor. 
        // /// </summary>
        // protected override void Initialized()
        // {       
        // //Warnging: This method is only called by parameterized contructors.
        // }

        // /// <summary>
        // /// When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        // /// </summary>
        // public void Validate()
        // {
        //     string msgRequired = "{0} can't be null";
        //     string msgOutOfRange = "{0} incorrect value";

        
        // }
    }

    /// <summary>
    /// This class represents a record set of vw_Tickets table.
    /// </summary>
    public partial class vw_TicketsObjectList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         // public override System.Data.DataSet ToDataSet()
         // {
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<vw_TicketsObject, vw_TicketsObjectList> Exporter = new ObjectListHelper<vw_TicketsObject, vw_TicketsObjectList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         // }
    }
}

namespace BaseTicketRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of vw_TicketsObjects.
    /// </summary>
    public partial class vw_TicketsObjectListView
    {
    }
}

