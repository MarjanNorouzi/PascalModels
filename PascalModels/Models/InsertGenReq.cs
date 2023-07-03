namespace PascalModels.Models
{
    public class InsertGenReq
    {
        public string GroupCode { get; set; }
        public string GenCode { get; set; }
        public string GenName { get; set; }
    }
    public class InsertDetReq
    {
        public string DetCode { get; set; }
        public string DetName { get; set; }
    }
}
