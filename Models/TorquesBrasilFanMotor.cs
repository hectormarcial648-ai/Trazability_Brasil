using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrazabilityBrasil.Models
{
    [Table("TorquesBrasil_FanMotor", Schema = "dbo")]
    public class TorquesBrasilFanMotor
    {
        [Key]
        public int Id { get; set; }

        public DateTime? TorqueValue_TIMESTAMP { get; set; }

        [Column(TypeName = "char(64)")]
        public string? VIN { get; set; }

        public int? AngleMin { get; set; }
        public int? AngleValue { get; set; }
        public int? AngleMax { get; set; }

        public float? TorqueMin { get; set; }
        public float? TorqueValue { get; set; }
        public float? TorqueMax { get; set; }
        public float? TorqueTarget { get; set; }

        public int? AngleTarget { get; set; }
    }
}
