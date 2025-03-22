using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace WarcraftRumbleLoadoutTools
{
    public class Leader : MiniBase
    {
        public Leader(WRMini mini)
        {
            Mini = mini;
        }
        public Leader(WRMini mini, byte talent)
        {
            Mini = mini;
            TalentByte = talent;
        }
        public Leader(WRMini mini, WRMiniTalent talent)
        {
            Mini = mini;
            Talent = talent;
        }
    }
}
