namespace PascalModels.Models.BaseModels
{
    public record StandardMessage
    {
        public int ResultStatus { get; set; }
        public string Message { get; set; }
    }
}
