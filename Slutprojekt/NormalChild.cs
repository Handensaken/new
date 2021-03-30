using System;

namespace Slutprojekt
{
    public class NormalChild : Child
    {
        public override void SuperAttack()
        {
            base.SuperAttack();
        }
        public NormalChild(){
            status = "Normal";
            xpFactor = 1f;
        }
    }
}
