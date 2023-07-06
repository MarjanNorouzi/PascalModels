using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PascalModels.Models.BaseModels
{
    public record FromDateToDateReq : BaseModel, IBaseModel
    {
        /// <summary>
        /// <para>اسم : از تاریخ</para> 
        /// <para>باید کوچکتر باشد 'ToDate' از </para> 
        /// </summary>
        public DateTimeOffset? FromDate { get; set; }
        /// <summary>
        /// <para>اسم : تا تاریخ</para> 
        /// <para>باید بزرگتر باشد 'FromDate' از </para> 
        /// </summary>
        public DateTimeOffset? ToDate { get; set; }
    }
    public record NumberDateFilterReq : FromDateToDateReq
    {
        /// <summary>
        /// <para>اسم : از شماره سند</para> 
        /// <para>باید کوچکتر باشد 'NumTo' از </para> 
        /// </summary>
        /// <example>1</example>
        public int? NumFrom { get; set; }
        /// <summary>
        /// <para>اسم : تا شماره سند</para> 
        /// <para>باید کوچکتر باشد 'NumFrom' از </para> 
        /// </summary>
        /// <example>700</example>
        public int? NumTo { get; set; }
    }
    public record RemainedAccReq : NumberDateFilterReq
    {
        /// <summary>
        /// <para>اسم : مانده حساب</para> 
        /// </summary>
        [DefaultValue(false)]
        public bool RemainedAcc { get; set; } = false;
    }
}
