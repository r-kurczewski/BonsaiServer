﻿using System.ComponentModel.DataAnnotations;

namespace BonsaiServer.Model
{
    public class Plant
    {
        public int Id { get; set; }
        [StringLength(20)] public string Name { get; set; }
        public byte LeavesId { get; set; }
        public byte FlowersId { get; set; }
        [StringLength(3)] public string LeavesColor { get; set; }
        [StringLength(3)] public string FlowerColor { get; set; }
        [StringLength(3)] public string DirtColor { get; set; }
        [StringLength(3)] public string PotColor { get; set; }
        [StringLength(3)] public string SoilColor { get; set; }
        public Rarity.Tier Rarity { get; set; }
        public byte Slot { get; set; }
    }
}