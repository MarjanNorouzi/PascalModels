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
        /// 
        /// <remarks>
        ///     <paramref name="request"></paramref>
        ///     <para><em>ورودی میگیرد GeneralsListReportReq یک</em></para>
        ///     <para><returns>برمیگرداند IActionResult </returns></para>
        ///     <para>با استفاده از  کد گروه یک لیست از کل با جمع بدهکار و بستانکار و مانده برمیگردد</para> 
        ///     <para>کد گروه نمیتواند خالی باشد و همچنین باید شامل 2 رقم باشد</para> 
        ///     <para>دارای فیلتر حساب های مانده دار نیز می باشد</para> 
        /// </remarks>
        [ServiceFilter(typeof(IActionFilter))]
        [HttpPost]
        public IActionResult Requst([FromForm] GeneralsListReportReq request)
        {
            var header = Request.Headers["X-CustomHeader"];
            return Ok();
        }
    }
}
