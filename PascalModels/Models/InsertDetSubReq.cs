namespace PascalModels.Models
{
    public class InsertDetSubReq
    {
        public string DetCode { get; set; }
        public string SubCodes { get; set; }
    }

    public class EditDetSubReq : InsertDetReq
    {
        public int DetSubId { get; set; }
    }
}
