
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 22/10/2018 - 09:11 a. m.
// This is a partial class file. The other one is vw_TicketsGateway.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using BaseTicketRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Web;




namespace BaseTicketRules.Gateways
{
    /// <summary>
    /// 
    /// </summary>
    public partial class vw_TicketsGateway : BaseGateway<vw_TicketsObject, vw_TicketsObjectList>, IGenericGateway
    {

        #region "Singleton"

        static vw_TicketsGateway _instance;

        private vw_TicketsGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static vw_TicketsGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new vw_TicketsGateway();
                else {
                    vw_TicketsGateway inst = HttpContext.Current.Items["BaseTicketRules.vw_TicketsGatewaySingleton"] as vw_TicketsGateway;
                    if (inst == null) {
                        inst = new vw_TicketsGateway();
                        HttpContext.Current.Items.Add("BaseTicketRules.vw_TicketsGatewaySingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }

        #endregion

        /// <summary>
        /// Return the mapped table name
        /// </summary>
        protected override string TableName
        {
            get { return "vw_Tickets"; }
        }

        /// <summary>
        /// Return the vw_TicketsGateway type FullName
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(vw_TicketsGateway).FullName;}
        }


        
        /// <summary>
        /// If this table is read only
        /// </summary>
        protected override bool IsReadOnly()
        {
            return true;
        }
        

        


        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, vw_TicketsObject entity)
        {
            
            IMappeablevw_TicketsObject vw_Tickets = (IMappeablevw_TicketsObject)entity;
            vw_Tickets.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetString(3),
reader.GetString(4),
reader.GetString(5),
reader.GetDateTime(6),
reader.GetString(7),
reader.GetString(8));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(vw_TicketsObject entity)
        {

            IMappeablevw_TicketsObject vw_Tickets = (IMappeablevw_TicketsObject)entity;
            return vw_Tickets.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(vw_TicketsObject entity)
        {

            IMappeablevw_TicketsObject vw_Tickets = (IMappeablevw_TicketsObject)entity;
            return vw_Tickets.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(vw_TicketsObject entity)
        {

            IMappeablevw_TicketsObject vw_Tickets = (IMappeablevw_TicketsObject)entity;
            return vw_Tickets.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(vw_TicketsObject row, object[] parameters)
        {
            ((IMappeablevw_TicketsObject) row).UpdateObjectFromOutputParams(parameters);
            ((IObject)row).State = ObjectState.Restored;
        }

        /// <summary>
        /// StoredProceduresPrefix, for example: coop_
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        /// <summary>
        /// Get a vw_TicketsObject by execute a SQL Query Text
        /// </summary>
        public vw_TicketsObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a vw_TicketsObjectList by execute a SQL Query Text
        /// </summary>
        public vw_TicketsObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a vw_TicketsObject by calling a Stored Procedure
        /// </summary>
        public vw_TicketsObject GetOne()
        {
            return base.GetOne(new vw_TicketsObject());
        }


        // GetBy Objects and Params
            


        

        

        


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public vw_TicketsObjectList GetByNumero(System.String numero) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "vw_Tickets_GetByNumero" , numero);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public vw_TicketsObjectList GetByNumero(DbTransaction transaction , System.String numero) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "vw_Tickets_GetByNumero" , numero);
            
        }


        



        #region IGenericGateway

        object IGenericGateway.GetOne(IUniqueIdentifiable identifier)
        {
            return base.GetOne(identifier);
        }

        object IGenericGateway.GetAll()
        {
            return base.GetAll();
        }

        object IGenericGateway.GetByParent(IUniqueIdentifiable parentEntity)
        {
            return base.GetByParent(parentEntity);
        }

        #endregion


    }

}








