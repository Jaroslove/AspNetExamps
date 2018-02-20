using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetExamps.Models
{
    public class CookieValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return HttpContext.Current.Request.Cookies.AllKeys.Contains(prefix);
        }

        public ValueProviderResult GetValue(string key)
        {
            HttpCookieCollection cookie = HttpContext.Current.Request.Cookies;

            return ContainsPrefix(key) ?
                new ValueProviderResult(cookie[key].Value, cookie[key].Value, CultureInfo.CurrentCulture) :
                null;
        }
    }
    public class CookieValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext) => new CookieValueProvider();
    }
}