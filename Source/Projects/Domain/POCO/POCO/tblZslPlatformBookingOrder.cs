// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BO
{
    /// <summary>
    /// The tblZslPlatformBookingOrder class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblZslPlatformBookingOrder : IDomainModelClass
    {
        #region tblZslPlatformBookingOrder's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="BookingDate")]
        protected DateTime? bookingDate;
        [DataMember(Name="OrderNo")]
        protected string orderNo;
        [DataMember(Name="NoIdentity")]
        protected string noIdentity;
        [DataMember(Name="FromExtTime")]
        protected DateTime? fromExtTime;
        [DataMember(Name="ToExtTime")]
        protected DateTime? toExtTime;
        [DataMember(Name="BookStatus")]
        protected string bookStatus;
        [DataMember(Name="NoPlatform")]
        protected string noPlatform;
        [DataMember(Name="NoCourier")]
        protected string noCourier;
        [DataMember(Name="Warehouse")]
        protected string warehouse;
        [DataMember(Name="Driver")]
        protected string driver;
        [DataMember(Name="DriverTelephone")]
        protected string driverTelephone;
        [DataMember(Name="Plate")]
        protected string plate;
        [DataMember(Name="Trailerplate")]
        protected string trailerplate;
        [DataMember(Name="PalletIN")]
        protected int? palletIN;
        [DataMember(Name="TotalPallet")]
        protected int? totalPallet;
        [DataMember(Name="DateArrived")]
        protected DateTime? dateArrived;
        [DataMember(Name="TimeArrived")]
        protected DateTime? timeArrived;
        [DataMember(Name="DateExit")]
        protected DateTime? dateExit;
        [DataMember(Name="TImeExit")]
        protected DateTime? tImeExit;
        [DataMember(Name="RouteTracking_ID")]
        protected long? routeTracking_ID;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblZslPlatformBookingOrder's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The BookingDate property
///
/// </summary>
///
        public virtual DateTime? BookingDate
        {
            get
            {
                return bookingDate;
            }
            set
            {
                bookingDate = value;
            }
        }
/// <summary>
/// The OrderNo property
///
/// </summary>
///
        public virtual string OrderNo
        {
            get
            {
                return orderNo;
            }
            set
            {
                orderNo = value;
            }
        }
/// <summary>
/// The NoIdentity property
///
/// </summary>
///
        public virtual string NoIdentity
        {
            get
            {
                return noIdentity;
            }
            set
            {
                noIdentity = value;
            }
        }
/// <summary>
/// The FromExtTime property
///
/// </summary>
///
        public virtual DateTime? FromExtTime
        {
            get
            {
                return fromExtTime;
            }
            set
            {
                fromExtTime = value;
            }
        }
/// <summary>
/// The ToExtTime property
///
/// </summary>
///
        public virtual DateTime? ToExtTime
        {
            get
            {
                return toExtTime;
            }
            set
            {
                toExtTime = value;
            }
        }
/// <summary>
/// The BookStatus property
///
/// </summary>
///
        public virtual string BookStatus
        {
            get
            {
                return bookStatus;
            }
            set
            {
                bookStatus = value;
            }
        }
/// <summary>
/// The NoPlatform property
///
/// </summary>
///
        public virtual string NoPlatform
        {
            get
            {
                return noPlatform;
            }
            set
            {
                noPlatform = value;
            }
        }
/// <summary>
/// The NoCourier property
///
/// </summary>
///
        public virtual string NoCourier
        {
            get
            {
                return noCourier;
            }
            set
            {
                noCourier = value;
            }
        }
/// <summary>
/// The Warehouse property
///
/// </summary>
///
        public virtual string Warehouse
        {
            get
            {
                return warehouse;
            }
            set
            {
                warehouse = value;
            }
        }
/// <summary>
/// The Driver property
///
/// </summary>
///
        public virtual string Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
/// <summary>
/// The DriverTelephone property
///
/// </summary>
///
        public virtual string DriverTelephone
        {
            get
            {
                return driverTelephone;
            }
            set
            {
                driverTelephone = value;
            }
        }
/// <summary>
/// The Plate property
///
/// </summary>
///
        public virtual string Plate
        {
            get
            {
                return plate;
            }
            set
            {
                plate = value;
            }
        }
/// <summary>
/// The Trailerplate property
///
/// </summary>
///
        public virtual string Trailerplate
        {
            get
            {
                return trailerplate;
            }
            set
            {
                trailerplate = value;
            }
        }
/// <summary>
/// The PalletIN property
///
/// </summary>
///
        public virtual int? PalletIN
        {
            get
            {
                return palletIN;
            }
            set
            {
                palletIN = value;
            }
        }
/// <summary>
/// The TotalPallet property
///
/// </summary>
///
        public virtual int? TotalPallet
        {
            get
            {
                return totalPallet;
            }
            set
            {
                totalPallet = value;
            }
        }
/// <summary>
/// The DateArrived property
///
/// </summary>
///
        public virtual DateTime? DateArrived
        {
            get
            {
                return dateArrived;
            }
            set
            {
                dateArrived = value;
            }
        }
/// <summary>
/// The TimeArrived property
///
/// </summary>
///
        public virtual DateTime? TimeArrived
        {
            get
            {
                return timeArrived;
            }
            set
            {
                timeArrived = value;
            }
        }
/// <summary>
/// The DateExit property
///
/// </summary>
///
        public virtual DateTime? DateExit
        {
            get
            {
                return dateExit;
            }
            set
            {
                dateExit = value;
            }
        }
/// <summary>
/// The TImeExit property
///
/// </summary>
///
        public virtual DateTime? TImeExit
        {
            get
            {
                return tImeExit;
            }
            set
            {
                tImeExit = value;
            }
        }
/// <summary>
/// The RouteTracking_ID property
///
/// </summary>
///
        public virtual long? RouteTracking_ID
        {
            get
            {
                return routeTracking_ID;
            }
            set
            {
                routeTracking_ID = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region tblZslPlatformBookingOrder's Participant Properties
        [DataMember(Name="PlatformBookingOrder")]
        protected tblZslPlatformBookingOrder platformBookingOrder;
        public virtual tblZslPlatformBookingOrder PlatformBookingOrder
        {
            get
            {
                return platformBookingOrder;
            }
            set
            {
                if(Equals(platformBookingOrder, value)) return;
                var __oldValue = platformBookingOrder;
                if (value != null)
                {
                    platformBookingOrder = value;
                }
                else
                {
                    if (platformBookingOrder != null)
                    {
                        platformBookingOrder = null;
                    }
                }
            }
        }
        [DataMember(Name="tblZslCustomer")]
        protected tblZslCustomer _tblZslCustomer;
        public virtual tblZslCustomer tblZslCustomer
        {
            get
            {
                return _tblZslCustomer;
            }
            set
            {
                if(Equals(_tblZslCustomer, value)) return;
                var __oldValue = _tblZslCustomer;
                if (value != null)
                {
                    _tblZslCustomer = value;
                }
                else
                {
                    if (_tblZslCustomer != null)
                    {
                        _tblZslCustomer = null;
                    }
                }
            }
        }
        [DataMember(Name="tblZslBookingType")]
        protected tblZslBookingType _tblZslBookingType;
        public virtual tblZslBookingType tblZslBookingType
        {
            get
            {
                return _tblZslBookingType;
            }
            set
            {
                if(Equals(_tblZslBookingType, value)) return;
                var __oldValue = _tblZslBookingType;
                if (value != null)
                {
                    _tblZslBookingType = value;
                }
                else
                {
                    if (_tblZslBookingType != null)
                    {
                        _tblZslBookingType = null;
                    }
                }
            }
        }
        [DataMember(Name="tblZslTransportOrder")]
        protected tblZslTransportOrder _tblZslTransportOrder;
        public virtual tblZslTransportOrder tblZslTransportOrder
        {
            get
            {
                return _tblZslTransportOrder;
            }
            set
            {
                if(Equals(_tblZslTransportOrder, value)) return;
                var __oldValue = _tblZslTransportOrder;
                if (value != null)
                {
                    _tblZslTransportOrder = value;
                }
                else
                {
                    if (_tblZslTransportOrder != null)
                    {
                        _tblZslTransportOrder = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblZslPlatformBookingOrder class
/// </summary>
/// <returns>New tblZslPlatformBookingOrder object</returns>
/// <remarks></remarks>
        public tblZslPlatformBookingOrder() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (OrderNo != null && OrderNo.Length > 100)
            {
                __errors.Add("Length of property 'OrderNo' cannot be greater than 100.");
            }
            if (NoIdentity != null && NoIdentity.Length > 100)
            {
                __errors.Add("Length of property 'NoIdentity' cannot be greater than 100.");
            }
            if (BookStatus != null && BookStatus.Length > 100)
            {
                __errors.Add("Length of property 'BookStatus' cannot be greater than 100.");
            }
            if (NoPlatform != null && NoPlatform.Length > 100)
            {
                __errors.Add("Length of property 'NoPlatform' cannot be greater than 100.");
            }
            if (NoCourier != null && NoCourier.Length > 100)
            {
                __errors.Add("Length of property 'NoCourier' cannot be greater than 100.");
            }
            if (Warehouse != null && Warehouse.Length > 100)
            {
                __errors.Add("Length of property 'Warehouse' cannot be greater than 100.");
            }
            if (Driver != null && Driver.Length > 100)
            {
                __errors.Add("Length of property 'Driver' cannot be greater than 100.");
            }
            if (DriverTelephone != null && DriverTelephone.Length > 100)
            {
                __errors.Add("Length of property 'DriverTelephone' cannot be greater than 100.");
            }
            if (Plate != null && Plate.Length > 100)
            {
                __errors.Add("Length of property 'Plate' cannot be greater than 100.");
            }
            if (Trailerplate != null && Trailerplate.Length > 100)
            {
                __errors.Add("Length of property 'Trailerplate' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblZslPlatformBookingOrder' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (BookingDate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OrderNo?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (NoIdentity?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (FromExtTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ToExtTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (BookStatus?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (NoPlatform?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (NoCourier?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Warehouse?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Driver?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DriverTelephone?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Plate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Trailerplate?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PalletIN?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalPallet?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DateArrived?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TimeArrived?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DateExit?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TImeExit?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RouteTracking_ID?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblZslPlatformBookingOrder] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblZslPlatformBookingOrder Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblZslPlatformBookingOrder copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblZslPlatformBookingOrder)copiedObjects[this];
            copy = copy ?? new tblZslPlatformBookingOrder();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.BookingDate = this.BookingDate;
            copy.OrderNo = this.OrderNo;
            copy.NoIdentity = this.NoIdentity;
            copy.FromExtTime = this.FromExtTime;
            copy.ToExtTime = this.ToExtTime;
            copy.BookStatus = this.BookStatus;
            copy.NoPlatform = this.NoPlatform;
            copy.NoCourier = this.NoCourier;
            copy.Warehouse = this.Warehouse;
            copy.Driver = this.Driver;
            copy.DriverTelephone = this.DriverTelephone;
            copy.Plate = this.Plate;
            copy.Trailerplate = this.Trailerplate;
            copy.PalletIN = this.PalletIN;
            copy.TotalPallet = this.TotalPallet;
            copy.DateArrived = this.DateArrived;
            copy.TimeArrived = this.TimeArrived;
            copy.DateExit = this.DateExit;
            copy.TImeExit = this.TImeExit;
            copy.RouteTracking_ID = this.RouteTracking_ID;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.platformBookingOrder != null)
            {
                if (!copiedObjects.Contains(this.platformBookingOrder))
                {
                    if (asNew && reuseNestedObjects)
                        copy.PlatformBookingOrder = this.PlatformBookingOrder;
                    else if (asNew)
                        copy.PlatformBookingOrder = this.PlatformBookingOrder.Copy(deep, copiedObjects, true);
                    else
                        copy.platformBookingOrder = this.platformBookingOrder.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.PlatformBookingOrder = (tblZslPlatformBookingOrder)copiedObjects[this.PlatformBookingOrder];
                    else
                        copy.platformBookingOrder = (tblZslPlatformBookingOrder)copiedObjects[this.PlatformBookingOrder];
                }
            }
            if(deep && this._tblZslCustomer != null)
            {
                if (!copiedObjects.Contains(this._tblZslCustomer))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslCustomer = this.tblZslCustomer;
                    else if (asNew)
                        copy.tblZslCustomer = this.tblZslCustomer.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslCustomer = this._tblZslCustomer.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslCustomer = (tblZslCustomer)copiedObjects[this.tblZslCustomer];
                    else
                        copy._tblZslCustomer = (tblZslCustomer)copiedObjects[this.tblZslCustomer];
                }
            }
            if(deep && this._tblZslBookingType != null)
            {
                if (!copiedObjects.Contains(this._tblZslBookingType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslBookingType = this.tblZslBookingType;
                    else if (asNew)
                        copy.tblZslBookingType = this.tblZslBookingType.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslBookingType = this._tblZslBookingType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslBookingType = (tblZslBookingType)copiedObjects[this.tblZslBookingType];
                    else
                        copy._tblZslBookingType = (tblZslBookingType)copiedObjects[this.tblZslBookingType];
                }
            }
            if(deep && this._tblZslTransportOrder != null)
            {
                if (!copiedObjects.Contains(this._tblZslTransportOrder))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslTransportOrder = this.tblZslTransportOrder;
                    else if (asNew)
                        copy.tblZslTransportOrder = this.tblZslTransportOrder.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslTransportOrder = this._tblZslTransportOrder.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslTransportOrder = (tblZslTransportOrder)copiedObjects[this.tblZslTransportOrder];
                    else
                        copy._tblZslTransportOrder = (tblZslTransportOrder)copiedObjects[this.tblZslTransportOrder];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblZslPlatformBookingOrder;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(tblZslPlatformBookingOrder x, tblZslPlatformBookingOrder y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblZslPlatformBookingOrder x, tblZslPlatformBookingOrder y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(tblZslPlatformBookingOrder compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
