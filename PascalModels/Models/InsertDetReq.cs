namespace PascalModels.Models
{
    public class InsertDetReq
    { 
        public string DetCode { get; set; }
        public string DetName { get; set; }
    }

    public class EditDetReq : InsertDetReq
    {
        public int DetId { get; set; }
    }
}
