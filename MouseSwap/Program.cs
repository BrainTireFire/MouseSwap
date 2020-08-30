using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using MouseSwap;

class SwapMouse
{
    static void Main(string[] args)
    {
        MouseButtonSwap mouseButtonSwap = new MouseButtonSwap();
        mouseButtonSwap.changePrimaryMouseButton();

    }
}