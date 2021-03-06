
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 22/10/2018 - 09:11 a. m.
// This is a partial class file. The other one is vw_TicketsMapper.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using BaseTicketRules.Entities;
using BaseTicketRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data.Common;
using System.Reflection;
using System.Web;
using System.Data;

namespace BaseTicketRules.Mappers
{

    
    /// <summary>
    /// 
    /// </summary>
    public partial class vw_TicketsMapper : BaseGateway<vw_TicketsObject, vw_TicketsObjectList>, IGenericGateway
    {


        #region "Singleton"

        static vw_TicketsMapper _instance;

        private vw_TicketsMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static vw_TicketsMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new vw_TicketsMapper();
                else {
                    vw_TicketsMapper inst = HttpContext.Current.Items["BaseTicketRules.vw_TicketsMapperSingleton"] as vw_TicketsMapper;
                    if (inst == null) {
                        inst = new vw_TicketsMapper();
                        HttpContext.Current.Items.Add("BaseTicketRules.vw_TicketsMapperSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={""};
            return s;
        }

        /// <summary>
        ///
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(vw_TicketsObject);
        }

        /// <summary>
        /// Return the mapped table name
        /// </summary>
        protected override string TableName
        {
            get { return "vw_Tickets"; }
        }

        /// <summary>
        /// Return the vw_TicketsMapper type FullName
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(vw_TicketsMapper).FullName;}
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
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(vw_TicketsObject entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeablevw_TicketsObject) entity).UpdateObjectFromOutputParams(parameters);
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


        

        // GetOne By Objects and Params
            


        


        

        


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

namespace BaseTicketRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class vw_TicketsMapperWrapper
    {

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            return Instance().GetPKPropertiesNames();
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return Instance().GetMappingType();
        }



        /// <summary>
        /// 
        /// </summary>
        public BaseTicketRules.Mappers.vw_TicketsMapper Instance()
        {
            return BaseTicketRules.Mappers.vw_TicketsMapper.Instance(); 
        }
        
        

        // GetBy Objects and Params
            

        

        /// <summary>
        /// GetAll vw_TicketsObject 
        /// </summary>
        public Objects.vw_TicketsObjectList GetAll(){  
            return Instance().GetAll();
        }

        


        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public vw_TicketsObjectList GetByNumero(System.String numero) {
            
                return Instance().GetByNumero( numero);
        }


        


    }
}





namespace BaseTicketRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class vw_TicketsLoader<T> : BaseLoader< T, vw_TicketsObject, ObjectList<T>>, IGenericGateway where T : vw_TicketsObject, new()
    {

        #region "Singleton"

        static vw_TicketsLoader<T> _instance;

        private vw_TicketsLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static vw_TicketsLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new vw_TicketsLoader<T>();
                else {
                    vw_TicketsLoader<T> inst = HttpContext.Current.Items["BaseTicketRules.vw_TicketsLoaderSingleton"] as vw_TicketsLoader<T>;
                    if (inst == null) {
                        inst = new vw_TicketsLoader<T>();
                        HttpContext.Current.Items.Add("BaseTicketRules.vw_TicketsLoaderSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={""};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(vw_TicketsObject);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "vw_Tickets"; }
        }

        
        /// <summary>
        /// If this table is read only
        /// </summary>
        protected override bool IsReadOnly()
        {
            return true;
        }
        

        

        
        /// <summary>
        /// 
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
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        



        /// <summary>
        /// Get a vw_Tickets by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a vw_TicketsList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        


        // GetOne By Objects and Params
            


        


        

        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByNumero(System.String numero) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "vw_Tickets_GetByNumero" , numero);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByNumero(DbTransaction transaction , System.String numero) {
            
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





