using System;

namespace Slutprojekt
{
    public class ProdigousChild : Child
    {
        public override void SuperAttack()
        {
            base.SuperAttack();
        }
        public ProdigousChild(){
            status = "Prodgious";
            xpFactor = 2f;
        }
    }
}
