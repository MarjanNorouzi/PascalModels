using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GroupsListReportReq : RemainedAccReq
    {
        /// <summary>
        /// <para><em>اسم : از گروه</em></para> 
        /// <para>باید کوچکتر باشد 'GroupTo' از</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string GroupFrom { get; set; }
        /// <summary>
        /// <para><em>اسم : تا گروه</em></para> 
        /// <para>باید بزرگتر باشد 'GroupFrom' از</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string GroupTo { get; set; }
        /// <summary>
        /// <para><em>اسم : نوع گروه</em></para> 
        /// <para>بین 1 تا 3 قابل انتخاب است و همچنین میتواند مقدار خالی رد شود </para> 
        /// </summary>
        public int? GroupKind { get; set; }
    }
    public record GroupsListReportRes : Remained
    {
        /// <summary>
        /// <para><em>اسم : کد گروه</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// </summary>
        public string GroupCode { get; set; }
        /// <summary>
        /// <para><em>اسم : نام گروه</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50 </para> 
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// <para><em>اسم : نوع گروه</em></para> 
        /// </summary>
        public string GroupKind { get; set; }
    }
    public record GroupsListReportTotalRes : TotalRemained
    {
    }
}