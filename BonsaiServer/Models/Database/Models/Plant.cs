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
        #region database model
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [Display(Name = "UserId")]
        public User User { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public byte LeavesId { get; set; }
        public byte FlowersId { get; set; }

        [StringLength(3)]
        [Column("StalkColor")]
        [Display(Name = "StalkColor")]
        public string StalkColorString { get; set; }

        [StringLength(3)]
        [Column("LeavesColor")]
        [Display(Name = "LeavesColor")]
        public string LeavesColorString { get; set; }

        [StringLength(3)]
        [Column("FlowersColor")]
        [Display(Name = "FlowersColor")]
        public string FlowersColorString { get; set; }

        [StringLength(3)]
        [Column("PotColor")]
        [Display(Name = "PotColor")]
        public string PotColorString { get; set; }

        [StringLength(3)]
        [Column("SoilColor")]
        [Display(Name = "SoilColor")]
        public string SoilColorString { get; set; }

        public Rarity.Tier Rarity { get; set; }
        public byte Slot { get; set; }
        #endregion

        #region properties
        [NotMapped]
        public Color StalkColor
        {
            get { return BColor.FromString(StalkColorString); }
            set { StalkColorString = BColor.ToString(value); }
        }

        [NotMapped]
        public Color LeavesColor
        {
            get { return BColor.FromString(LeavesColorString); }
            set { LeavesColorString = BColor.ToString(value); }
        }

        [NotMapped]
        public Color FlowersColor
        {
            get { return BColor.FromString(FlowersColorString); }
            set { FlowersColorString = BColor.ToString(value); }
        }

        [NotMapped]
        public Color PotColor
        {
            get { return BColor.FromString(PotColorString); }
            set { PotColorString = BColor.ToString(value); }
        }

        [NotMapped]
        public Color SoilColor
        {
            get { return BColor.FromString(SoilColorString); }
            set { SoilColorString = BColor.ToString(value); }
        }
        #endregion

        static Random rand = new Random();

        public static Plant RandomPlant(User user = null)
        {
            return new Plant()
            {
                User = user,
                Name = MutationScript.GenerateName(),
                FlowersId = 1,
                LeavesId = 1,
                StalkColor = BColor.RandomColor(),
                LeavesColor = BColor.RandomColor(),
                FlowersColor = BColor.RandomColor(),
                SoilColor = BColor.RandomColor(),
                PotColor = BColor.RandomColor(),
                Rarity = (Rarity.Tier)rand.Next(0, Enum.GetNames(typeof(Rarity.Tier)).Length),
                Slot = 0,
            };
        }
    }
}
