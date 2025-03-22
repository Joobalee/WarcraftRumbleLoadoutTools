using ProtoBuf;

namespace WarcraftRumbleLoadoutTools
{
    [ProtoContract]
    public class Troop : MiniBase
    {
        [ProtoMember(1)]
        public override WRMini Mini { get; set; }
        [ProtoMember(2)]
        public override int? TalentID { get; set; }

        public Troop()
        {
                
        }
        public Troop(WRMini mini)
        {
            Mini = mini;
        }
        public Troop(WRMini mini, byte talent)
        {
            Mini = mini;
            TalentID = talent;
        }
        public Troop(WRMini mini, WRMiniTalent talent)
        {
            Mini = mini;
            Talent = talent;
        }

    }
}
