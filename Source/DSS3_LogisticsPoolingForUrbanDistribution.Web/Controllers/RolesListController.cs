// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS3_LogisticsPoolingForUrbanDistribution.BO;
using DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.RolesList;
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

namespace DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.RolesList
{

    [RoutePrefix("RolesList")]
    public class RolesListController : ControllerBase<RolesListViewModel, RolesListViewModelDTO>
    {

        /*<Form:RolesList:0/>*/
        public RolesListController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(RolesListController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPage.MasterPageViewModel
            {
                Title = model.Title
            };
            _parentController = new MasterPage.MasterPageController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(RolesListViewModel m)
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
            return PrepareUpdateInstanceResult(typeof(RolesListViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }

        [HttpGet]
        [Route("DownloadFile")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFile(string id)
        {
            return FileHelper.PendingDownloadInstance.DownloadByKey("RolesList", id);
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
            return SaveListView(postedData, "RolesList");
        }


        [Route("DeleteListView")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult DeleteListView()
        {
            var postedData = _ParsePostedData();
            return DeleteListView(postedData, "RolesList");
        }


        [Route("LoadListViews")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult LoadListViews()
        {
            var postedData = _ParsePostedData();
            return LoadListViews(postedData, "RolesList");
        }



        #region Controller Actions
        [CustomControllerActionFilter(CausesValidation=true, ActionName="Refresh", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("Refresh")]
        public ActionResult Refresh()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteRefresh();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Retrieve")]
        public ActionResult Retrieve()

        {
            @model = new RolesListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_RolesList"] = "Retrieve";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Retrieve", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Retrieve")]
        public ActionResult _API_Retrieve()

        {
            @model = new RolesListViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_RolesList"] = "Retrieve";
            PushToHistory();
            var _masterController = new DSS3_LogisticsPoolingForUrbanDistribution.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRetrieve();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Refresh:1/>*/
        public ActionResult ExecuteRefresh()
        {
            ActionResult _result = null;
            ClientCommand(ClientCommands.DATALIST_REFRESH, "List");
            return _result;
        }
        /*<ControllerActionImplementation:Retrieve:1/>*/
        public ActionResult ExecuteRetrieve()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS3_LogisticsPoolingForUrbanDistribution.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = BaseViewPage<string>.GetResourceValue("RolesList", "RES_PAGETITLE_Retrieve").ToString();
            return _result;
        }
        #endregion
        #region Datasource controls
        /*<Datasource:List:1/>*/
        /*<DataSourceFilter:List:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole> Get_List_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_List_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole> Get_List_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>().AsQueryable();
            return __items;
        }


        /*<DataSourceGetFullRecordset:List:1/>*/

        [HttpPost]
        [Route("List_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult List_GetFullRecordset()
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
            var queryable = Get_List_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new List1DataSet_ApplicationRoleDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(RolesListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "List");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:List:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("List_Datasource")]
        public JsonResult List_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_List_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_List_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_List_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_List_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, postedData);
                var items = groups.GetAllItems();
                response.Data = items.Select(i => new List1DataSet_ApplicationRoleDTO(i, true)).ToList();
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
                response.Data = items.Select(i => new List1DataSet_ApplicationRoleDTO(i, true)).ToList();
            }
            var __result = Json(new
            {
                Type = "DatasourceData",Data = Serialize(response)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        /*<DataSourceAggregators:List:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("List_DatasourceAggregators")]
        public JsonResult List_DatasourceAggregators()
        {
            object aggregatorsResponse = null;
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_List_DatasourceQueryable(datasourceRequest);
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
                var aggregatorsInfo = DeserializeAggregatorsRequest<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(postedData["aggregatorsRequest"].ToString());
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




        [Route("List_Export")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult List_Export()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"]?.ToString());
            var exportOptions = ExportHelper.ParseExportOptions(postedData);
            var aggregatorsInfo = DeserializeAggregatorsRequest<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(exportOptions.AggregatorsRequest);
            var downloadKey = List_ExportImplementation(datasourceRequest, exportOptions, aggregatorsInfo);
            var __result = Json(new
            {
                Data = downloadKey
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        [NonAction]
        public string List_ExportImplementation(DatasourceRequest datasourceRequest, ExportHelper.ExportOptions exportOptions, List<AggregatorInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>> aggregatorsInfo)
        {
            if (exportOptions.Range == ExportHelper.Range.TOP100)
            {
                datasourceRequest.StartRow = 0;
                datasourceRequest.PageSize = 100;
            }
            else if (exportOptions.Range == ExportHelper.Range.ALL)
            {
                datasourceRequest.StartRow = 0;
                datasourceRequest.PageSize = int.MaxValue;
            }
            if (string.IsNullOrWhiteSpace(exportOptions.Filename))
            {
                exportOptions.Filename = "List";
            }
            if (exportOptions.ColumnOptions == null)
            {
                exportOptions.ColumnOptions = new List<ExportHelper.ColumnOptions>
                {
                    new ExportHelper.ColumnOptions { Column = "Name", IsVisible = true },
                    new ExportHelper.ColumnOptions { Column = "Description", IsVisible = true },
                    new ExportHelper.ColumnOptions { Column = "IsCustom", IsVisible = true },

                };
            }
            var queryable = Get_List_DatasourceQueryable(datasourceRequest);
            var totalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count();
            var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
            var dto = items.Select(i => new List1DataSet_ApplicationRoleDTO(i));
            var formattings = new Dictionary<string, string>();
            var aggregators = RuntimePredicateBuilder.BuildAggregatorPredicates(aggregatorsInfo);
            foreach (var a in aggregators)
            {
                var formatting = formattings.ContainsKey(a.Column) ? formattings[a.Column] : null;
                a.Calculate(queryable, formatting);
            }
            var exportDataDTO = new List<ExportHelper.ExportRecordDTO>();
            foreach (var record in dto)
            {
                var recordDTO = new ExportHelper.ExportRecordDTO();
                recordDTO.Columns.Add(new ExportHelper.ExportColumnDTO
                {
                    ColumnName = nameof(record.Name),
                    Value = record?.Name,
                    ColumnDataType = "string",
                    Format = "",
                    ExcelFormat = @"",
                    Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_Name")
                });
                recordDTO.Columns.Add(new ExportHelper.ExportColumnDTO
                {
                    ColumnName = nameof(record.Description),
                    Value = record?.Description,
                    ColumnDataType = "string",
                    Format = "",
                    ExcelFormat = @"",
                    Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_Description")
                });
                recordDTO.Columns.Add(new ExportHelper.ExportColumnDTO
                {
                    ColumnName = nameof(record.IsCustom),
                    Value = record?.IsCustom,
                    ColumnDataType = "bool",
                    Format = "",
                    ExcelFormat = @"",
                    Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_IsCustom")
                });
                exportDataDTO.Add(recordDTO);
            }
            if (aggregators.Count > 0)
            {
                foreach (AggregatorType aggregatorType in Enum.GetValues(typeof(AggregatorType)))
                {
                    var emptyAggregatorRow = true;
                    var recordDTO = new ExportHelper.ExportRecordDTO();
                    foreach (var columnOption in exportOptions.ColumnOptions)
                    {
                        var aggregatorValue = "";
                        switch (aggregatorType)
                        {
                        case AggregatorType.COUNT:
                            if (columnOption.CountIsVisible)
                            {
                                var averageAggregator = aggregators.SingleOrDefault(agg => agg.Column == columnOption.Column && agg.Type == AggregatorType.COUNT);
                                aggregatorValue = $"{BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATALIST_AGGREGATORS_GrandCount")} {averageAggregator?.ValueFormatted}";
                                emptyAggregatorRow = false;
                            }
                            break;
                        case AggregatorType.SUM:
                            if (columnOption.SumIsVisible)
                            {
                                var averageAggregator = aggregators.SingleOrDefault(agg => agg.Column == columnOption.Column && agg.Type == AggregatorType.SUM);
                                aggregatorValue = $"{BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATALIST_AGGREGATORS_GrandTotal")} {averageAggregator?.ValueFormatted}";
                                emptyAggregatorRow = false;
                            }
                            break;
                        case AggregatorType.AVERAGE:
                            if (columnOption.AverageIsVisible)
                            {
                                var averageAggregator = aggregators.SingleOrDefault(agg => agg.Column == columnOption.Column && agg.Type == AggregatorType.AVERAGE);
                                aggregatorValue += $"{BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATALIST_AGGREGATORS_GrandAverage")} {averageAggregator?.ValueFormatted}";
                                emptyAggregatorRow = false;
                            }
                            break;
                        }
                        recordDTO.Columns.Add(new ExportHelper.ExportColumnDTO
                        {
                            ColumnName = columnOption.Column,
                            Value = aggregatorValue,
                            ColumnDataType = "string",
                            Format = ""
                        });
                    }
                    if (!emptyAggregatorRow)
                    {
                        exportDataDTO.Add(recordDTO);
                    }
                }
            }
            var path = ExportHelper.ExportList(exportDataDTO, exportOptions, totalRows);
            var content = System.IO.File.ReadAllBytes(Path.Combine(Path.GetTempPath(), path));
            var fileName = Path.GetFileName(path);
            return FileHelper.PendingDownloadInstance.Add("RolesList", content, fileName);
        }

        [Route("List_ExportV2")]
        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public JsonResult List_ExportV2()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var exportOptions = Utilities.Deserialize<ExportOptionsV2>(postedData["exportData"]?.ToString());
            var aggregatorsInfo = DeserializeAggregatorsRequest<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(postedData["aggregatorsRequest"]?.ToString());
            var downloadKey = List_ExportV2Implementation(datasourceRequest, exportOptions, aggregatorsInfo);
            var __result = Json(new
            {
                Data = downloadKey
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }

        [NonAction]
        public string List_ExportV2Implementation(DatasourceRequest datasourceRequest, ExportOptionsV2 exportOptions, List<AggregatorInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>> aggregatorsInfo)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long elapsedMilliseconds = 0;
            switch (exportOptions.Range)
            {
            case ExportHelper.Range.ALL:
                datasourceRequest.StartRow = 0;
                datasourceRequest.PageSize = int.MaxValue;
                break;
            case ExportHelper.Range.TOP100:
                datasourceRequest.StartRow = 0;
                datasourceRequest.PageSize = 100;
                break;
            }
            var queryable = Get_List_DatasourceQueryable(datasourceRequest);
            var formattings = new Dictionary<string, string>();
            var path = "";
            var exportHelper = new ExportHelperV2<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(exportOptions, new Dictionary<string, Func<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole, object>>
            {
                {"Name" , item => item?.Name }, {"Description" , item => item?.Description }, {"IsCustom" , item => item?.IsCustom },
            });
            if (exportHelper.Options.ColumnInfo == null)
            {
                exportHelper.Options.ColumnInfo = new List<ColumnOptionsV2>
                {
                    new ColumnOptionsV2 { Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_Name"), Formatting = "", Name = "Name", ExcelFormat = @"" },
                    new ColumnOptionsV2 { Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_Description"), Formatting = "", Name = "Description", ExcelFormat = @"" },
                    new ColumnOptionsV2 { Caption = BaseViewPage<object>.GetResourceValue("RolesList", "RES_LIST_List_COLUMN_IsCustom"), Formatting = "", Name = "IsCustom", ExcelFormat = @"" },

                };
            }
            if (string.IsNullOrWhiteSpace(exportHelper.Options.Filename))
            {
                exportHelper.Options.Filename = "List";
            }
            if (datasourceRequest.GroupBy.Any())
            {
                var groups = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, aggregatorsInfo);
                var aggregators = DatasourceRetriever.RetrieveGrouped(datasourceRequest, queryable, q => q.Id, aggregatorsInfo, true);
                GroupsHelper.FormatGroupedAggregators(aggregators, formattings);
                watch.Stop();
                elapsedMilliseconds = watch.ElapsedMilliseconds;
                _logger.Info($"ExportV2 Performance: List export query with grouping and range {exportOptions.Range} took {elapsedMilliseconds}ms");
                watch.Restart();
                path = exportHelper.Export(groups, aggregators);
                watch.Stop();
                elapsedMilliseconds += watch.ElapsedMilliseconds;
                _logger.Info($"ExportV2 Performance: List export to excel with grouping and range {exportOptions.Range} took {watch.ElapsedMilliseconds}ms");
            }
            else
            {
                var items = DatasourceRetriever.Retrieve(datasourceRequest, queryable);;
                var aggregators = RuntimePredicateBuilder.BuildAggregatorPredicates(aggregatorsInfo);
                foreach (var a in aggregators)
                {
                    var formatting = formattings.ContainsKey(a.Column) ? formattings[a.Column] : null;
                    a.Calculate(queryable, formatting);
                }
                var loadedItems = items.ToList();
                watch.Stop();
                elapsedMilliseconds = watch.ElapsedMilliseconds;
                _logger.Info($"ExportV2 Performance: List export query with range {exportOptions.Range} took {elapsedMilliseconds}ms");
                watch.Restart();
                path = exportHelper.Export(loadedItems, aggregators);
                watch.Stop();
                elapsedMilliseconds += watch.ElapsedMilliseconds;
                _logger.Info($"ExportV2 Performance: List export to excel with range {exportOptions.Range} took {elapsedMilliseconds}ms");
            }
            var content = System.IO.File.ReadAllBytes(Path.Combine(Path.GetTempPath(), path));
            var fileName = Path.GetFileName(path);
            var downloadKey = FileHelper.PendingDownloadInstance.Add("RolesList", content, fileName);
            _logger.Info($"ExportV2 Performance: Total export time for List: {elapsedMilliseconds}ms");
            return downloadKey;
        }



        /*<Datasource:RolesList_List1DataSet:1/>*/
        /*<DataSourceFilter:RolesList_List1DataSet:2/>*/
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole> Get_RolesList_List1DataSet_DatasourceQueryable(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            if (shouldEvict)
            {
                @model?.Evict();
            }
            var __items = Get_RolesList_List1DataSet_DatasourceQueryableImplementation(__request);
            return __items;
        }
        public IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole> Get_RolesList_List1DataSet_DatasourceQueryableImplementation(DatasourceRequest __request = null, bool shouldEvict = true)
        {
            __request = __request ?? new DatasourceRequest(0, int.MaxValue);
            var __items = new DSS3_LogisticsPoolingForUrbanDistribution.DAL.Repository().GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>().AsQueryable();
            return __items;
        }


        /*<DataSourceGetFullRecordset:RolesList_List1DataSet:1/>*/

        [HttpPost]
        [Route("RolesList_List1DataSet_GetFullRecordset")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        public JsonResult RolesList_List1DataSet_GetFullRecordset()
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
            var queryable = Get_RolesList_List1DataSet_DatasourceQueryable(datasourceRequest);
            var items = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable);
            //The following method of creating DTO responses has been changed due to the fact that the returned objects were missing properties that were not used by the client.
            //It now uses the UpdateInstance method. To be removed after some testing if no problems occur.
            //var data = items.Select(i => new List1DataSet_ApplicationRoleDTO(i, true)).ToList();
            var data = CreateDtoInstancesFromKeys(typeof(RolesListViewModel), dataType, items.Select(i => i.Id.ToString()).ToList(), "RolesList_List1DataSet");
            var __result = Json(new
            {
                Type = "UpdateInstance",Data = Utilities.Serialize(data)
            }, JsonRequestBehavior.AllowGet);
            __result.MaxJsonLength = int.MaxValue;
            return __result;
        }
        /*<DataSourceEntryPoint:RolesList_List1DataSet:1/>*/

        [HttpPost]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "List1DataSet", ClaimType = ClaimTypes.Dataset)]
        [Route("RolesList_List1DataSet_Datasource")]
        public JsonResult RolesList_List1DataSet_Datasource()
        {
            var postedData = _LoadViewModel();
            var datasourceRequest = DeserializeDatasourceRequest(postedData["datasourceRequest"].ToString());
            var queryable = Get_RolesList_List1DataSet_DatasourceQueryable(datasourceRequest);
            var response = new ListResponse
            {
                TotalRows = DatasourceRetriever.ApplyDynamicFilterToQueryable(datasourceRequest, queryable).Count(),
            };
            //Total items count
            if (CLMS.AppDev.Cache.CacheManager.Current.HasKey($"{Request.RequestContext.HttpContext.Session.SessionID}_RolesList_List1DataSet_TotalItems"))
            {
                CLMS.AppDev.Cache.CacheManager.Current.Set($"{Request.RequestContext.HttpContext.Session.SessionID}_RolesList_List1DataSet_TotalItems", response.TotalRows);
            }
            else
            {
                CLMS.AppDev.Cache.CacheManager.Current.Add($"{Request.RequestContext.HttpContext.Session.SessionID}_RolesList_List1DataSet_TotalItems", response.TotalRows);
            }
            if (response.TotalRows < datasourceRequest.StartRow + 1)
            {
                datasourceRequest.StartRow = 0;
            }
            var _dto = DynamicDtoInfo.CreateFromPropsArray(datasourceRequest.DtoProperties);
            var _convertionMethod = _dto.GetConvertionFunc<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>();
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
                var _modelDTO = new RolesListViewModelDTO(@model);
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
            return View("RolesList");
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
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: RolesList, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            var masterPageDataValidations = (_parentController as Controllers.MasterPage.MasterPageController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
