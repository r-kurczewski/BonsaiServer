using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using BonsaiServer.Models;

namespace BonsaiServer.Database
{
    [Serializable]
    public class Plant
    {
        public int Id { get; set; }
        [ForeignKey("UserId")] public User User { get; set; }
        [StringLength(20)] public string Name { get; set; }
        public byte LeavesId { get; set; }
        public byte FlowersId { get; set; }
        [StringLength(3)] public string LeavesColorString { get; set; }
        [StringLength(3)] public string FlowerColorString { get; set; }
        [StringLength(3)] public string DirtColorString { get; set; }
        [StringLength(3)] public string PotColorString { get; set; }
        [StringLength(3)] public string SoilColorString { get; set; }
        public Rarity.Tier Rarity { get; set; }
        public byte Slot { get; set; }

        [NotMapped]
        public Color LeavesColor
        {
            get { return BColor.FromString(LeavesColorString); }
            set { LeavesColorString = BColor.ToString(value); }
        }
    }
}
