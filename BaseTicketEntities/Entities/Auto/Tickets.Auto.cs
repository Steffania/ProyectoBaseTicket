
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.3.0
// Created: 22/10/2018 - 09:11 a. m.
// This is a partial class file. The other one is TicketsEntity.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using BaseTicketRules.Objects;

using BaseTicketRules.Objects.sys;


using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using System;

namespace BaseTicketRules.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Tickets : Objects.TicketsObject, IMappeableTickets, IEquatable<Tickets>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Tickets()
            :base()
        {
            if (_AreaEntity == null) _AreaEntity = new Objects.AreaObject();

        }

        
        /// <summary>
        /// 
        /// </summary>
        public Tickets(
			System.Int32 TicketId)
            : base()
        {

			_TicketId = TicketId;

            if (_AreaEntity == null) _AreaEntity = new Objects.AreaObject();

            Initialized();
        }
        

        

        /// <summary>
        /// 
        /// </summary>
        public Tickets(
			System.Int32 TicketId,
			System.String Numero,
			System.Int32 AreaId,
			System.String Nombre,
			System.String Apellido,
			System.String Telefono,
			System.String Email,
			System.DateTime FechaTicket,
			System.String Descripcion)
            : base()
        {

			_TicketId = TicketId;
			_Numero = Numero;
			_AreaId = AreaId;
			_Nombre = Nombre;
			_Apellido = Apellido;
			_Telefono = Telefono;
			_Email = Email;
			_FechaTicket = FechaTicket;
			_Descripcion = Descripcion;

            if (_AreaEntity == null) _AreaEntity = new Objects.AreaObject();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Objects.AreaObject _AreaEntity;

        #endregion

        #region "Properties"
        
bool _AreaEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Objects.AreaObject AreaEntity
        {
            get
            {
                if (_AreaEntity== null  && ! _AreaEntityFetched ) {
_AreaEntityFetched = true;
Objects.AreaObject _AreaEntityTemp = new Objects.AreaObject(this.AreaId); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Objects.AreaObject));
 _AreaEntity = lazyProvider.GetEntity(typeof(Objects.AreaObject), _AreaEntityTemp) as Objects.AreaObject;
}

                return _AreaEntity;
            }
            set
            {
                base.PropertyModified();
                _AreaEntity = value;
                if (value != null) {
   _AreaId = value.AreaId;

} else {
   _AreaId = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new Tickets OriginalValue()
        {
            return (Tickets)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Tickets newObject;            
            

            newObject = (Tickets)this.MemberwiseClone();
            // Entities
                         
            if (this._AreaEntity != null)
            {
                newObject._AreaEntity = (Objects.AreaObject)((ICloneable)this._AreaEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            Tickets newOriginalValue;
            if (base.InternalOriginalValue != null)
            {
                newOriginalValue = (Tickets)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._AreaEntity != null)
                {
                    newOriginalValue._AreaEntity = (Objects.AreaObject)((ICloneable)this.OriginalValue()._AreaEntity).Clone();
                }
                
                // Colections
                            
                newObject.InternalOriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableTickets.CompleteEntity(Objects.AreaObject AreaEntity)
        {
        _AreaEntity = AreaEntity;
        }
        
        bool IMappeableTickets.IsAreaEntityNull()
        {
            return (_AreaEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableTickets.SetFKValuesForChilds(Tickets entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Tickets other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableTickets
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Objects.AreaObject AreaEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsAreaEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(Tickets entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class TicketsList : ObjectList<Tickets>
    {
    }
}
namespace BaseTicketRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class TicketsListView
        : ObjectListView<Entities.Tickets>
    {
        /// <summary>
        /// 
        /// </summary>
        public TicketsListView(Entities.TicketsList list): base(list)
        {
        }
    }
}


