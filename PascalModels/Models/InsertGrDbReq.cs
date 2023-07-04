namespace PascalModels.Models
{
    public record InsertGrDbReq
    {
        //کدگروه
        //کد مقداردهی شده تکراری نباشد
        //باید دارای 2 رقم باشد
        public string GrCode { get; set; }
        //نام گروه
        //بیشترین تعداد کاراکتر 50 است
        public string GrName { get; set; }
        public int Grkind { get; set; }

    }

    public record EditGrDbReq : InsertGrDbReq
    {
        public int GrId { get; set; }
    }

}
