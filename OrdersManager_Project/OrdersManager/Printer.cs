using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        private static System.Drawing.Printing.PrintDocument pd;
        private static StreamReader streamToPrint;
        public static void PrintText(string text)
        {
            string tempFile, filetxt;
            tempFile = Path.GetTempFileName();
            filetxt = tempFile + ".txt";
            File.Move(tempFile, filetxt);
            File.AppendAllText(filetxt, text);

            streamToPrint = new StreamReader (filetxt);

            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;

            pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                   (pd_PrintPage);

            PrintDialog1.Document = pd;
            DialogResult result = PrintDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pd.Print();
                streamToPrint.Close();
                //Перемещаю в кастомный путь в Документах
                File.Move(filetxt, backUpPath + Path.GetFileName(tempFile));
            }
        }
        private static void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            Font printFont = new Font("Arial", 10);

            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Расчет требуемых страниц
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Добавление строк из файла
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
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
