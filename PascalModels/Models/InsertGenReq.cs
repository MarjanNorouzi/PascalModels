namespace PascalModels.Models
{
    public class InsertGenReq
    {
        public string GroupCode { get; set; }
        public string GenCode { get; set; }
        public string GenName { get; set; }
    }

    public class EditGenReq : InsertGenReq
    {
        public int GenId { get; set; }
    }
}
