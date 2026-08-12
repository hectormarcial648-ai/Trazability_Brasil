using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TrazabilityBrasil.Models
{
    [Keyless]
    [Table("BigData_BalancingC1_b")]
    public class B12Bal
    {
        [Column("TIME")]
        [StringLength(33)]
        public string? Time { get; set; }

        [Column("USER")]
        [StringLength(33)]
        public string? User { get; set; }

        [Column("BARCODE")]
        public string? MotorCode { get; set; }

        [Column("TIME SCAPED", TypeName = "decimal(12,2)")]
        public decimal? CycleTime { get; set; }

        [Column("FINAL STATUS")]
        [StringLength(12)]
        public string? FinalStatus { get; set; }

        [Column("VOLTAGE", TypeName = "decimal(12,2)")]
        public decimal? Voltage { get; set; }

        [Column("CURRENT", TypeName = "decimal(12,2)")]
        public decimal? Current { get; set; }

        [Column("SPEED", TypeName = "decimal(12,0)")]
        public decimal? Speed { get; set; }

        [Column("STATIC")]
        [StringLength(15)]
        public string? Static { get; set; }

        [Column("STATIC ANGLE")]
        [StringLength(15)]
        public string? StaticAngle { get; set; }

        [Column("COUPLE")]
        [StringLength(15)]
        public string? Couple { get; set; }

        [Column("COUPLE ANGLE")]
        [StringLength(15)]
        public string? CoupleAngle { get; set; }

        [Column("PLANE 1")]
        [StringLength(15)]
        public string? Plane1 { get; set; }

        [Column("PLANE 1 ANGLE")]
        [StringLength(15)]
        public string? Unbalance { get; set; }

        [Column("PLANE 2")]
        [StringLength(15)]
        public string? Plane2 { get; set; }

        [Column("PLANE 2 ANGLE")]
        [StringLength(15)]
        public string? UnbalancePlane2 { get; set; }

        [Column("BALANCING SPEED")]
        [StringLength(15)]
        public string? BalancingSpeed { get; set; }

        [Column("LEFT BLADE", TypeName = "decimal(9,0)")]
        public decimal? LeftBlade { get; set; }

        [Column("LEFT RADIUS", TypeName = "decimal(9,0)")]
        public decimal? LeftRadius { get; set; }

        [Column("LEFT CLIP", TypeName = "decimal(9,0)")]
        public decimal? LeftClip { get; set; }

        [Column("RIGHT BLADE", TypeName = "decimal(9,0)")]
        public decimal? RightBlade { get; set; }

        [Column("RIGHT RADIUS", TypeName = "decimal(9,0)")]
        public decimal? RightRadius { get; set; }

        [Column("RIGHT CLIP", TypeName = "decimal(9,0)")]
        public decimal? RightClip { get; set; }
    }
}
