using System;
using System.Windows.Forms;
using autoProject.formClases;


namespace autoProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //   Application.Run(new MainVindow());
           // Application.Run(new FormRegistration());
           Application.Run(new FormAddExcelData());

            using (OurBaseContext db = new OurBaseContext())
            {
                
            }





        }
    }
}
