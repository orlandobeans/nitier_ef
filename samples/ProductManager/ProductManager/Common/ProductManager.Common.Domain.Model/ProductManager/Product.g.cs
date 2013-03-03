//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator ProductModel.tt.
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

namespace ProductManager.Common.Domain.Model.ProductManager
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(ProductCategory))]
    public partial class Product : Entity<Product>, INotifyPropertyChanged, INotifyPropertyChanging, IDataErrorInfo
    {
        #region Constructor and Initialization

        // partial method for initialization
        partial void Initialize();

        public Product()
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
        public global::System.Int32 ProductID
        {
            get { return _productID; }
            set
            {
                if (_productID != value)
                {
                    //if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    if (!IsDeserializing && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ProductID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    ProductIDChanging(value);
                    OnPropertyChanging("ProductID", value);
                    var previousValue = _productID;
                    _productID = value;
                    OnPropertyChanged("ProductID", previousValue, value);
                    ProductIDChanged(previousValue);
                }
            }
        }
        private global::System.Int32 _productID;
        
        partial void ProductIDChanging(global::System.Int32 newValue);
        partial void ProductIDChanged(global::System.Int32 previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    NameChanging(value);
                    OnPropertyChanging("Name", value);
                    var previousValue = _name;
                    _name = value;
                    OnPropertyChanged("Name", previousValue, value);
                    NameChanged(previousValue);
                }
            }
        }
        private global::System.String _name;
        
        partial void NameChanging(global::System.String newValue);
        partial void NameChanged(global::System.String previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String ProductNumber
        {
            get { return _productNumber; }
            set
            {
                if (_productNumber != value)
                {
                    ProductNumberChanging(value);
                    OnPropertyChanging("ProductNumber", value);
                    var previousValue = _productNumber;
                    _productNumber = value;
                    OnPropertyChanged("ProductNumber", previousValue, value);
                    ProductNumberChanged(previousValue);
                }
            }
        }
        private global::System.String _productNumber;
        
        partial void ProductNumberChanging(global::System.String newValue);
        partial void ProductNumberChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    ColorChanging(value);
                    OnPropertyChanging("Color", value);
                    var previousValue = _color;
                    _color = value;
                    OnPropertyChanged("Color", previousValue, value);
                    ColorChanged(previousValue);
                }
            }
        }
        private global::System.String _color;
        
        partial void ColorChanging(global::System.String newValue);
        partial void ColorChanged(global::System.String previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.Decimal StandardCost
        {
            get { return _standardCost; }
            set
            {
                if (_standardCost != value)
                {
                    StandardCostChanging(value);
                    OnPropertyChanging("StandardCost", value);
                    var previousValue = _standardCost;
                    _standardCost = value;
                    OnPropertyChanged("StandardCost", previousValue, value);
                    StandardCostChanged(previousValue);
                }
            }
        }
        private global::System.Decimal _standardCost;
        
        partial void StandardCostChanging(global::System.Decimal newValue);
        partial void StandardCostChanged(global::System.Decimal previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.Decimal ListPrice
        {
            get { return _listPrice; }
            set
            {
                if (_listPrice != value)
                {
                    ListPriceChanging(value);
                    OnPropertyChanging("ListPrice", value);
                    var previousValue = _listPrice;
                    _listPrice = value;
                    OnPropertyChanged("ListPrice", previousValue, value);
                    ListPriceChanged(previousValue);
                }
            }
        }
        private global::System.Decimal _listPrice;
        
        partial void ListPriceChanging(global::System.Decimal newValue);
        partial void ListPriceChanged(global::System.Decimal previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.String Size
        {
            get { return _size; }
            set
            {
                if (_size != value)
                {
                    SizeChanging(value);
                    OnPropertyChanging("Size", value);
                    var previousValue = _size;
                    _size = value;
                    OnPropertyChanged("Size", previousValue, value);
                    SizeChanged(previousValue);
                }
            }
        }
        private global::System.String _size;
        
        partial void SizeChanging(global::System.String newValue);
        partial void SizeChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public Nullable<global::System.Decimal> Weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    WeightChanging(value);
                    OnPropertyChanging("Weight", value);
                    var previousValue = _weight;
                    _weight = value;
                    OnPropertyChanged("Weight", previousValue, value);
                    WeightChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.Decimal> _weight;
        
        partial void WeightChanging(Nullable<global::System.Decimal> newValue);
        partial void WeightChanged(Nullable<global::System.Decimal> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public Nullable<global::System.Int32> ProductCategoryID
        {
            get { return _productCategoryID; }
            set
            {
                if (_productCategoryID != value)
                {
                    //RecordOriginalValue("ProductCategoryID", _productCategoryID);
                    ProductCategoryIDChanging(value);
                    OnPropertyChanging("ProductCategoryID", value);
                    if (!IsDeserializing)
                    {
                        if (ProductCategory != null && ProductCategory.ProductCategoryID != value)
                        {
                            ProductCategory = null;
                        }
                    }
                    var previousValue = _productCategoryID;
                    _productCategoryID = value;
                    OnPropertyChanged("ProductCategoryID", previousValue, value);
                    ProductCategoryIDChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.Int32> _productCategoryID;
        
        partial void ProductCategoryIDChanging(Nullable<global::System.Int32> newValue);
        partial void ProductCategoryIDChanged(Nullable<global::System.Int32> previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.DateTime SellStartDate
        {
            get { return _sellStartDate; }
            set
            {
                if (_sellStartDate != value)
                {
                    SellStartDateChanging(value);
                    OnPropertyChanging("SellStartDate", value);
                    var previousValue = _sellStartDate;
                    _sellStartDate = value;
                    OnPropertyChanged("SellStartDate", previousValue, value);
                    SellStartDateChanged(previousValue);
                }
            }
        }
        private global::System.DateTime _sellStartDate;
        
        partial void SellStartDateChanging(global::System.DateTime newValue);
        partial void SellStartDateChanged(global::System.DateTime previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public Nullable<global::System.DateTime> SellEndDate
        {
            get { return _sellEndDate; }
            set
            {
                if (_sellEndDate != value)
                {
                    SellEndDateChanging(value);
                    OnPropertyChanging("SellEndDate", value);
                    var previousValue = _sellEndDate;
                    _sellEndDate = value;
                    OnPropertyChanged("SellEndDate", previousValue, value);
                    SellEndDateChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.DateTime> _sellEndDate;
        
        partial void SellEndDateChanging(Nullable<global::System.DateTime> newValue);
        partial void SellEndDateChanged(Nullable<global::System.DateTime> previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public Nullable<global::System.DateTime> DiscontinuedDate
        {
            get { return _discontinuedDate; }
            set
            {
                if (_discontinuedDate != value)
                {
                    DiscontinuedDateChanging(value);
                    OnPropertyChanging("DiscontinuedDate", value);
                    var previousValue = _discontinuedDate;
                    _discontinuedDate = value;
                    OnPropertyChanged("DiscontinuedDate", previousValue, value);
                    DiscontinuedDateChanged(previousValue);
                }
            }
        }
        private Nullable<global::System.DateTime> _discontinuedDate;
        
        partial void DiscontinuedDateChanging(Nullable<global::System.DateTime> newValue);
        partial void DiscontinuedDateChanged(Nullable<global::System.DateTime> previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.Guid rowguid
        {
            get { return _rowguid; }
            set
            {
                if (_rowguid != value)
                {
                    rowguidChanging(value);
                    OnPropertyChanging("rowguid", value);
                    var previousValue = _rowguid;
                    _rowguid = value;
                    OnPropertyChanged("rowguid", previousValue, value);
                    rowguidChanged(previousValue);
                }
            }
        }
        private global::System.Guid _rowguid;
        
        partial void rowguidChanging(global::System.Guid newValue);
        partial void rowguidChanged(global::System.Guid previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        public global::System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    ModifiedDateChanging(value);
                    OnPropertyChanging("ModifiedDate", value);
                    var previousValue = _modifiedDate;
                    _modifiedDate = value;
                    OnPropertyChanged("ModifiedDate", previousValue, value);
                    ModifiedDateChanged(previousValue);
                }
            }
        }
        private global::System.DateTime _modifiedDate;
        
        partial void ModifiedDateChanging(global::System.DateTime newValue);
        partial void ModifiedDateChanged(global::System.DateTime previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [PrimitiveProperty]
        private global::System.String DynamicContent
        {
            get { return _dynamicContent; }
            set
            {
                if (_dynamicContent != value)
                {
                    DynamicContentChanging(value);
                    OnPropertyChanging("DynamicContent", value);
                    var previousValue = _dynamicContent;
                    _dynamicContent = value;
                    OnPropertyChanged("DynamicContent", previousValue, value);
                    DynamicContentChanged(previousValue);
                }
            }
        }
        private global::System.String _dynamicContent;
        
        partial void DynamicContentChanging(global::System.String newValue);
        partial void DynamicContentChanged(global::System.String previousValue);

        #endregion Primitive Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        [DataMember]
        [NavigationProperty]
        public ProductCategory ProductCategory
        {
            get { return _productCategory; }
            set
            {
                if (!object.ReferenceEquals(_productCategory, value))
                {
                    ProductCategoryChanging(value);
                    OnPropertyChanging("ProductCategory", value);
                    var previousValue = _productCategory;
                    _productCategory = value;
                    FixupProductCategory(previousValue);
                    OnPropertyChanged("ProductCategory", previousValue, value, isNavigationProperty: true);
                    ProductCategoryChanged(previousValue);
                }
            }
        }
        private ProductCategory _productCategory;
        
        partial void ProductCategoryChanging(ProductCategory newValue);
        partial void ProductCategoryChanged(ProductCategory previousValue);

        #endregion Navigation Properties

        #region ChangeTracking

        protected override void ClearNavigationProperties()
        {
            ProductCategory = null;
        }

        #endregion ChangeTracking

        #region Association Fixup

        private void FixupProductCategory(ProductCategory previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (ProductCategory != null)
            {
                ProductCategoryID = ProductCategory.ProductCategoryID;
            }

            else if (!skipKeys)
            {
                ProductCategoryID = null;
            }

            if (ChangeTracker.IsChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("ProductCategory")
                    && object.ReferenceEquals(ChangeTracker.OriginalValues["ProductCategory"], ProductCategory))
                {
                    //ChangeTracker.OriginalValues.Remove("ProductCategory");
                }
                else
                {
                    //RecordOriginalValue("ProductCategory", previousValue);
                }
                if (ProductCategory != null && !ProductCategory.ChangeTracker.IsChangeTrackingEnabled)
                {
                    ProductCategory.StartTracking();
                }
            }
        }

        #endregion Association Fixup

        protected override bool IsKeyEqual(Product entity)
        {
            return this.ProductID == entity.ProductID;
        }

        protected override int GetKeyHashCode()
        {
            return this.ProductID.GetHashCode();
        }
    }
}
