// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup((e) => {
    if (e.which === 13 && Joove.Common.eventPreventsDefaultFormAction(e as JQueryEventObject) === false && !$(e.target).parent().hasClass("search-element")) {
        window._popUpManager.previouslyFocusedElement = document.activeElement;
        $(":focus").blur();
        Joove.Core.getScope().eventCallbacks.Button1Clicked(e);
    }
});
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_ManageOperation: DSS3_LogisticsPoolingForUrbanDistribution.Controllers.IManageOperationScope; }
namespace DSS3_LogisticsPoolingForUrbanDistribution.Controllers {
const ManageOperationConditionalFormattings = [
        ];
const ManageOperationDataValidations = [
                                       ];
const ManageOperationCalculatedExpressions = [
        ];

// Datasets Column Info
var Button2_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Id",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Id", true),
groupable: true,
searchable: true,
visible: false,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
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
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Name", true),
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
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("Button2", "Description", true),
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
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["Button2_ColumnInfo"] = Button2_ColumnInfo;

// Datasets Projection Shemas
window["Button2_ProjectionScema"] = {};


export interface IManageOperationScope extends Joove.IWebPageScope {
model:
    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.ManageOperation.ManageOperationViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class ManageOperationController {
private timeoutDelayLockButton1Clicked:
    any;
private timeoutDelayLockButton4Clicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_ManageOperation.model = window.scope_ManageOperation.dehydrate();
        //window.scope_MasterPageForSlide.model = window.scope_ManageOperation.model;
        DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.ManageOperation.ManageOperationViewModel._lightCast(window.scope_ManageOperation.model);
        // Joove.Common.applyScope(window.scope_ManageOperation);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IManageOperationScope, $timeout: ng.ITimeoutService) {
        window.scope_ManageOperation = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.ManageOperation.ManageOperationViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForSlide._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IManageOperationScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.ManageOperation.ManageOperationViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForSlide.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
EditOperation:
            async (Id, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("ManageOperation", "EditOperation", "GET", [Id], {}, _modalOptions);
            },
SaveOperation:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'ManageOperation', action: 'SaveOperation',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
Button1Clicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButton1Clicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButton1Clicked);
                }

                this.timeoutDelayLockButton1Clicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        $scope.actions.SaveOperation(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                }, 0);
            },

Button4Clicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                Joove.Common.setControlKeyPressed(e, 0);
                window._commander.closeForm();
            },

        };

// Rules
        window._ruleEngine.addDataValidations(ManageOperationDataValidations);
        window._ruleEngine.addConditionalFormattings(ManageOperationConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(ManageOperationCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForSlide as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("ManageOperationController", ["$scope", "$timeout", ManageOperationController] as Array<string>);
}
