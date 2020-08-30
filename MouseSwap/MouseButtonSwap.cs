using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MouseSwap
{
    class MouseButtonSwap
    {
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        //Primary button is Right Click
        private int primaryButton = SwapMouseButton(1);
     
        public void changePrimaryMouseButton()
        {
            if (primaryButton==1)
            {
                //Primary button is Left Click
                primaryButton = SwapMouseButton(0);

            }else if(primaryButton == 0)
            {
                //Primary button is Right Click
                primaryButton = SwapMouseButton(1);
            }
        }

    }
}
