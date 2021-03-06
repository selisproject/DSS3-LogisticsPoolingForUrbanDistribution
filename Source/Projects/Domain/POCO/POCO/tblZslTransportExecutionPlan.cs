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
    /// The tblZslTransportExecutionPlan class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblZslTransportExecutionPlan : IDomainModelClass
    {
        #region tblZslTransportExecutionPlan's Fields

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
        [DataMember(Name="ExecutionPlanID")]
        protected long? executionPlanID = 0L;
        [DataMember(Name="Notes")]
        protected string notes;
        [DataMember(Name="ETA")]
        protected DateTime? eTA;
        [DataMember(Name="ActualArrivalTime")]
        protected DateTime? actualArrivalTime;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblZslTransportExecutionPlan's Properties
/// <summary>
/// The ExecutionPlanID property
///
/// </summary>
///
        [Key]
        public virtual long? ExecutionPlanID
        {
            get
            {
                return executionPlanID;
            }
            set
            {
                executionPlanID = value;
            }
        }
/// <summary>
/// The Notes property
///
/// </summary>
///
        public virtual string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
/// <summary>
/// The ETA property
///
/// </summary>
///
        public virtual DateTime? ETA
        {
            get
            {
                return eTA;
            }
            set
            {
                eTA = value;
            }
        }
/// <summary>
/// The ActualArrivalTime property
///
/// </summary>
///
        public virtual DateTime? ActualArrivalTime
        {
            get
            {
                return actualArrivalTime;
            }
            set
            {
                actualArrivalTime = value;
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
        #region tblZslTransportExecutionPlan's Participant Properties
        [DataMember(Name="tblZslCarrier")]
        protected tblZslCarrier _tblZslCarrier;
        public virtual tblZslCarrier tblZslCarrier
        {
            get
            {
                return _tblZslCarrier;
            }
            set
            {
                if(Equals(_tblZslCarrier, value)) return;
                var __oldValue = _tblZslCarrier;
                if (value != null)
                {
                    _tblZslCarrier = value;
                }
                else
                {
                    if (_tblZslCarrier != null)
                    {
                        _tblZslCarrier = null;
                    }
                }
            }
        }
        [DataMember(Name="tblZslPlatformBookingOrder")]
        protected tblZslPlatformBookingOrder _tblZslPlatformBookingOrder;
        public virtual tblZslPlatformBookingOrder tblZslPlatformBookingOrder
        {
            get
            {
                return _tblZslPlatformBookingOrder;
            }
            set
            {
                if(Equals(_tblZslPlatformBookingOrder, value)) return;
                var __oldValue = _tblZslPlatformBookingOrder;
                if (value != null)
                {
                    _tblZslPlatformBookingOrder = value;
                }
                else
                {
                    if (_tblZslPlatformBookingOrder != null)
                    {
                        _tblZslPlatformBookingOrder = null;
                    }
                }
            }
        }
        [DataMember(Name="tblZslDeliveryStatus")]
        protected tblZslDeliveryStatus _tblZslDeliveryStatus;
        public virtual tblZslDeliveryStatus tblZslDeliveryStatus
        {
            get
            {
                return _tblZslDeliveryStatus;
            }
            set
            {
                if(Equals(_tblZslDeliveryStatus, value)) return;
                var __oldValue = _tblZslDeliveryStatus;
                if (value != null)
                {
                    _tblZslDeliveryStatus = value;
                }
                else
                {
                    if (_tblZslDeliveryStatus != null)
                    {
                        _tblZslDeliveryStatus = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblZslTransportExecutionPlan class
/// </summary>
/// <returns>New tblZslTransportExecutionPlan object</returns>
/// <remarks></remarks>
        public tblZslTransportExecutionPlan() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (ExecutionPlanID == null)
            {
                __errors.Add("Property 'ExecutionPlanID' is required.");
            }
            if (Notes != null && Notes.Length > 100)
            {
                __errors.Add("Length of property 'Notes' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblZslTransportExecutionPlan' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (ExecutionPlanID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Notes?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ETA?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ActualArrivalTime?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblZslTransportExecutionPlan] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblZslTransportExecutionPlan Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblZslTransportExecutionPlan copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblZslTransportExecutionPlan)copiedObjects[this];
            copy = copy ?? new tblZslTransportExecutionPlan();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.ExecutionPlanID = this.ExecutionPlanID;
            }
            copy.Notes = this.Notes;
            copy.ETA = this.ETA;
            copy.ActualArrivalTime = this.ActualArrivalTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._tblZslCarrier != null)
            {
                if (!copiedObjects.Contains(this._tblZslCarrier))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslCarrier = this.tblZslCarrier;
                    else if (asNew)
                        copy.tblZslCarrier = this.tblZslCarrier.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslCarrier = this._tblZslCarrier.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslCarrier = (tblZslCarrier)copiedObjects[this.tblZslCarrier];
                    else
                        copy._tblZslCarrier = (tblZslCarrier)copiedObjects[this.tblZslCarrier];
                }
            }
            if(deep && this._tblZslPlatformBookingOrder != null)
            {
                if (!copiedObjects.Contains(this._tblZslPlatformBookingOrder))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslPlatformBookingOrder = this.tblZslPlatformBookingOrder;
                    else if (asNew)
                        copy.tblZslPlatformBookingOrder = this.tblZslPlatformBookingOrder.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslPlatformBookingOrder = this._tblZslPlatformBookingOrder.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslPlatformBookingOrder = (tblZslPlatformBookingOrder)copiedObjects[this.tblZslPlatformBookingOrder];
                    else
                        copy._tblZslPlatformBookingOrder = (tblZslPlatformBookingOrder)copiedObjects[this.tblZslPlatformBookingOrder];
                }
            }
            if(deep && this._tblZslDeliveryStatus != null)
            {
                if (!copiedObjects.Contains(this._tblZslDeliveryStatus))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblZslDeliveryStatus = this.tblZslDeliveryStatus;
                    else if (asNew)
                        copy.tblZslDeliveryStatus = this.tblZslDeliveryStatus.Copy(deep, copiedObjects, true);
                    else
                        copy._tblZslDeliveryStatus = this._tblZslDeliveryStatus.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblZslDeliveryStatus = (tblZslDeliveryStatus)copiedObjects[this.tblZslDeliveryStatus];
                    else
                        copy._tblZslDeliveryStatus = (tblZslDeliveryStatus)copiedObjects[this.tblZslDeliveryStatus];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblZslTransportExecutionPlan;
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
        public static bool operator ==(tblZslTransportExecutionPlan x, tblZslTransportExecutionPlan y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblZslTransportExecutionPlan x, tblZslTransportExecutionPlan y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("ExecutionPlanID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.ExecutionPlanID.GetHashCode();
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
            return this.ExecutionPlanID == default(long) || this.ExecutionPlanID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblZslTransportExecutionPlan compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.ExecutionPlanID.Equals(compareTo.ExecutionPlanID);
        }

        #endregion


    }
}
