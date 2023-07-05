namespace PascalModels.Models
{
    public record InsertGrDbReq
    {
        //کدگروه
        //اجباری
        //کد مقداردهی شده تکراری نباشد
        //باید دارای 2 رقم باشد
        public string GrCode { get; set; }
        //نام گروه
        //اجباری
        //بیشترین تعداد کاراکتر 50 است
        public string GrName { get; set; }
        //نوع گروه
        //اجباری
        public int Grkind { get; set; }

    }

    public record EditGrDbReq : InsertGrDbReq
    {
        //آی دی گروه
        //اجباری
        public int GrId { get; set; }
    }

}
