using Inventory_Management_System.Models;

namespace Inventory_Management_System
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            

    }
}
}