using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GroupsListReportReq : RemainedAccReq
    {
        //از گروه
        //اجباری
        //باید بزرگتر باشد 'GroupTo' از 
        public string GroupFrom { get; set; }
        //تا گروه
        //اجباری
        //باید کوچکتر باشد 'GroupFrom' از 
        public string GroupTo { get; set; }
        //نوع گروه
        //بین 1 تا 3 قابل انتخاب است و همچنین میتواند مقدار خالی رد شود  
        public int? GroupKind { get; set; }
    }
    public record GroupsListReportRes : Remained
    {
        //کد گروه
        //باید دارای 2 رقم باشد
        public string GroupCode { get; set; }
        //نام گروه
        //بیشترین تعداد کاراکتر 50 است
        public string GroupName { get; set; }
        //نوع گروه
        public string GroupKind { get; set; }
    }
    public record GroupsListReportTotalRes : TotalRemained
    {
    }
}