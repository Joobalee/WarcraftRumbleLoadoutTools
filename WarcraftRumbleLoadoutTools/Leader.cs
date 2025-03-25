using ProtoBuf;

namespace WarcraftRumbleLoadoutTools
{
    [ProtoContract]
    public class Leader : MiniBase
    {
        [ProtoMember(2)]
        public override int? TalentID { get; set; }
        [ProtoMember(1)]
        public override WRMini Mini { get; set; }

        public Leader(WRMini mini)
        {
            Mini = mini;
        }
        public Leader(WRMini mini, int talent)
        {
            Mini = mini;
            TalentID = talent;
        }
        public Leader(WRMini mini, WRMiniTalent talent)
        {
            Mini = mini;
            Talent = talent;
        }
        public Leader()
        {
                
        }
    }
}
