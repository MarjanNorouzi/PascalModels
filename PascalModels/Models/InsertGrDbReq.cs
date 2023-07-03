namespace PascalModels.Models
{
    public class InsertGrDbReq
    {
        public string GrCode { get; set; }
        public string GrName { get; set; }
        public int Grkind { get; set; }

    }

    public class EditGrDbReq : InsertGrDbReq
    {
        public int GrId { get; set; }
    }

    public class DeleteGrDbReq
    {

    }
}
