namespace PascalModels.Models.BaseModels
{
    public record ItemsDeleteReq
    {
        public IEnumerable<int> Ids { get; set; }
    }
}
