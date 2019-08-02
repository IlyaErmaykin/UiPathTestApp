using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IErmaykin.UiPath.Activities.FlowCustomLib.Activities
{
    /// <summary>
    /// Timer class
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Timer field
        /// </summary>
        private System.Timers.Timer timer;

        /// <summary>
        /// Result flag field
        /// </summary>
        private bool resultFlag;

        /// <summary>
        /// Set timer function
        /// </summary>
        public void SetTimer(double time, bool flag)
        {
            // Create timer
            timer = new System.Timers.Timer(time);
            resultFlag = flag;

            timer.Elapsed += OnTimerEvent;
            timer.AutoReset = false;
            timer.Enabled = true;
        }

        /// <summary>
        /// On timer event
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimerEvent(Object source, EventArgs e)
        {
            if (!resultFlag) 
                new TimeoutException("Превышено время обработки документов");
        }
    }
}
