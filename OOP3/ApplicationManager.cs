using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void DoApplication(ICreditManager creditManager, ILoggerService loggerService) 
        {
            //Applicant information

            creditManager.Calculate();
            loggerService.Log();
        }

        public void DoCreditPreNotification(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
