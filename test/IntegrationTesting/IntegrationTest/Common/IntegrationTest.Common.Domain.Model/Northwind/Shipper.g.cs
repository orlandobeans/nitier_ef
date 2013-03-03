//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator NorthwindModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using NTier.Common.Domain.Model;

namespace IntegrationTest.Common.Domain.Model.Northwind
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Order))]
    public partial class Shipper : Entity<Shipper>, INotifyPropertyChanged, INotifyPropertyChanging, IDataErrorInfo
    {
        #region Constructor and Initialization

        // partial method for initialization
        partial void Initialize();

        public Shipper()
        {
            Initialize();
        }

        #endregion Constructor and Initialization

        #region Primitive Properties

        [DataMember]
        [Key]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ServerGeneration(ServerGenerationTypes.Insert)]
        [PrimitiveProperty]
        public global::System.Int32 ShipperID
        {
            get { return _shipperID; }
            set
            {
                if (_shipperID != value)
                {
                    //if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    if (!IsDeserializing && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ShipperID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    ShipperIDChanging(value);
                    OnPropertyChanging("ShipperID", value);
                    var previousValue = _shipperID;
                    _shipperID = value;
                    OnPropertyChanged("ShipperID", previousValue, value);
                    ShipperIDChanged(previousValue);
                }
            }
        }
        private global::System.Int32 _shipperID;
        
        partial void ShipperIDChanging(global::System.Int32 newValue);
        partial void ShipperIDChanged(global::System.Int32 previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String CompanyName
        {
            get { return _companyName; }
            set
            {
                if (_companyName != value)
                {
                    CompanyNameChanging(value);
                    OnPropertyChanging("CompanyName", value);
                    var previousValue = _companyName;
                    _companyName = value;
                    OnPropertyChanged("CompanyName", previousValue, value);
                    CompanyNameChanged(previousValue);
                }
            }
        }
        private global::System.String _companyName;
        
        partial void CompanyNameChanging(global::System.String newValue);
        partial void CompanyNameChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    PhoneChanging(value);
                    OnPropertyChanging("Phone", value);
                    var previousValue = _phone;
                    _phone = value;
                    OnPropertyChanged("Phone", previousValue, value);
                    PhoneChanged(previousValue);
                }
            }
        }
        private global::System.String _phone;
        
        partial void PhoneChanging(global::System.String newValue);
        partial void PhoneChanged(global::System.String previousValue);

        #endregion Primitive Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        [DataMember]
        [NavigationProperty]
        public TrackableCollection<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new TrackableCollection<Order>();
                    _orders.CollectionChanged += FixupOrders;
                }
                return _orders;
            }
            set
            {
                if (!object.ReferenceEquals(_orders, value))
                {
                    if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }

                    if (_orders != null)
                    {
                       _orders.CollectionChanged -= FixupOrders;
                    }

                    _orders = value;

                    if (_orders != null)
                    {
                        _orders.CollectionChanged += FixupOrders;
                    }

                    OnPropertyChanged("Orders", trackInChangeTracker: false);
                }
            }
        }
        private TrackableCollection<Order> _orders;

        #endregion Navigation Properties

        #region ChangeTracking

        protected override void ClearNavigationProperties()
        {
            Orders.Clear();
        }

        #endregion ChangeTracking

        #region Association Fixup

        private void FixupOrders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (e.NewItems != null)
            {
                foreach (Order item in e.NewItems)
                {
                    item.Shipper = this;
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.IsChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        RecordAdditionToCollectionProperties("Orders", item);
                    }
                }
            }

            if (e.OldItems != null)
            {
                foreach (Order item in e.OldItems)
                {
                    if (object.ReferenceEquals(item.Shipper, this))
                    {
                        item.Shipper = null;
                    }
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        RecordRemovalFromCollectionProperties("Orders", item);
                    }
                }
            }
        }

        #endregion Association Fixup

        protected override bool IsKeyEqual(Shipper entity)
        {
            return this.ShipperID == entity.ShipperID;
        }

        protected override int GetKeyHashCode()
        {
            return this.ShipperID.GetHashCode();
        }
    }
}
