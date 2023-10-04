using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1
{
    public class Assembly1DeriveClass : Assembly1BaseClass
    {
        private void Method1()
        {
            Assembly1BaseClass baseClassObj = new Assembly1BaseClass();
            //baseClassObj.Age = 10;
            Console.WriteLine(baseClassObj.Age);
            baseClassObj.publicNum = 10;
            //baseClassObj.privateNum = 10;
            baseClassObj.internalNum = 10;
            //baseClassObj.protectedNum = 10;
            baseClassObj.protectedInternalNum = 10;

            Assembly1DeriveClass dClassObj = new Assembly1DeriveClass();
            dClassObj.publicNum = 10;
            //dClassObj.privateNum = 10;
            dClassObj.internalNum = 10;
            dClassObj.protectedNum = 10;
            baseClassObj.protectedInternalNum = 10;
        }
    }
}

//public int publicNum;
//private int privateNum;
//internal int internalNum;
//protected int protectedNum;
//protected internal int protectedInternalNum;