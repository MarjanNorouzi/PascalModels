using System.ComponentModel;

namespace PersonalInformation.Models
{
    public class RefoundRequest : IRequest
    {
        [DefaultValue("1111/11/23")]
        public string? SellDate { get; set; }
        
        [DefaultValue("ABC123")]
        public string? Refer { get; set; }
        
        [DefaultValue(" ")]
        public string FlightId { get; set;}
        
        [DefaultValue(" ")]
        public string Remark { get; set; }
    }
}
