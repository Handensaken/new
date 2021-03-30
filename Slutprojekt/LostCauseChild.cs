using System;

namespace Slutprojekt
{
    public class LostCauseChild : Child
    {
        public override void SuperAttack()
        {
            base.SuperAttack();
        }
        public LostCauseChild(){
            status = "Lost cause";
            xpFactor = 0.5f;
        }
    }
}
