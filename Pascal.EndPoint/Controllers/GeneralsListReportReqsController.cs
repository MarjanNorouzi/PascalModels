using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PascalModels.Models;

namespace Pascal.EndPoint.Controllers
{
    /// <summary>
    /// توضیحات کل کنترلر
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralsListReportReqsController : ControllerBase
    {
        /// <summary>لیست کل ها - بر اساس گروه</summary>
        /// <remarks>
        ///     <para>ورودی میگیرد GeneralsListReportReq یک</para>
        ///     <para>با استفاده از  بازه ی کل یک لیست از کل با جمع بدهکار و بستانکار و مانده برمیگردد</para> 
        ///     <para>کد کل نمیتواند خالی باشد و همچنین باید 4 رقم باشد</para> 
        ///     <para>دارای فیلتر حساب های مانده دار نیز می باشد</para> 
        /// </remarks>
        [ServiceFilter(typeof(IActionFilter))]
        [HttpPost]
        public IActionResult Requst(GeneralsListReportReq request)
        {
            var header = Request.Headers["X-CustomHeader"];
            return Ok();
        }
    }
}
