using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;


namespace Xbox_Modding.Classes
{
    internal class Console_
    {
        string lastMsg;
        public void GetLastConsoleErr()
        {
            RichTextBox t = Application.OpenForms["Form1"].Controls["richTextBox1"] as RichTextBox;
            lastMsg = t.Text;
            Directory.CreateDirectory(Application.StartupPath + "\\logs");
            File.WriteAllText(Application.StartupPath + "\\logs\\log.txt", lastMsg);
        }
        
        public void SendConsoleMessage()
        {
        }
        
    }
}
