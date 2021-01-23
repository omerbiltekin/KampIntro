using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();  
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(new ArtisanCredit(), new SmsLoggerService()) ;

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager , vehicleCreditManager};

            //applicationManager.DoCreditPreNotification(credits);
        }
    }
}
