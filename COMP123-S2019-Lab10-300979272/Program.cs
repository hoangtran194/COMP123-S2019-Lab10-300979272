using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300979272
{
    static class Program
    {
        public static Dictionary<string, Form> forms = new Dictionary<string, Form>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            forms.Add(Define.StartForm.ToString(), new StartForm());
            forms.Add(Define.MainForm.ToString(), new MainForm());
            forms.Add(Define.EndForm.ToString(), new EndForm());

            Application.Run(forms[Define.StartForm.ToString()]);
        }
    }
}
