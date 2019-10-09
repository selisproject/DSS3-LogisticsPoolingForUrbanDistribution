var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS3_LogisticsPoolingForUrbanDistribution;
(function (DSS3_LogisticsPoolingForUrbanDistribution) {
    var ViewModels;
    (function (ViewModels) {
        var ManageOperation;
        (function (ManageOperation) {
            var ManageOperationViewModel = (function (_super) {
                __extends(ManageOperationViewModel, _super);
                function ManageOperationViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            ApplicationOperation: true
                        };
                    }
                    else {
                        _this._members["ApplicationOperation"] = true;
                    }
                    return _this;
                }
                ManageOperationViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.ApplicationOperation != null)
                        instance.ApplicationOperation = ApplicationOperation_ApplicationOperationViewModel._lightCast(instance.ApplicationOperation);
                    return instance;
                };
                ManageOperationViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ManageOperationViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateManageOperationViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ManageOperationViewModel.prototype._hydrateManageOperationViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageForSlideViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.ApplicationOperation !== undefined)
                        this.ApplicationOperation = ApplicationOperation_ApplicationOperationViewModel._initializeFrom(original.ApplicationOperation, ignoreReadOnlyProperties, context);
                    this.Button2SelectedItemKeys = original.Button2SelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ManageOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        ManageOperationViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ManageOperationViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ManageOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    ManageOperationViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                ManageOperationViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._deleteDropDownInitialValues(reduced);
                };
                ManageOperationViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ManageOperationViewModel;
            }(DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel));
            ManageOperation.ManageOperationViewModel = ManageOperationViewModel;
            var ApplicationOperation_ApplicationOperationViewModel = (function (_super) {
                __extends(ApplicationOperation_ApplicationOperationViewModel, _super);
                function ApplicationOperation_ApplicationOperationViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, IsAvailableToAllAuthorizedUsers: true, IsAvailableToAnonymous: true, Name: true, ParentControllerName: true, Type: true, Permissions: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["IsAvailableToAllAuthorizedUsers"] = true;
                        _this._members["IsAvailableToAnonymous"] = true;
                        _this._members["Name"] = true;
                        _this._members["ParentControllerName"] = true;
                        _this._members["Type"] = true;
                        _this._members["Permissions"] = true;
                    }
                    _this.Permissions = new Array();
                    return _this;
                }
                ApplicationOperation_ApplicationOperationViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Permissions != null) {
                        for (var i = 0; i < instance.Permissions.length; i++) {
                            instance.Permissions[i] = ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._lightCast(instance.Permissions[i]);
                        }
                    }
                    return instance;
                };
                ApplicationOperation_ApplicationOperationViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationOperation_ApplicationOperationViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationOperation_ApplicationOperationViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationOperation_ApplicationOperationViewModel.prototype._hydrateApplicationOperation_ApplicationOperationViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.IsAvailableToAllAuthorizedUsers !== undefined)
                        this.IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
                    if (original.IsAvailableToAnonymous !== undefined)
                        this.IsAvailableToAnonymous = original.IsAvailableToAnonymous;
                    if (original.Name !== undefined)
                        this.Name = original.Name;
                    if (original.ParentControllerName !== undefined)
                        this.ParentControllerName = original.ParentControllerName;
                    if (original.Type !== undefined)
                        this.Type = original.Type;
                    if (original.Permissions != null) {
                        for (var i = 0; i < original.Permissions.length; i++) {
                            this.Permissions.push(ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._initializeFrom(original.Permissions[i], ignoreReadOnlyProperties, context));
                        }
                    }
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationOperation_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationOperation_ApplicationOperationViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationOperation_ApplicationOperationViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationOperation_ApplicationOperationViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationOperation_ApplicationOperationViewModel;
            }(BaseClass.ViewModel));
            ManageOperation.ApplicationOperation_ApplicationOperationViewModel = ApplicationOperation_ApplicationOperationViewModel;
            var ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel = (function (_super) {
                __extends(ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel, _super);
                function ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Description: true, Id: true, IsCustom: true, Name: true
                        };
                    }
                    else {
                        _this._members["Description"] = true;
                        _this._members["Id"] = true;
                        _this._members["IsCustom"] = true;
                        _this._members["Name"] = true;
                    }
                    return _this;
                }
                ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel.prototype._hydrateApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original._versionTimestamp !== undefined)
                        this._versionTimestamp = original._versionTimestamp;
                    if (original.Description !== undefined)
                        this.Description = original.Description;
                    if (original.Id !== undefined)
                        this.Id = original.Id;
                    if (original.IsCustom !== undefined)
                        this.IsCustom = original.IsCustom;
                    if (original.Name !== undefined)
                        this.Name = original.Name;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel;
            }(BaseClass.ViewModel));
            ManageOperation.ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel = ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionViewModel;
        })(ManageOperation = ViewModels.ManageOperation || (ViewModels.ManageOperation = {}));
    })(ViewModels = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels || (DSS3_LogisticsPoolingForUrbanDistribution.ViewModels = {}));
})(DSS3_LogisticsPoolingForUrbanDistribution || (DSS3_LogisticsPoolingForUrbanDistribution = {}));
