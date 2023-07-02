using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class RefersReportReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
    }
    public class RefersReportRes : Remained
    {
        public int Number { get; set; }
        public string Refer { get; set; }
        public bool Flag { get; set; }
    }
}
