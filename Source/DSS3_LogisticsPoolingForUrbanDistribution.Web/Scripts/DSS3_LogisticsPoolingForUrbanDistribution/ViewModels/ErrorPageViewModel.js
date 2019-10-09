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
        var ErrorPage;
        (function (ErrorPage) {
            var ErrorPageViewModel = (function (_super) {
                __extends(ErrorPageViewModel, _super);
                function ErrorPageViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            ErrorMessage: true, StackTrace: true, FriendlyErrorMessage: true, AdditionalErrorInformation: true
                        };
                    }
                    else {
                        _this._members["ErrorMessage"] = true;
                        _this._members["StackTrace"] = true;
                        _this._members["FriendlyErrorMessage"] = true;
                        _this._members["AdditionalErrorInformation"] = true;
                    }
                    return _this;
                }
                ErrorPageViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ErrorPageViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ErrorPageViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateErrorPageViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ErrorPageViewModel.prototype._hydrateErrorPageViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageSignInViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.ErrorMessage !== undefined)
                        this.ErrorMessage = original.ErrorMessage;
                    if (original.StackTrace !== undefined)
                        this.StackTrace = original.StackTrace;
                    if (original.FriendlyErrorMessage !== undefined)
                        this.FriendlyErrorMessage = original.FriendlyErrorMessage;
                    if (original.AdditionalErrorInformation !== undefined)
                        this.AdditionalErrorInformation = original.AdditionalErrorInformation;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ErrorPageViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        ErrorPageViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ErrorPageViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ErrorPageViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    ErrorPageViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                ErrorPageViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPageSignIn.MasterPageSignInViewModel._deleteDropDownInitialValues(reduced);
                };
                ErrorPageViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ErrorPageViewModel;
            }(DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPageSignIn.MasterPageSignInViewModel));
            ErrorPage.ErrorPageViewModel = ErrorPageViewModel;
        })(ErrorPage = ViewModels.ErrorPage || (ViewModels.ErrorPage = {}));
    })(ViewModels = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels || (DSS3_LogisticsPoolingForUrbanDistribution.ViewModels = {}));
})(DSS3_LogisticsPoolingForUrbanDistribution || (DSS3_LogisticsPoolingForUrbanDistribution = {}));
