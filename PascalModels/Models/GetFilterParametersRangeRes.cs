using System.ComponentModel.DataAnnotations;

namespace Personal_Information.Models.ProcModels
{
    public class GetFilterParametersRangeRes
    {
        [StringLength(2)]
        public string GrpMin { get; set; }

        [StringLength(2)]
        public string GrpMax { get; set; }

        [StringLength(6)]
        public string GenMin { get; set; }

        [StringLength(6)]
        public string GenMax { get; set; }

        [StringLength(10)]

        public string SubMin { get; set; }

        [StringLength(10)]

        public string SubMax { get; set; }

        [StringLength(8)]
        public string DetMin { get; set; }

        [StringLength(8)]
        public string DetMax { get; set; }
        public int SanadMin { get; set; }
        public int SanadMax { get; set; }

    }
}