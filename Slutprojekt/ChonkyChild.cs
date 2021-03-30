using System;

namespace Slutprojekt
{
    public class ChonkyChild : Child
    {
        public override void SuperAttack()
        {
            base.SuperAttack();
        }
        public ChonkyChild(){
            status = "Chonky";
            xpFactor = 0.5f;
        }
    }
}
