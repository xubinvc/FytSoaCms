#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Role.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c51a98c3c3be006d724c19e9f634ddfa6b9f72e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Role), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/Role.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/Role.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Role), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51a98c3c3be006d724c19e9f634ddfa6b9f72e2", @"/Pages/FytAdmin/Sys/Role.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_Role : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Role.cshtml"
  
    ViewData["Title"] = "角色管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(140, 846, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""layui-col-220"">
        <div class=""layui-nav-title"">角色管理</div>
        <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeAdd""><i class=""layui-icon""></i> 新增</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeDel""><i class=""layui-icon""></i> 删除</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolMenu""><i class=""layui-icon layui-icon-template""></i> 角色分配功能模块</button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(986, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bceb63dc80ea480aa3afcc05b37385ce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1077, 5924, true);
            WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'ztree', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    ztree = layui.ztree,
                    os = layui.common,
                    form = layui.form;
                table.render({
                    elem: '#tablist',
                    url: '/api/role/getpages',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'name', title: '角色名称', sort: true, fixed: 'left' },
                            { field: 'codes', title: '编号' },
                            { field: 'summary', title: '描述' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    pag");
            WriteLiteral(@"e: true,
                    id: 'tables'
                });
                var setting = {
                    async: {
                        enable: true,
                        url: ""/api/organize/gettree""
                    },
                    callback: {
                        onClick: onClick
                    }
                };
                var guid = '', typeName = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: guid
                                }
                            });
                    },
                    toolMenu: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
      ");
            WriteLiteral(@"                  if (data.length === 0) {
                            os.error(""请选择要授权的角色~"");
                            return;
                        }
                        var str = '',strCount=0;
                        $.each(data, function (i, item) {
                            str = item.guid;
                            strCount++;
                        });
                        if (strCount > 1) {
                            os.warning('每次只能授权一个角色~');
                            return;
                        }
                        os.Open('角色分配功能模块', '/fytadmin/sys/rolemenu?roid='+str, '750px', '450px', function () {
                            //os.success(""分配成功~"");
                        });
                    },
                    organizeAdd: function () {
                        os.Open('添加角色', '/fytadmin/sys/rolemodify', '620px', '400px', function () {
                            active.reload();
                            var tree = $.fn.zTree.getZTreeOb");
            WriteLiteral(@"j(""tree"");
                            tree.reAsyncChildNodes(null, ""refresh"");
                        });
                    },
                    organizeDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/role/delete/', { parm: str }, function (res) {
        ");
            WriteLiteral(@"                        layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    var tree = $.fn.zTree.getZTreeObj(""tree"");
                                    tree.reAsyncChildNodes(null, ""refresh"");
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                $.fn.zTree.init($(""#tree""), setting);
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                function onClick(event, treeId, treeNode, clickFlag) {
                    guid = treeNode.guid;
               ");
            WriteLiteral(@"     active.reload();
                }
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑角色', '/fytadmin/sys/rolemodify/?guid=' + data.guid, '620px', '400px', function () {
                            var tree = $.fn.zTree.getZTreeObj(""tree"");
                            tree.reAsyncChildNodes(null, ""refresh"");
                            active.reload();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.RoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.RoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.RoleModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.RoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
