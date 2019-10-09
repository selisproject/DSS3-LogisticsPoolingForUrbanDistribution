var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = function (e) {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg; // Gecko, Trident, Chrome 34+
        return msg;
    }
};
var DSS3_LogisticsPoolingForUrbanDistribution;
(function (DSS3_LogisticsPoolingForUrbanDistribution) {
    var Controllers;
    (function (Controllers) {
        var UsersListConditionalFormattings = [];
        var UsersListDataValidations = [];
        var UsersListCalculatedExpressions = [];
        // Datasets Column Info
        var List_ColumnInfo = [
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "UserName",
                caption: window._resourcesManager.getDataListColumnCaption("List", "UserName", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 256,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Email",
                caption: window._resourcesManager.getDataListColumnCaption("List", "Email", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 255,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "string",
                dataTypeIsEnum: false,
                name: "Name",
                caption: window._resourcesManager.getDataListColumnCaption("List", "Name", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
                importable: false,
                supportsAggregators: true,
                length: 256,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            }),
            new Joove.Widgets.DataListColumnInfo({
                dataType: "bool",
                dataTypeIsEnum: false,
                name: "LockoutEnabled",
                caption: window._resourcesManager.getDataListColumnCaption("List", "LockoutEnabled", false),
                groupable: true,
                searchable: true,
                visible: true,
                orderable: true,
                editable: false,
                style: "",
                classes: "",
                itemType: Joove.Widgets.DataListColumnItemType.CHECKBOX,
                importable: false,
                supportsAggregators: true,
                length: null,
                formatting: null,
                width: null,
                css: "",
                isEncrypted: false,
                showFullImage: false
            })
        ];
        window["List_ColumnInfo"] = List_ColumnInfo;
        // Datasets Projection Shemas
        window["List_ProjectionScema"] = {};
        var UsersListController = (function () {
            function UsersListController($scope, $timeout) {
                this.$scope = $scope;
                this.controllerActionFinished = function (resetDirty) {
                    //window.scope_UsersList.model = window.scope_UsersList.dehydrate();
                    //window.scope_MasterPage.model = window.scope_UsersList.model;
                    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.UsersList.UsersListViewModel._lightCast(window.scope_UsersList.model);
                    // Joove.Common.applyScope(window.scope_UsersList);
                    if (resetDirty) {
                        window._context.isDirty = false;
                    }
                    window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
                };
                window.scope_UsersList = $scope;
                $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
                    Joove.Core.onChange(event.target, newValue, dontMakeDirty);
                };
                $scope.dehydrate = function (context) {
                    if (context === void 0) { context = null; }
                    return DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.UsersList.UsersListViewModel._initializeFrom($scope.model, context);
                };
                $scope._validationsMaster = window.scope_MasterPage._validations;
                $scope._validations = { summary: []
                };
                this.init($scope, $timeout);
                $timeout(function () {
                    window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, function () {
                        $("body").fadeIn(200);
                    });
                });
            }
            UsersListController.prototype.init = function ($scope, $timeout) {
                var _this = this;
                $scope.model = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.UsersList.UsersListViewModel._initializeFrom(window.viewDTO.Model);
                window.scope_MasterPage.model = $scope.model;
                new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
                $scope.trackObject = function (obj) { return Joove.Common.trackObject(obj); };
                //}
                $.connection['eventsHub'].on('__connectedEvent');
                $.connection['eventsHub'].on('forcePageReload', function () {
                    window.onbeforeunload = null;
                    setTimeout(function () {
                        window.location.reload();
                    }, 3000);
                });
                $.connection.hub.start(function () {
                    Joove.Common.getScope().connectedToSignals();
                    Joove.Common.getMasterScope().connectedToSignals();
                });
                $scope.connectedToSignals = function () {
                };
                // Event Listeners
                $scope.events = {};
                $scope.expressions = {};
                // Dataset Handler
                $scope.datasets = {};
                // Controller actions
                $scope.actions = {
                    Retrieve: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("UsersList", "Retrieve", "GET", [], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    Refresh: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        var _this = this;
                        var implementation, spamHelper;
                        return __generator(this, function (_a) {
                            switch (_a.label) {
                                case 0:
                                    Joove.Common.autocompleteFix();
                                    implementation = function () { return __awaiter(_this, void 0, void 0, function () {
                                        return __generator(this, function (_a) {
                                            Joove.Common.nullSafe(function () { return window._commander.dataListRefresh(['List']); }, null);
                                            return [2 /*return*/];
                                        });
                                    }); };
                                    return [4 /*yield*/, window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit)];
                                case 1:
                                    _a.sent();
                                    spamHelper = new Joove.SpamControlHelper(_e);
                                    spamHelper.Disable();
                                    return [4 /*yield*/, implementation()];
                                case 2:
                                    _a.sent();
                                    spamHelper.Enable();
                                    this.controllerActionFinished(true);
                                    return [2 /*return*/];
                            }
                        });
                    }); }
                };
                // Events
                $scope.eventCallbacks = {
                    CreateClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockCreateClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockCreateClicked);
                        }
                        _this.timeoutDelayLockCreateClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("ManageUser", "NewUser", "GET", [], {}, { mode: 'Slide', width: '50%', height: '50%', onClose: function () { $scope.actions.Refresh(); } });
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    EditClicked: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockEditClicked != null) {
                            $timeout.cancel(_this.timeoutDelayLockEditClicked);
                        }
                        _this.timeoutDelayLockEditClicked = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("ManageUser", "EditUser", "GET", [Joove.Common.nullSafe(function () { return Joove.DatasourceManager.getSelectedItem($("[jb-id='List']"), e).UserName; }, "")], {}, { mode: 'Slide', width: '50%', height: '50%', onClose: function () { $scope.actions.Refresh(); } });
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    }
                };
                // Rules
                window._ruleEngine.addDataValidations(UsersListDataValidations);
                window._ruleEngine.addConditionalFormattings(UsersListConditionalFormattings);
                window._ruleEngine.addCalculatedExpressions(UsersListCalculatedExpressions);
                window._commander.executeCommands(window.viewDTO.ClientCommands);
                window.viewDTO.ClientCommands = [];
                Joove.Common.setNumberLocalizationSettings();
                Joove.DeveloperApi.init($scope, window.scope_MasterPage);
                window.$formExtend && window.$formExtend();
                window.$onFormLoaded && window.$onFormLoaded();
            };
            return UsersListController;
        }());
        angular.module("Application").controller("UsersListController", ["$scope", "$timeout", UsersListController]);
    })(Controllers = DSS3_LogisticsPoolingForUrbanDistribution.Controllers || (DSS3_LogisticsPoolingForUrbanDistribution.Controllers = {}));
})(DSS3_LogisticsPoolingForUrbanDistribution || (DSS3_LogisticsPoolingForUrbanDistribution = {}));
