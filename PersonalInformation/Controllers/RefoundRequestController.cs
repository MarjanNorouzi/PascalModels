using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PersonalInformation.Models;

namespace PersonalInformation.Controllers
{
    /// <summary>
    /// توضیحات کل کنترلر
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RefoundRequestController : ControllerBase
    {
        /// <summary>
        /// ارسال درخواست ریفاند
        /// </summary>
        /// <remarks>
        /// fill refer and sell date OR flight id
        /// </remarks>
        /// <param name="request">WeatherForeCast object</param>
        /// <item><description><para><em>test para</em></para></description></item>
        /// 
        /// <returns>Returns IActionResult response</returns>
        [ServiceFilter(typeof(IActionFilter))]
        [HttpPost]
        public IActionResult Requst([FromForm] RefoundRequest request)
        {
            return Ok();
        }
    }
}
