using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class AdditionalType
    {
        static void AdditionalTypeMain()
        {
            //var
            int x  = 10;
            var varX = 10;
            varX = 100;
            varX = 1000;

            //dynamic
            dynamic dynamicX = 10;
            dynamicX = "Mg Mg";
            dynamicX = 200.59;
            dynamicX = 'c';
            dynamicX = true;

            dynamicX = new Student();
            dynamicX = new Point(100, 3);
        }
    }
}
