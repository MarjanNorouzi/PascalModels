namespace PascalModels.Models
{
    public record InsertDetReq
    { 
        public string DetCode { get; set; }
        public string DetName { get; set; }
    }

    public record EditDetReq : InsertDetReq
    {
        public int DetId { get; set; }
    }
}
