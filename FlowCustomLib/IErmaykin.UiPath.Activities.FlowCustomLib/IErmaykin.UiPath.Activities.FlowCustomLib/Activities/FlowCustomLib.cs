using System;
using System.Activities;
using System.Timers;
using IErmaykin.UiPath.Activities.FlowCustomLib.Activities;

namespace IErmaykin.UiPath.Activities.FlowCustomLib
{
    public class FlowCustomLib : CodeActivity
    {
        /// <summary>
        /// Time property
        /// </summary>
        public InArgument<double> Time { get; set; }
        
        /// <summary>
        /// Result flag property
        /// </summary>
        public InArgument<bool> ResultFlag { get; set; }

        // Возможно не пригодится..
        //public OutArgument<> { get; set; } 
        
        /// <summary>
        /// Execute function
        /// </summary>
        /// <param name="context"></param>
        protected override void Execute(CodeActivityContext context)
        {
            double inputTime = Time.Get(context);
            bool resultFlag = ResultFlag.Get(context);

            //Activities.Timer timer = new Activities.Timer();
            

            //timer.SetTimer(inputTime, resultFlag);
            //timer.Stop();
            //timer.Dispose();
        }
    }
}
