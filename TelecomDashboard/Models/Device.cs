using System;
using System.ComponentModel.DataAnnotations;

namespace TelecomDashboard.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  // Device Name

        [Required]
        public string IPAddress { get; set; }  // Device IP Address

        public bool IsOnline { get; set; }  // Online/Offline Status

        public int SignalStrength { get; set; }  // 0-100 %

        public DateTime LastChecked { get; set; }  // Last Ping Time
    }
}

