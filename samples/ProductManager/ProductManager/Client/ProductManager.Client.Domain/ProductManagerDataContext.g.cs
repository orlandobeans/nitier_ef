//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator ProductModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Transactions;
using NTier.Client.Domain;
using NTier.Client.Domain.Service.ChannelFactory;
using NTier.Common.Domain.Model;
using ProductManager.Common.Domain.Model.ProductManager;
using ProductManager.Common.Domain.Service.Contracts;

namespace ProductManager.Client.Domain
{
    public sealed partial class ProductManagerDataContext : DataContext<ProductManagerResultSet>, IProductManagerDataContext
    {
        #region Private Members

        [Import(typeof(IChannelFactory<IProductManagerDataService>))]
        private IChannelFactory<IProductManagerDataService> ChannelFactory { get; set; }

        private readonly InternalEntitySet<Product> _products;
        private readonly InternalEntitySet<ProductCategory> _productCategories;

        #endregion Private Members

        #region Contructor

        partial void Initialize();
        
        private ProductManagerDataContext(bool dummyParameter)
        {
            _products = CreateAndRegisterInternalEntitySet<Product>();
            _productCategories = CreateAndRegisterInternalEntitySet<ProductCategory>();
        }

        public ProductManagerDataContext(string endpointConfigurationName = "ProductManagerDataService")
            : this(true)
        {
            #region MEF composition: inject service factory

            var catalog = new System.ComponentModel.Composition.Hosting.AggregateCatalog();

            // AppDomain.CurrentDomain.BaseDirectory
            var directoryCatalog = new System.ComponentModel.Composition.Hosting.DirectoryCatalog(".");
            catalog.Catalogs.Add(directoryCatalog);

            // ASP.NET / Visual Studio dev webserver uses bin subdirectory to store assemblies
            var direcotry = System.IO.Path.Combine(directoryCatalog.FullPath, "bin");
            if (System.IO.Directory.Exists(direcotry))
            {
                directoryCatalog = new System.ComponentModel.Composition.Hosting.DirectoryCatalog(direcotry);
                catalog.Catalogs.Add(directoryCatalog);
            }
            var container = new System.ComponentModel.Composition.Hosting.CompositionContainer(catalog);

            container.ComposeExportedValue(endpointConfigurationName);
            container.ComposeParts(this);

            #endregion
            
            Initialize();
        }

        public ProductManagerDataContext(IChannelFactory<IProductManagerDataService> channelFactory)
            : this(true)
        {
            this.ChannelFactory = channelFactory; 
            Initialize();
        }

        #endregion Contructor

        #region Entities

        #region Products

        public IEntitySet<Product> Products
        {
            get
            {
                if (productEntitySet == null)
                {
                    productEntitySet = CreateEntitySet<Product>(_products, AttachWithRelations, GetProducts);
                }
                return productEntitySet;
            }
        }
        private IEntitySet<Product> productEntitySet;

        public void Add(Product entity)
        {
            Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Products.Delete(entity);
        }

        public void Attach(Product entity)
        {
            Products.Attach(entity);
        }

        public void AttachAsModified(Product entity, Product original)
        {
            Products.AttachAsModified(entity, original);
        }

        public void Detach(Product entity)
        {
            Products.Detach(entity);
        }

        private QueryResult<Product> GetProducts(ClientInfo clientInfo, Query query)
        {
            var service = ChannelFactory.CreateChannel();
            try
            {
                var result = service.GetProducts(clientInfo, query);
                return result;
            }
            finally
            {
                // http://omaralzabir.com/do-not-use-using-in-wcf-client/
                var client = service as ICommunicationObject;
                if (client != null)
                {
                    if (client.State == CommunicationState.Faulted)
                    {
                        client.Abort();
                    }
                    else
                    {
                        client.Close();
                    }
                }
            }
        }

        private Product AttachWithRelations(Product entity, InsertMode insertMode = InsertMode.Attach, MergeOption mergeOption = MergeOption.AppendOnly, List<object> referenceTrackingList = null)
        {
            #region iteration tracking

            if (referenceTrackingList == null)
            {
                referenceTrackingList = new List<object>();
            }

            if (referenceTrackingList.Contains(entity))
            {
                return _products.GetExisting(entity);
            }
            else
            {
                referenceTrackingList.Add(entity);
            }

            #endregion

            #region add/attach entity

            Product existingEntity = null;

            switch (insertMode)
            {
                case InsertMode.Add:
                    existingEntity = _products.Add(entity);
                    break;
                case InsertMode.Attach:
                    existingEntity = _products.Attach(entity);
                    break;
                default:
                    throw new Exception(string.Format("Implementation Exception: missing action for {0}", insertMode));
            }
            
            if (((object)existingEntity) != null && object.ReferenceEquals(existingEntity, entity))
            {
                return existingEntity;
            }

            #endregion

            #region attach relations recursively

            // register entity's property changed event if entity is new to context
            if (existingEntity == null)
            {
                entity.PropertyChanged += (s, e) =>
                {
                    if (entity.IsChangeTrackingPrevented) return;

                    if (e.PropertyName == "ProductCategory")
                    {
                        var relation = entity[e.PropertyName] as ProductCategory;
                        if (relation != null)
                        {
                            Attach(relation);
                        }
                    }
                };
            }

            // attach related entity to context
            if (entity.ProductCategory != null)
            {
                var existingRelatedEntity = AttachWithRelations(entity.ProductCategory, insertMode, mergeOption, referenceTrackingList);
            }

            #endregion

            #region refresh existing entity based on merge options

            if (existingEntity != null && !object.ReferenceEquals(existingEntity, entity))
            {
                if (Products.MergeOption == MergeOption.OverwriteChanges)
                {
                    Invoke(delegate
                    {
                        existingEntity.Refresh(entity, trackChanges: false);
                        existingEntity.AcceptChanges();
                    });
                }
                else if (Products.MergeOption == MergeOption.PreserveChanges)
                {
                    Invoke(delegate
                    {
                        existingEntity.Refresh(entity, trackChanges: false, preserveExistingChanges: true);
                    });
                }
            }

            #endregion

            return existingEntity;
        }

        #endregion Products

        #region ProductCategories

        public IEntitySet<ProductCategory> ProductCategories
        {
            get
            {
                if (productCategoryEntitySet == null)
                {
                    productCategoryEntitySet = CreateEntitySet<ProductCategory>(_productCategories, AttachWithRelations, GetProductCategories);
                }
                return productCategoryEntitySet;
            }
        }
        private IEntitySet<ProductCategory> productCategoryEntitySet;

        public void Add(ProductCategory entity)
        {
            ProductCategories.Add(entity);
        }

        public void Delete(ProductCategory entity)
        {
            ProductCategories.Delete(entity);
        }

        public void Attach(ProductCategory entity)
        {
            ProductCategories.Attach(entity);
        }

        public void AttachAsModified(ProductCategory entity, ProductCategory original)
        {
            ProductCategories.AttachAsModified(entity, original);
        }

        public void Detach(ProductCategory entity)
        {
            ProductCategories.Detach(entity);
        }

        private QueryResult<ProductCategory> GetProductCategories(ClientInfo clientInfo, Query query)
        {
            var service = ChannelFactory.CreateChannel();
            try
            {
                var result = service.GetProductCategories(clientInfo, query);
                return result;
            }
            finally
            {
                // http://omaralzabir.com/do-not-use-using-in-wcf-client/
                var client = service as ICommunicationObject;
                if (client != null)
                {
                    if (client.State == CommunicationState.Faulted)
                    {
                        client.Abort();
                    }
                    else
                    {
                        client.Close();
                    }
                }
            }
        }

        private ProductCategory AttachWithRelations(ProductCategory entity, InsertMode insertMode = InsertMode.Attach, MergeOption mergeOption = MergeOption.AppendOnly, List<object> referenceTrackingList = null)
        {
            #region iteration tracking

            if (referenceTrackingList == null)
            {
                referenceTrackingList = new List<object>();
            }

            if (referenceTrackingList.Contains(entity))
            {
                return _productCategories.GetExisting(entity);
            }
            else
            {
                referenceTrackingList.Add(entity);
            }

            #endregion

            #region add/attach entity

            ProductCategory existingEntity = null;

            switch (insertMode)
            {
                case InsertMode.Add:
                    existingEntity = _productCategories.Add(entity);
                    break;
                case InsertMode.Attach:
                    existingEntity = _productCategories.Attach(entity);
                    break;
                default:
                    throw new Exception(string.Format("Implementation Exception: missing action for {0}", insertMode));
            }
            
            if (((object)existingEntity) != null && object.ReferenceEquals(existingEntity, entity))
            {
                return existingEntity;
            }

            #endregion

            #region attach relations recursively

            // register relation's collection changed event if entity is new to context
            if (existingEntity == null)
            {
                entity.ChildCategories.CollectionChanged += (s, e) =>
                {
                    if (entity.IsChangeTrackingPrevented) return;

                    if (e.NewItems != null)
                    {
                        foreach (ProductCategory item in e.NewItems)
                        {
                            Attach(item);
                        }
                    }
                    //if (e.OldItems != null)
                    //{
                    //    foreach (ProductCategory item in e.OldItems)
                    //    {
                    //        if (item.ChangeTracker.State == ObjectState.Unchanged)
                    //        {
                    //            item.MarkAsModified();
                    //        }
                    //    }
                    //}
                };
            }

            // attach related entities to context
            if (entity.ChildCategories.Count > 0)
            {
                foreach (var item in entity.ChildCategories.ToArray())
                {
                    var existingRelatedEntity = AttachWithRelations(item, insertMode, mergeOption, referenceTrackingList);
                    // update relation if entity is new to context or relation is new to entity
                    if (existingEntity == null || !existingEntity.ChildCategories.Contains(item))
                    {
                        if (existingRelatedEntity != null && !object.ReferenceEquals(existingRelatedEntity, item))
                        {
                            // check merge options
                            if (!(mergeOption == MergeOption.PreserveChanges && existingRelatedEntity.ChangeTracker.OriginalValues.ContainsKey("ParentCategory")))
                            {
                                using (entity.ChangeTrackingPrevention())
                                {
                                    entity.ChildCategories.Replace(item, existingRelatedEntity);
                                }
                                using (existingRelatedEntity.ChangeTrackingPrevention())
                                {
                                    existingRelatedEntity.ParentCategory = entity;
                                }
                            }
                        }
                    }
                }
            }

            // register entity's property changed event if entity is new to context
            if (existingEntity == null)
            {
                entity.PropertyChanged += (s, e) =>
                {
                    if (entity.IsChangeTrackingPrevented) return;

                    if (e.PropertyName == "ParentCategory")
                    {
                        var relation = entity[e.PropertyName] as ProductCategory;
                        if (relation != null)
                        {
                            Attach(relation);
                        }
                    }
                };
            }

            // attach related entity to context
            if (entity.ParentCategory != null)
            {
                var existingRelatedEntity = AttachWithRelations(entity.ParentCategory, insertMode, mergeOption, referenceTrackingList);
                // update relation if entity is new to context or relation is new to entity
                if (existingEntity == null || !entity.ParentCategory.Equals(existingEntity.ParentCategory))
                {
                    if (existingRelatedEntity != null && !object.ReferenceEquals(existingRelatedEntity, entity.ParentCategory))
                    {
                        // check merge options
                        if (!(mergeOption == MergeOption.PreserveChanges && existingRelatedEntity.ChangeTracker.OriginalValues.ContainsKey("ChildCategories")))
                        {
                            using (entity.ChangeTrackingPrevention())
                            {
                                entity.ParentCategory = existingRelatedEntity;
                            }

                            using (existingRelatedEntity.ChangeTrackingPrevention())
                            {
                                var entityToReplace = existingRelatedEntity.ChildCategories.FirstOrDefault(e => e.Equals(entity));
                                if (entityToReplace != null)
                                {
                                    using (entityToReplace.ChangeTrackingPrevention())
                                    {
                                        existingRelatedEntity.ChildCategories.Remove(entityToReplace);
                                    }
                                }
                                existingRelatedEntity.ChildCategories.Add(entity);
                            }
                        }
                    }
                }
            }

            #endregion

            #region refresh existing entity based on merge options

            if (existingEntity != null && !object.ReferenceEquals(existingEntity, entity))
            {
                if (ProductCategories.MergeOption == MergeOption.OverwriteChanges)
                {
                    Invoke(delegate
                    {
                        existingEntity.Refresh(entity, trackChanges: false);
                        existingEntity.AcceptChanges();
                    });
                }
                else if (ProductCategories.MergeOption == MergeOption.PreserveChanges)
                {
                    Invoke(delegate
                    {
                        existingEntity.Refresh(entity, trackChanges: false, preserveExistingChanges: true);
                    });
                }
            }

            #endregion

            return existingEntity;
        }

        #endregion ProductCategories

        #endregion Entities

        #region Submit Changes

        protected override ProductManagerResultSet SubmitChanges(ClientInfo clientInfo)
        {
            // get reduced change set
            var changeSet = GetChangeSet();

            if (!changeSet.IsEmpty)
            {
                var service = ChannelFactory.CreateChannel();
                try
                {
                    // submit data
                    var resultSet = service.SubmitChanges(clientInfo, changeSet);
                    return resultSet;
                }
                finally
                {
                    // http://omaralzabir.com/do-not-use-using-in-wcf-client/
                    var client = service as ICommunicationObject;
                    if (client != null)
                    {
                        if (client.State == CommunicationState.Faulted)
                        {
                            client.Abort();
                        }
                        else
                        {
                            client.Close();
                        }
                    }
                }
            }
            else
            {
                // return empty result set
                return new ProductManagerResultSet(changeSet);
            }
        }
        
        private ProductManagerChangeSet GetChangeSet()
        {
            IEnumerable<Product> products;
            lock (_products.SyncRoot)
            {
                products = _products.GetAllEntities();
            }
            IEnumerable<ProductCategory> productCategories;
            lock (_productCategories.SyncRoot)
            {
                productCategories = _productCategories.GetAllEntities();
            }
            // get reduced change set
            var changeSet = new ProductManagerChangeSet(
                products, 
                productCategories);

            return changeSet;
        }

        protected override void Refresh(ProductManagerResultSet resultSet)
        {
            lock (_products.SyncRoot)
            {
                Refresh(_products, resultSet.Products == null ? null : resultSet.Products.Where(e => !resultSet.IsConcurrencyConflict(e)));
            }
            lock (_productCategories.SyncRoot)
            {
                Refresh(_productCategories, resultSet.ProductCategories == null ? null : resultSet.ProductCategories.Where(e => !resultSet.IsConcurrencyConflict(e)));
            }
        }

        protected override void HandleConcurrencyConflicts(ProductManagerResultSet resultSet)
        {
            var entities = new List<StateEntry>();

            lock (_products.SyncRoot)
            {
                if (resultSet.ProductConcurrencyConflicts != null)
                {
                    entities.AddRange(
                        resultSet.ProductConcurrencyConflicts
                            .Select(store => new StateEntry(_products.FirstOrDefault(local => local.Equals(store)), store)));
                }
            }
            lock (_productCategories.SyncRoot)
            {
                if (resultSet.ProductCategoryConcurrencyConflicts != null)
                {
                    entities.AddRange(
                        resultSet.ProductCategoryConcurrencyConflicts
                            .Select(store => new StateEntry(_productCategories.FirstOrDefault(local => local.Equals(store)), store)));
                }
            }

            throw new OptimisticConcurrencyException(entities);
        }

        #endregion Submit Changes
    }
}
