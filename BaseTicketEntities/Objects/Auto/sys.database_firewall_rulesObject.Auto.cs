
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 22/10/2018 - 09:11 a. m.
// This is a partial class file. The other one is database_firewall_rulesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace BaseTicketRules.Objects.sys
{
    /// <summary>
    /// 
    /// </summary>
    public partial class database_firewall_rulesObject : BaseObject, IMappeabledatabase_firewall_rulesObject, IUniqueIdentifiable, IEquatable<database_firewall_rulesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public database_firewall_rulesObject(): base()
        {


        }

        

        
        /// <summary>
        /// 
        /// </summary>
        public database_firewall_rulesObject(
			System.Int32 id,
			System.String name,
			System.String start_ip_address,
			System.String end_ip_address,
			System.DateTime create_date,
			System.DateTime modify_date): base()
        {

			_id = id;
			_name = name;
			_start_ip_address = start_ip_address;
			_end_ip_address = end_ip_address;
			_create_date = create_date;
			_modify_date = modify_date;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _id;
/// <summary>
/// 
/// </summary>
protected System.String _name;
/// <summary>
/// 
/// </summary>
protected System.String _start_ip_address;
/// <summary>
/// 
/// </summary>
protected System.String _end_ip_address;
/// <summary>
/// 
/// </summary>
protected System.DateTime _create_date;
/// <summary>
/// 
/// </summary>
protected System.DateTime _modify_date;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 id
        {
            get
            {
                return _id;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String name
        {
            get
            {
                return _name;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String start_ip_address
        {
            get
            {
                return _start_ip_address;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String end_ip_address
        {
            get
            {
                return _end_ip_address;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime create_date
        {
            get
            {
                return _create_date;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime modify_date
        {
            get
            {
                return _modify_date;
            }
            
        }
        
        #endregion

                
        /// <summary>
        /// 
        /// </summary>
        protected override void SetOriginalValue()
        {
            base.InternalOriginalValue = (IObject) this.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            database_firewall_rulesObject newObject;
            database_firewall_rulesObject newOriginalValue;

            newObject = (database_firewall_rulesObject) this.MemberwiseClone();
            if (base.InternalOriginalValue != null)
            {
                newOriginalValue = (database_firewall_rulesObject)this.OriginalValue().MemberwiseClone();
                newObject.InternalOriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new database_firewall_rulesObject OriginalValue()
        {
            return (database_firewall_rulesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeabledatabase_firewall_rulesObject.HydrateFields(
			System.Int32 id,
			System.String name,
			System.String start_ip_address,
			System.String end_ip_address,
			System.DateTime create_date,
			System.DateTime modify_date)
        {
        	_id = id;
			_name = name;
			_start_ip_address = start_ip_address;
			_end_ip_address = end_ip_address;
			_create_date = create_date;
			_modify_date = modify_date;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeabledatabase_firewall_rulesObject.GetFieldsForInsert()
        {
        
        
            object[] _myArray = new object[1];
            _myArray[0] = _id;
			
            return _myArray;
        
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeabledatabase_firewall_rulesObject.GetFieldsForUpdate()
        {
        
        
            
            object[] _myArray = new object[1];
            _myArray[0] = _id;
			
            return _myArray;
        
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeabledatabase_firewall_rulesObject.GetFieldsForDelete()
        {
        
            throw new NotSupportedException();
        
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeabledatabase_firewall_rulesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _id = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            database_firewall_rulesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.id, o.name, o.start_ip_address, o.end_ip_address, o.create_date, o.modify_date};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(database_firewall_rulesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeabledatabase_firewall_rulesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 id, 
			System.String name, 
			System.String start_ip_address, 
			System.String end_ip_address, 
			System.DateTime create_date, 
			System.DateTime modify_date);

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForInsert();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForUpdate();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForDelete();

        /// <summary>
        /// 
        /// </summary>
        void UpdateObjectFromOutputParams(object[] parameters);
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class database_firewall_rulesObjectList : ObjectList<database_firewall_rulesObject>
    {
    }
}

namespace BaseTicketRules.Views.sys
{
    /// <summary>
    /// 
    /// </summary>
    public partial class database_firewall_rulesObjectListView
        : ObjectListView<Objects.sys.database_firewall_rulesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public database_firewall_rulesObjectListView(Objects.sys.database_firewall_rulesObjectList list): base(list)
        {
        }
    }
}


