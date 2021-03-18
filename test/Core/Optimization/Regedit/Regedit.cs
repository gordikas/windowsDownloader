using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using Microsoft.Win32;

namespace test.Core.Optimization.Regedit
{
    class Regedit
    {
        private static void RestartExplorer()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c taskkill /f /im explorer.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            System.Threading.Thread.Sleep(500);
            Process.Start(Environment.SystemDirectory + "\\..\\explorer.exe");
        }
        private static void EditKey(RegistryKey key,string name,int value)
        {
            RegistryKey regkey = key;
            key.SetValue(name, value);
        }
        private static void EditKey(RegistryKey key, string name, string value)
        {
            RegistryKey regkey = key;
            key.SetValue(name, value);
        }
        public static void AllRegedit()
        {
            EditKey(Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "ShowSecondsInSystemClock", 1);
            EditKey(Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "TaskbarGlomLevel", 2);
            EditKey(Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Windows\Explorer"), "DisableNotificationCenter", 1);
            EditKey(Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\PushNotifications"), "ToastEnabled", 0);
            EditKey(Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer"), "AlwaysUnloadDll",1);
            EditKey(Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer"), "EnableAutoTray", 1);
            EditKey(Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "ShowTaskViewButton", 0);


            RestartExplorer();
        }
      
    }
}
