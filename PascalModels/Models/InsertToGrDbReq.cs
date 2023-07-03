namespace PascalModels.Models
{
    public class InsertToGrDbReq
    {
        public string GrCode { get; set; }
        public string GrName { get; set; }
        public int Grkind { get; set; }

    }

    public class EditGrDbReq : InsertToGrDbReq
    {
        public int GrId { get; set; }
    }

}
