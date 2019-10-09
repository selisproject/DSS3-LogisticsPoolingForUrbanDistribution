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
interface Window { scope_SignInPage: DSS3_LogisticsPoolingForUrbanDistribution.Controllers.ISignInPageScope; }
namespace DSS3_LogisticsPoolingForUrbanDistribution.Controllers {
const SignInPageConditionalFormattings = [
        ];
const SignInPageDataValidations = [
new Joove.JbRule({
name: "PasswordEmptyValidation",
type: Joove.RuleTypes.DataValidation,
evaluatedAtServer: false,
isDataSetRule: false,
group: "",



condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => CLMS.Framework.String.IsNullOrEmpty(Joove.Common.nullSafe(function () {
            return Joove.Common.nullSafe<any>(() => window["scope_SignInPage"].model.PasswordTextBox, "").trim();
        }, "")), false);


    },
expression: async function(_parents) {
        return Joove.Common.nullSafe<any>(() => window._resourcesManager.getLocalResource("RES_DATAVALIDATION_MESSAGE_PasswordEmpty", false), "");
    },
dataValidationMessageType:  Joove.DataValidationMessageType.ERROR,
evaluationTimes: [Joove.EvaluationTimes.OnSubmit],
originalName: 'PasswordEmpty',
fromMasterPage: false
}),
new Joove.JbRule({
name: "UsernameEmptyValidation",
type: Joove.RuleTypes.DataValidation,
evaluatedAtServer: false,
isDataSetRule: false,
group: "",



condition: async (_parents) => {
        return Joove.Common.nullSafe<any>(() => CLMS.Framework.String.IsNullOrEmpty(Joove.Common.nullSafe(function () {
            return Joove.Common.nullSafe<any>(() => window["scope_SignInPage"].model.UserNameTextBox, "").trim();
        }, "")), false);


    },
expression: async function(_parents) {
        return Joove.Common.nullSafe<any>(() => window._resourcesManager.getLocalResource("RES_DATAVALIDATION_MESSAGE_UsernameEmpty", false), "");
    },
dataValidationMessageType:  Joove.DataValidationMessageType.ERROR,
evaluationTimes: [Joove.EvaluationTimes.OnSubmit],
originalName: 'UsernameEmpty',
fromMasterPage: false
}),
                                  ];
const SignInPageCalculatedExpressions = [
                                        ];

// Datasets Column Info

// Datasets Projection Shemas


export interface ISignInPageScope extends Joove.IWebPageScope {
model:
    DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.SignInPage.SignInPageViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,
PasswordEmpty: Joove.Validation.BindingEntry,UsernameEmpty: Joove.Validation.BindingEntry,
    },
    _masterValidations?: any;
}

class SignInPageController {
private timeoutDelayLockButton1Clicked:
    any;
private timeoutDelayLockButton2Clicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_SignInPage.model = window.scope_SignInPage.dehydrate();
        //window.scope_MasterPageSignIn.model = window.scope_SignInPage.model;
        DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.SignInPage.SignInPageViewModel._lightCast(window.scope_SignInPage.model);
        // Joove.Common.applyScope(window.scope_SignInPage);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: ISignInPageScope, $timeout: ng.ITimeoutService) {
        window.scope_SignInPage = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.SignInPage.SignInPageViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageSignIn._validations;
        $scope._validations = { summary:
                                [],
                                PasswordEmpty:
                                { rule: SignInPageDataValidations[0], group: SignInPageDataValidations[0].group },
                                UsernameEmpty:
                                { rule: SignInPageDataValidations[1], group: SignInPageDataValidations[1].group },
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: ISignInPageScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.SignInPage.SignInPageViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageSignIn.model = $scope.model;

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
Load:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("SignInPage", "Load", "GET", [], {}, _modalOptions);
            },
SignIn:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'SignInPage', action: 'SignIn',
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
                        $scope.actions.SignIn(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

Button2Clicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButton2Clicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButton2Clicked);
                }

                this.timeoutDelayLockButton2Clicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("ForgotPassword", "Render", "GET", [], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(SignInPageDataValidations);
        window._ruleEngine.addConditionalFormattings(SignInPageConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(SignInPageCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageSignIn as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("SignInPageController", ["$scope", "$timeout", SignInPageController] as Array<string>);
}
