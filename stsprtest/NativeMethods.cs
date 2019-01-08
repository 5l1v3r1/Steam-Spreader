﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stsprtest
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr whandle);

        [DllImport("user32.dll")]
        public static extern bool EnumWindows(EnumThreadWindowsCallback callback, IntPtr extraData);

        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, EnumThreadWindowsCallback callback, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadWindowsCallback lpfn, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hwnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("User32.dll")]
        public static extern int GetWindowText(IntPtr hwnd, StringBuilder lpString, int nMaxCount);

        public delegate bool EnumThreadWindowsCallback(IntPtr hWnd, IntPtr lParam);
    }
}
