using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FrmCustomer());
            Application.Run(new FrmEmployee());

            // Don't Forget to add App.Config OR Change App.config.example to App.config and do your connection string config.
            /*
          <?xml version="1.0" encoding="utf-8"?>
          <configuration>
            ...
            ...
             
            <connectionStrings>
                     <clear />
                     <add name="mongoDBLearning" connectionString="mongodb://localhost:27017" />
                     <add name="postgreDBLearning" connectionString="Server=localhost;Port=5432;Database=CustomerDb;User Id=postgres;Password=YOURPOSTGREPASSWORD;" />    
           </connectionStrings>

            ...
            ...
         </configuration>
             
             */

        }
    }
}
