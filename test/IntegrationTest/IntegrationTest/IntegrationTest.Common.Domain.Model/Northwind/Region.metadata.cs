﻿//------------------------------------------------------------------------------
// <initially_autogenerated>
//   This file was originally generated by T4 code generator Northwind.tt.
//   This file is meant to be edited manually and modifications do not get lost on regeneration.
//   In case you want this file to be deleted or regenerated you have to remove (e.g. delete or rename) the existing version manually.
// </initially_autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using NTier.Common.Domain.Model;

namespace IntegrationTest.Common.Domain.Model.Northwind
{
    [MetadataType(typeof(RegionMetadata))]
    partial class Region
    {
    }

    // This class allows you to attach custom attributes to properties of the Region class.
    //
    // For example, the following marks the Xyz property as a
    // required property and specifies the format for valid values:
    //    [Required]
    //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
    //    [StringLength(32)]
    //    string Xyz;
    public sealed class RegionMetadata
    {
        // this class is not meant to be instantiated by client code
        private RegionMetadata() { }

#pragma warning disable 0169

        #region Simple Properties

        public global::System.Int32 RegionID;

        public global::System.String RegionDescription;

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        public TrackableCollection<Territory> Territories;

        #endregion Navigation Properties

#pragma warning restore 0169
    }
}
