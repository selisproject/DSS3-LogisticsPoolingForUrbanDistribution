// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.ManageRole;
using Identity = zAppDev.DotNet.Framework.Identity;
using log4net;
using Newtonsoft.Json;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Utilities;

namespace DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.ManageRole
{

    [RoutePrefix("ManageRole")]
    public class ManageRoleController : ControllerBase<ManageRoleViewModel, ManageRoleViewModelDTO>
    {

        /*<Form:ManageRole:0/>*/
        public ManageRoleController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(ManageRoleController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel
            {
                Title = model.Title
            };
            _parentController = new MasterPageForSlide.MasterPageForSlideController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(ManageRoleViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
        }

        public override void CommitAllFilesLegacy()
        {
        }

        public override void ClearPendingFiles()
        {
        }






        [HttpGet]

        [Route("GetViewDTO")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ContentResult GetViewDTO(int hash)
        {
            return Content(GetViewFromViewDTOsDicSerialized(hash));
        }

        [HttpPost]

        [Route("UpdateInstance")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult UpdateInstance()
        {
            return PrepareUpdateInstanceResult(typeof(ManageRoleViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }


        [HttpGet]
        [Route("DownloadFileByPath")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFileByPath(string path, string defaultPath = null)
        {
            if (IdentityHelper.GetCurrentIdentityUser() == null) return null;
            if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(defaultPath))
            {
                throw new ApplicationException("Please provide a path.");
            }
            return FileHelper.PendingDownloadInstance.DownloadByPath(path, defaultPath);
        }


        [Route("SaveListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult SaveListView()
        {
            var postedData = _ParsePostedData();
            return SaveListView(postedData, "ManageRole");
        }


        [Route("DeleteListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult DeleteListView()
        {
            var postedData = _ParsePostedData();
            return DeleteListView(postedData, "ManageRole");
        }


        [Route("LoadListViews")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult LoadListViews()
        {
            var postedData = _ParsePostedData();
            return LoadListViews(postedData, "ManageRole");
        }



        #region Controller Actions
        [CustomControllerActionFilter(LogEnabled=true, HasDefaultResultView=true, ActionName="NewRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("NewRole")]
        public ActionResult NewRole()

        {
            @model = new ManageRoleViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ManageRole"] = "NewRole";
            return null;
        }

        [CustomControllerActionFilter(LogEnabled=true, FillDropDownInitialValues=true, ActionName="NewRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_NewRole")]
        public ActionResult _API_NewRole()

        {
            @model = new ManageRoleViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ManageRole"] = "NewRole";
            PushToHistory();
            var _masterController = new DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.MasterPageForSlide.MasterPageForSlideController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteNewRole();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, HasDefaultResultView=true, ActionName="EditRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("EditRole/{*Id:int?}")]
        public ActionResult EditRole(int? Id)

        {
            @model = new ManageRoleViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ManageRole"] = "EditRole";
            return null;
        }

        [CustomControllerActionFilter(LogEnabled=true, FillDropDownInitialValues=true, ActionName="EditRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_EditRole/{*Id:int?}")]
        public ActionResult _API_EditRole(int? Id)

        {
            @model = new ManageRoleViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ManageRole"] = "EditRole";
            PushToHistory();
            var _masterController = new DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.MasterPageForSlide.MasterPageForSlideController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteEditRole(Id);
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="SaveRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SaveRole")]
        public ActionResult SaveRole()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteSaveRole();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="DeleteRole", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeleteRole")]
        public ActionResult DeleteRole()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteDeleteRole();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:NewRole:1/>*/
        public ActionResult ExecuteNewRole()
        {
            if (_parentController == null) _parentController = new MasterPageForSlide.MasterPageForSlideController(new  DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel());
            ((MasterPageForSlide.MasterPageForSlideController) _parentController).ExecuteRender();
            ActionResult _result = null;
            zAppDev.DotNet.Framework.Identity.Model.ApplicationRole role = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole();
            role.IsCustom = true;
            @model.ApplicationRole = role;
            @model.Title = BaseViewPage<string>.GetResourceValue("ManageRole", "RES_PAGETITLE_NewRole").ToString();
            return _result;
        }
        /*<ControllerActionImplementation:EditRole:1/>*/
        public ActionResult ExecuteEditRole(int? Id)
        {
            if (_parentController == null) _parentController = new MasterPageForSlide.MasterPageForSlideController(new  DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel());
            ((MasterPageForSlide.MasterPageForSlideController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.ApplicationRole =  new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(Id);
            @model.Title = BaseViewPage<string>.GetResourceValue("ManageRole", "RES_PAGETITLE_EditRole").ToString();
            return _result;
        }
        /*<ControllerActionImplementation:SaveRole:1/>*/
        public ActionResult ExecuteSaveRole()
        {
            ActionResult _result = null;
            new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().Save<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(@model.ApplicationRole);
            _result = CloseForm();
            return _result;
        }
        /*<ControllerActionImplementation:DeleteRole:1/>*/
        public ActionResult ExecuteDeleteRole()
        {
            ActionResult _result = null;
            new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().DeleteApplicationRole(@model.ApplicationRole);
            _result = CloseForm();
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:AddPermission:1/>*/
        /*<DataSourceFilter:AddPermission:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission> Get_AddPermission_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_AddPermission_DatasourceQueryableImplementation(__request);
            if (__request.ExcludeKeys != null && __request.ExcludeKeys.Any())
            {
                var keysToExclude = __request.ExcludeKeys.Select(x => x.ToString());
                __items = __items.Where(x => !keysToExclude.Contains(x.Id.ToString()));
            }
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission> Get_AddPermission_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>().AsQueryable();
            return __items;
        }


        /*<DataSourceGetFullRecordset:AddPermission:1/>*/

        [HttpPost]
        [Route("AddPermission_PickList_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AddPermissionDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult AddPermission_PickList_GetFullRecordset()
        {
            var postedData = _ParsePostedData();
            var dataType = postedData["dataType"].ToString();
            var keysToExclude = postedData["keys"] == null
                                ? new List<object>()
                                : postedData["keys"].ToString()
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x as object)
                                .ToList();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var postedDatasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            _LoadViewModel();
            var datasourceRequest = new DatasourceRequest(0, 2147483647, postedDatasourceRequest.Filters, null, keysToExclude, indexes);
            var queryable = Get_AddPermission_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new AddPermissionDataSet_ApplicationPermissionDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(ManageRoleViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "AddPermission");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:AddPermission:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AddPermissionDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("AddPermission_PickList_Datasource")]
        public JsonResult AddPermission_PickList_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_AddPermission_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_AddPermission_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_AddPermission_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_AddPermission_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.Select(i => new AddPermissionDataSet_ApplicationPermissionDTO(i, true)).ToList();
                response.Groups = groups;
//Fix for total items in GetGroupsClosed
                if (datasourceRequest.GroupBy.FirstOrDefault().GetGroupsClosed)
                {
                    response.TotalRows = DatasourceRetriever.GetTotalGroups(groups);
                }
            }
            else
            {
                var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
                response.Data = items.Select(i => new AddPermissionDataSet_ApplicationPermissionDTO(i, true)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        /*<DataSourceAggregators:AddPermission:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AddPermissionDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("AddPermission_PickList_DatasourceAggregators")]
        public JsonResult AddPermission_PickList_DatasourceAggregators()
        {
            object aggregatorsResponse = null;
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_AddPermission_DatasourceQueryable(datasourceRequest);
            queryable = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            var formattings = new Dictionary<string, string>();
            if (datasourceRequest.GroupBy.Any()/* && datasourceRequest.GroupBy.First().GetGroupsClosed*/)
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData, true);
                GroupsHelper.FormatGroupedAggregators(groups, formattings);
                aggregatorsResponse = new ListResponse()
                {
                    Groups = groups
                };
            }
            else
            {
                var aggregatorsInfo = DeserializeAggregatorsRequest<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(postedData["aggregatorsRequest"].ToString());
                var aggregators = RuntimePredicateBuilder.BuildAggregatorPredicates(aggregatorsInfo);
                foreach (var a in aggregators)
                {
                    var formatting = formattings.ContainsKey(a.Column) ? formattings[a.Column] : null;
                    a.Calculate(queryable, formatting);
                }
                aggregatorsResponse = aggregators;
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(aggregatorsResponse)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }




        /*<Datasource:ManageRole_AddPermissionDataSet:1/>*/
        /*<DataSourceFilter:ManageRole_AddPermissionDataSet:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission> Get_ManageRole_AddPermissionDataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_ManageRole_AddPermissionDataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission> Get_ManageRole_AddPermissionDataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>().AsQueryable();
            return __items;
        }


        /*<DataSourceGetFullRecordset:ManageRole_AddPermissionDataSet:1/>*/

        [HttpPost]
        [Route("ManageRole_AddPermissionDataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AddPermissionDataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult ManageRole_AddPermissionDataSet_GetFullRecordset()
        {
            var postedData = _ParsePostedData();
            var dataType = postedData["dataType"].ToString();
            var keysToExclude = postedData["keys"] == null
                                ? new List<object>()
                                : postedData["keys"].ToString()
                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x as object)
                                .ToList();
            var indexes = postedData["indexes"] == null
                          ? null
                          : postedData["indexes"].ToString()
                          .Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToArray();
            var postedDatasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            _LoadViewModel();
            var datasourceRequest = new DatasourceRequest(0, 2147483647, postedDatasourceRequest.Filters, null, keysToExclude, indexes);
            var queryable = Get_ManageRole_AddPermissionDataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new AddPermissionDataSet_ApplicationPermissionDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(ManageRoleViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "ManageRole_AddPermissionDataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:ManageRole_AddPermissionDataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "AddPermissionDataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("ManageRole_AddPermissionDataSet_Datasource")]
        public JsonResult ManageRole_AddPermissionDataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_ManageRole_AddPermissionDataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_ManageRole_AddPermissionDataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_ManageRole_AddPermissionDataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_ManageRole_AddPermissionDataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>();
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.ToList().Select(i => _convertionMethod(i)).ToList();
                response.Groups = groups;
//Fix for total items in GetGroupsClosed
                if (datasourceRequest.GroupBy.FirstOrDefault().GetGroupsClosed)
                {
                    response.TotalRows = DatasourceRetriever.GetTotalGroups(groups);
                }
            }
            else
            {
                var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
                response.Data = items.ToList().Select(i => _convertionMethod(i)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }


        #endregion

        public override ActionResult PreActionFilterHook(bool causesValidation, bool listenToEvent, string actionName)
        {
            System.Web.HttpContext.Current.Items["_currentControllerAction"] = actionName;
            if (listenToEvent) return null;
            return null;
        }
        public override ActionResult PostActionFilterHook(bool hasDefaultResultView, bool fillDropDownInitialValues = false)
        {
            if (HasClientResponse())
            {
                viewDTO.ClientResponse = GetClientResponse();
            }
            else
            {
                var _modelDTO = new ManageRoleViewModelDTO(@model);
                viewDTO.Model = _modelDTO;
            }
            if (!hasDefaultResultView)
            {
                var __result = Json(new
                {
                    Type = "Data",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            return View("ManageRole");
        }

        #region Data Validations


        private ActionResult GetFailedDataValidationsResult()
        {
            try
            {
                RunDataValidations();
                if (!viewDTO.DataValidationsHaveFailed) return null;
                var __result = Json(new
                {
                    Type = "RuleEvaluation",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            catch (Exception e)
            {
                _logger.Error("!!! DANGER: Error while evaluating Data Validations !!!", e);
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: ManageRole, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            var masterPageDataValidations = (_parentController as Controllers.MasterPageForSlide.MasterPageForSlideController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
