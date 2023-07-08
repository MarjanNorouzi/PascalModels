using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PascalModels.Models;

namespace Pascal.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubListReportByDetAndSubCodeReqsController : ControllerBase
    {
        /// <summary>لیست معین - بر اساس معین و تفصیل</summary>
        /// <remarks>
        ///     <para>با استفاده از کد معین و تفصیل گزارش معین بر میگردد</para> 
        ///     <para>کد معین نمیتواند خالی باشد و همچنین باید شامل 6 رقم باشد</para>
        ///     <para>کد تفصیل اختیاری میباشد</para> 
        /// </remarks>
        [ServiceFilter(typeof(IActionFilter))]
        [HttpPost]
        public IActionResult Requst(SubListReportByDetAndSubCodeReq request)
        {
            return Ok();
        }
    }
}
