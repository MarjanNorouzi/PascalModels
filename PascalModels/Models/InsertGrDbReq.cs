namespace PascalModels.Models
{
    public record InsertGrDbReq
    {
        public string GrCode { get; set; }
        public string GrName { get; set; }
        public int Grkind { get; set; }

    }

    public record EditGrDbReq : InsertGrDbReq
    {
        public int GrId { get; set; }
    }

    public record DeleteGrDbReq
    {

    }
}
