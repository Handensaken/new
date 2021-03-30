using System;

namespace Slutprojekt
{
    public class IntelligentChild : Child
    {
        
        public override void SuperAttack()
        {
            base.SuperAttack();
        }
        public IntelligentChild(){
            status = "Intelligent";
            xpFactor = 2f;
        }
    }
}
