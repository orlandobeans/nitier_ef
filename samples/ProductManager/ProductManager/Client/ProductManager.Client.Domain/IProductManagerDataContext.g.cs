//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator ProductModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using NTier.Client.Domain;
using ProductManager.Common.Domain.Model.ProductManager;

namespace ProductManager.Client.Domain
{
    public partial interface IProductManagerDataContext : IDataContext
    {

        #region Products

        IEntitySet<Product> Products { get; }

        void Add(Product entity);
        void Delete(Product entity);
        void Attach(Product entity);
        void AttachAsModified(Product entity, Product original);
        void Detach(Product entity);

        #endregion Products

        #region ProductCategories

        IEntitySet<ProductCategory> ProductCategories { get; }

        void Add(ProductCategory entity);
        void Delete(ProductCategory entity);
        void Attach(ProductCategory entity);
        void AttachAsModified(ProductCategory entity, ProductCategory original);
        void Detach(ProductCategory entity);

        #endregion ProductCategories

    }
}
