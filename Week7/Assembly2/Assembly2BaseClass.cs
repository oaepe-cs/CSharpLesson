using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aseembly1;

namespace Assembly2
{
    public class Assembly2BaseClass : Assembly1BaseClass
    {

        private void Method1()
        {
            Assembly1BaseClass baseClassObj = new Assembly1BaseClass();
            baseClassObj.publicNum = 10;
            //baseClassObj.privateNum = 10;
            //baseClassObj.internalNum = 10;
            //baseClassObj.protectedNum = 10;
            //baseClassObj.protectedInternalNum = 10;

            Assembly2BaseClass dClassObj = new Assembly2BaseClass();
            dClassObj.publicNum = 10;
            //dClassObj.privateNum = 10;
            //dClassObj.internalNum = 10;
            dClassObj.protectedNum = 10;
            dClassObj.protectedInternalNum = 10;
        }
    }
}
