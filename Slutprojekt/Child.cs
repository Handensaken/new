using System;

namespace Slutprojekt
{
    public class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float xpFactor {get; protected set;} 
        public string status;

        public void NormalAttack(){

        }
        public virtual void SuperAttack(){
            
        }

    }
}
