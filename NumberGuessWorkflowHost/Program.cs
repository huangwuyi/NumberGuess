﻿using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using NumberGuessWorkflowActivities;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumberGuessWorkflowHost
{

    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new WorkflowHostForm());
            //AutoResetEvent syncEvent = new AutoResetEvent(false);
            //AutoResetEvent idleEvent = new AutoResetEvent(false);

            //var inputs = new Dictionary<string, object>() { { "MaxNumber", 100 } };
            //WorkflowApplication wfApp =
            //    //new WorkflowApplication(new SequentialNumberGuessWorkflow(),inputs);
            //new WorkflowApplication(new FlowchartNumberGuessWorkflow(), inputs);

            //wfApp.Completed = delegate (WorkflowApplicationCompletedEventArgs e)
            //{
            //    int Turns = Convert.ToInt32(e.Outputs["Turns"]);
            //    Console.WriteLine("Congratulations, you guessed the number in {0} turns.", Turns);
            //    Console.ReadKey(true);
            //    syncEvent.Set();
            //};

            //wfApp.Aborted = delegate (WorkflowApplicationAbortedEventArgs e)
            //{
            //    Console.WriteLine(e.Reason);
            //    syncEvent.Set();
            //};

            //wfApp.OnUnhandledException = delegate (WorkflowApplicationUnhandledExceptionEventArgs e)
            //{
            //    Console.WriteLine(e.UnhandledException.ToString());
            //    return UnhandledExceptionAction.Terminate;
            //};
            //wfApp.Idle = delegate (WorkflowApplicationIdleEventArgs e)
            //{
            //    idleEvent.Set();
            //};

            //wfApp.Run();

            ////syncEvent.WaitOne();
            //// Loop until the workflow completes.
            //WaitHandle[] handles = new WaitHandle[] { syncEvent, idleEvent };
            //while (WaitHandle.WaitAny(handles) != 0)
            //{
            //    // Gather the user input and resume the bookmark.
            //    bool validEntry = false;
            //    while (!validEntry)
            //    {
            //        int Guess;
            //        if (!Int32.TryParse(Console.ReadLine(), out Guess))
            //        {
            //            Console.WriteLine("Please enter an integer.");
            //        }
            //        else
            //        {
            //            validEntry = true;
            //            wfApp.ResumeBookmark("EnterGuess", Guess);
            //        }
            //    }
            //}
        }
    }
}
