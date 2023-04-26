using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager
{
    public class Printer
    {
        private string _tab = "";
        public string Tab { get { return _tab; } set { _tab = value; } }
        private static int TabsSpacesCount = int.TryParse(System.Configuration.ConfigurationManager.AppSettings["TabsSpacesCount"], out TabsSpacesCount) ? TabsSpacesCount : 0;
        private static string backUpPath = MainForm.myDocumentsPath + @"\" + typeof(MainForm).Namespace + $@"\{System.Configuration.ConfigurationManager.AppSettings["TempPath"]}\";
        private static Printer _base;
        public static Printer Base { get { if (_base != null) return _base; else return _base = new Printer(); } }
        private Printer()
        {
            if (!Directory.Exists(backUpPath))
                Directory.CreateDirectory(backUpPath);

            for (int i = 0; i < TabsSpacesCount - 1; i++)
                Tab += " ";
        }
        public static void PrintText(string text)
        {
            string tempFile, filetxt;
            ProcessStartInfo psi;
            Process proc;

            tempFile = Path.GetTempFileName();
            filetxt = tempFile + ".txt";
            File.Move(tempFile, filetxt);
            File.AppendAllText(filetxt, text);

            psi = new ProcessStartInfo(filetxt);
            psi.Verb = "PRINT";

            //Печать
            //proc = Process.Start(psi);
            //proc.WaitForExit();

            //Перемещаю в кастомный путь в Документах
            File.Move(filetxt, backUpPath + Path.GetFileName(tempFile));
        }
        public string getTabs(int count)
        {
            string multiplineTabs = "";
            for(int i = 0; i < count; i++)
            {
                multiplineTabs += Tab;
            }
            return multiplineTabs;
        }
    }
}
