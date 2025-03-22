namespace WarcraftRumbleLoadoutTools
{
    public class Troop : MiniBase
    {

        public Troop(WRMini mini)
        {
            Mini = mini;
        }
        public Troop(WRMini mini, byte talent)
        {
            Mini = mini;
            TalentByte = talent;
        }
        public Troop(WRMini mini, WRMiniTalent talent)
        {
            Mini = mini;
            Talent = talent;
        }
    }
}
