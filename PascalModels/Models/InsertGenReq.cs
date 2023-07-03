namespace PascalModels.Models
{
    public record InsertGenReq
    {
        public string GroupCode { get; set; }
        public string GenCode { get; set; }
        public string GenName { get; set; }
    }

    public record EditGenReq : InsertGenReq
    {
        public int GenId { get; set; }
    }
}
