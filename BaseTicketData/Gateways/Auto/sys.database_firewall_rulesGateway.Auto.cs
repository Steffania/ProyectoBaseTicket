
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 22/10/2018 - 09:11 a. m.
// This is a partial class file. The other one is database_firewall_rulesGateway.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using BaseTicketRules.Objects.sys;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Web;



namespace BaseTicketRules.Entities.sys
{
    // Only for ensure the namespace generation.
}



namespace BaseTicketRules.Gateways.sys
{
    /// <summary>
    /// 
    /// </summary>
    public partial class database_firewall_rulesGateway : BaseGateway<database_firewall_rulesObject, database_firewall_rulesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static database_firewall_rulesGateway _instance;

        private database_firewall_rulesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static database_firewall_rulesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new database_firewall_rulesGateway();
                else {
                    database_firewall_rulesGateway inst = HttpContext.Current.Items["BaseTicketRules.database_firewall_rulesGatewaySingleton"] as database_firewall_rulesGateway;
                    if (inst == null) {
                        inst = new database_firewall_rulesGateway();
                        HttpContext.Current.Items.Add("BaseTicketRules.database_firewall_rulesGatewaySingleton", inst);
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
            get { return "sys.database_firewall_rules"; }
        }

        /// <summary>
        /// Return the database_firewall_rulesGateway type FullName
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(database_firewall_rulesGateway).FullName;}
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
        protected override void HydrateFields(DbDataReader reader, database_firewall_rulesObject entity)
        {
            
            IMappeabledatabase_firewall_rulesObject database_firewall_rules = (IMappeabledatabase_firewall_rulesObject)entity;
            database_firewall_rules.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetString(3),
reader.GetDateTime(4),
reader.GetDateTime(5));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(database_firewall_rulesObject entity)
        {

            IMappeabledatabase_firewall_rulesObject database_firewall_rules = (IMappeabledatabase_firewall_rulesObject)entity;
            return database_firewall_rules.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(database_firewall_rulesObject entity)
        {

            IMappeabledatabase_firewall_rulesObject database_firewall_rules = (IMappeabledatabase_firewall_rulesObject)entity;
            return database_firewall_rules.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(database_firewall_rulesObject entity)
        {

            IMappeabledatabase_firewall_rulesObject database_firewall_rules = (IMappeabledatabase_firewall_rulesObject)entity;
            return database_firewall_rules.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(database_firewall_rulesObject row, object[] parameters)
        {
            ((IMappeabledatabase_firewall_rulesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a database_firewall_rulesObject by execute a SQL Query Text
        /// </summary>
        public database_firewall_rulesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a database_firewall_rulesObjectList by execute a SQL Query Text
        /// </summary>
        public database_firewall_rulesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a database_firewall_rulesObject by calling a Stored Procedure
        /// </summary>
        public database_firewall_rulesObject GetOne()
        {
            return base.GetOne(new database_firewall_rulesObject());
        }


        // GetBy Objects and Params
            


        

        

        


        //Database Queries 
        



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








