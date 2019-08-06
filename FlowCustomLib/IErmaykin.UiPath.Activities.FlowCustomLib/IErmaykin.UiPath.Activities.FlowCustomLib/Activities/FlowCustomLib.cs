using System;
using System.Activities;
using System.Threading;
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

        /// <summary>
        /// Second thread field
        /// </summary>
        public OutArgument<Thread> SecondThread { get; set; }

        /// <summary>
        /// Execute function
        /// </summary>
        /// <param name="context"></param>
        protected override void Execute(CodeActivityContext context)
        {
            double inputTime = Time.Get(context);
            bool resultFlag = ResultFlag.Get(context);

            try
            {
                var secodTread = Flows.createFlows(new ParameterizedThreadStart(this.runFunction), inputTime, resultFlag);
                SecondThread.Set(context, secodTread);
            }
            catch (Exception e) { }
            
        }

        /// <summary>
        /// Run function
        /// </summary>
        /// <param name="obj"></param>
        public void runFunction(object obj)
        {
            var objArray = (object[])obj;
            var thread = (Thread)objArray[0];
            double inputTime = (double)objArray[1];
            bool resultFlag = (bool)objArray[2];

            Thread.Sleep((int)inputTime);
            thread.Abort();

        }
    }
}
