using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1
{
    public class Assembly1BaseClass
    {
        public int publicNum;
        private int privateNum;
        internal int internalNum;
        protected int protectedNum;
        protected internal int protectedInternalNum;

        //Properties
        public int Age { set; get; }

        void Method()
        {
            Assembly1BaseClass baseClassObj = new Assembly1BaseClass();
            baseClassObj.publicNum = 10;
            baseClassObj.privateNum = 10;
            baseClassObj.internalNum = 10;
            baseClassObj.protectedNum = 10;
            baseClassObj.protectedInternalNum = 10;
        }
    }
}
