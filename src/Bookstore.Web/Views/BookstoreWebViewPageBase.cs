using Abp.Web.Mvc.Views;

namespace Bookstore.Web.Views
{
    public abstract class BookstoreWebViewPageBase : BookstoreWebViewPageBase<dynamic>
    {

    }

    public abstract class BookstoreWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BookstoreWebViewPageBase()
        {
            LocalizationSourceName = BookstoreConsts.LocalizationSourceName;
        }
    }
}