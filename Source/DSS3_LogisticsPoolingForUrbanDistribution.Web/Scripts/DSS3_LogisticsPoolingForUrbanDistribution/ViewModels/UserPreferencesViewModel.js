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
        var UserPreferences;
        (function (UserPreferences) {
            var UserPreferencesViewModel = (function (_super) {
                __extends(UserPreferencesViewModel, _super);
                function UserPreferencesViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            ApplicationUser: true
                        };
                    }
                    else {
                        _this._members["ApplicationUser"] = true;
                    }
                    return _this;
                }
                UserPreferencesViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.ApplicationUser != null)
                        instance.ApplicationUser = ApplicationUser_ApplicationUserViewModel._lightCast(instance.ApplicationUser);
                    return instance;
                };
                UserPreferencesViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new UserPreferencesViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateUserPreferencesViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                UserPreferencesViewModel.prototype._hydrateUserPreferencesViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.ApplicationUser !== undefined)
                        this.ApplicationUser = ApplicationUser_ApplicationUserViewModel._initializeFrom(original.ApplicationUser, ignoreReadOnlyProperties, context);
                    if (original.LanguageBox__InitialSelection !== undefined)
                        this.LanguageBox__InitialSelection = original.LanguageBox__InitialSelection;
                    if (original.LocaleBox__InitialSelection !== undefined)
                        this.LocaleBox__InitialSelection = original.LocaleBox__InitialSelection;
                    if (original.DropdownApplicationThemeDataSet__InitialSelection !== undefined)
                        this.DropdownApplicationThemeDataSet__InitialSelection = original.DropdownApplicationThemeDataSet__InitialSelection;
                    this.LanguageBoxSelectedItemKeys = original.LanguageBoxSelectedItemKeys;
                    this.LocaleBoxSelectedItemKeys = original.LocaleBoxSelectedItemKeys;
                    this.DropdownApplicationThemeDataSetSelectedItemKeys = original.DropdownApplicationThemeDataSetSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = UserPreferencesViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        UserPreferencesViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                UserPreferencesViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = UserPreferencesViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    UserPreferencesViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                UserPreferencesViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    delete reduced.LanguageBox__InitialSelection;
                    delete reduced.LocaleBox__InitialSelection;
                    delete reduced.DropdownApplicationThemeDataSet__InitialSelection;
                    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                UserPreferencesViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return UserPreferencesViewModel;
            }(DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPage.MasterPageViewModel));
            UserPreferences.UserPreferencesViewModel = UserPreferencesViewModel;
            var ApplicationUser_ApplicationUserViewModel = (function (_super) {
                __extends(ApplicationUser_ApplicationUserViewModel, _super);
                function ApplicationUser_ApplicationUserViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            UserName: true, Profile: true
                        };
                    }
                    else {
                        _this._members["UserName"] = true;
                        _this._members["Profile"] = true;
                    }
                    return _this;
                }
                ApplicationUser_ApplicationUserViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Profile != null)
                        instance.Profile = ApplicationUser_ApplicationUser_Profile_ProfileViewModel._lightCast(instance.Profile);
                    return instance;
                };
                ApplicationUser_ApplicationUserViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationUser_ApplicationUserViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationUser_ApplicationUserViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationUser_ApplicationUserViewModel.prototype._hydrateApplicationUser_ApplicationUserViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    if (original.Profile !== undefined)
                        this.Profile = ApplicationUser_ApplicationUser_Profile_ProfileViewModel._initializeFrom(original.Profile, ignoreReadOnlyProperties, context);
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationUser_ApplicationUserViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationUser_ApplicationUserViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationUser_ApplicationUserViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationUser_ApplicationUserViewModel;
            }(BaseClass.ViewModel));
            UserPreferences.ApplicationUser_ApplicationUserViewModel = ApplicationUser_ApplicationUserViewModel;
            var ApplicationUser_ApplicationUser_Profile_ProfileViewModel = (function (_super) {
                __extends(ApplicationUser_ApplicationUser_Profile_ProfileViewModel, _super);
                function ApplicationUser_ApplicationUser_Profile_ProfileViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Id: true, LanguageLCID: true, LocaleLCID: true, Theme: true
                        };
                    }
                    else {
                        _this._members["Id"] = true;
                        _this._members["LanguageLCID"] = true;
                        _this._members["LocaleLCID"] = true;
                        _this._members["Theme"] = true;
                    }
                    return _this;
                }
                ApplicationUser_ApplicationUser_Profile_ProfileViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ApplicationUser_ApplicationUser_Profile_ProfileViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ApplicationUser_ApplicationUser_Profile_ProfileViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateApplicationUser_ApplicationUser_Profile_ProfileViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ApplicationUser_ApplicationUser_Profile_ProfileViewModel.prototype._hydrateApplicationUser_ApplicationUser_Profile_ProfileViewModel = function (original, ignoreReadOnlyProperties, context) {
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
                    if (original.LanguageLCID !== undefined)
                        this.LanguageLCID = original.LanguageLCID;
                    if (original.LocaleLCID !== undefined)
                        this.LocaleLCID = original.LocaleLCID;
                    if (original.Theme !== undefined)
                        this.Theme = original.Theme;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ApplicationUser_ApplicationUser_Profile_ProfileViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ApplicationUser_ApplicationUser_Profile_ProfileViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ApplicationUser_ApplicationUser_Profile_ProfileViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                ApplicationUser_ApplicationUser_Profile_ProfileViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ApplicationUser_ApplicationUser_Profile_ProfileViewModel;
            }(BaseClass.ViewModel));
            UserPreferences.ApplicationUser_ApplicationUser_Profile_ProfileViewModel = ApplicationUser_ApplicationUser_Profile_ProfileViewModel;
        })(UserPreferences = ViewModels.UserPreferences || (ViewModels.UserPreferences = {}));
    })(ViewModels = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels || (DSS3_LogisticsPoolingForUrbanDistribution.ViewModels = {}));
})(DSS3_LogisticsPoolingForUrbanDistribution || (DSS3_LogisticsPoolingForUrbanDistribution = {}));
