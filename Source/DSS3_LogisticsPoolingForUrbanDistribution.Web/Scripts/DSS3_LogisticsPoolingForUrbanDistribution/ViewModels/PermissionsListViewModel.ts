// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.PermissionsList {
export class PermissionsListViewModel extends DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {

            }
        } else {

        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: PermissionsListViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): PermissionsListViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        PermissionsListViewModel = new PermissionsListViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydratePermissionsListViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydratePermissionsListViewModel(original: PermissionsListViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        this.ListSelectedItemKeys = original.ListSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = PermissionsListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            PermissionsListViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): PermissionsListViewModel {
        var reduced = PermissionsListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        PermissionsListViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: PermissionsListViewModel) {
        if (reduced == null) return;


        DSS3_LogisticsPoolingForUrbanDistribution.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public ListSelectedItemKeys:
    any[];
}

}
