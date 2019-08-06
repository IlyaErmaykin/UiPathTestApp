using System.Threading;

namespace IErmaykin.UiPath.Activities.FlowCustomLib.Activities
{
    /// <summary>
    /// Flow class
    /// </summary>
    public class Flows
    {
        /// <summary>
        /// Create flows function
        /// </summary>
        /// <param name="flowCustomLib"></param>
        /// <param name="inputTime"></param>
        /// <param name="resultFlag"></param>
        public static Thread createFlows(ParameterizedThreadStart parameterizedThreadStart, double inputTime, bool resultFlag)
        {
            var options = new object[3];
            options[0] = Thread.CurrentThread;
            options[1] = inputTime;
            options[2] = resultFlag;

            Thread parralelThread = new Thread(parameterizedThreadStart);
            parralelThread.IsBackground = true;
            parralelThread.Start(options);

            return parralelThread;
        }
    }
}
