namespace PascalModels.Models
{
    public record InsertDetSubReq
    {
        public string DetCode { get; set; }
        public string SubCodes { get; set; }
    }

    public record EditDetSubReq : InsertDetSubReq
    {
        public int DetSubId { get; set; }
    }
}
