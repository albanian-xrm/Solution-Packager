using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using XrmToolBox.Extensibility;

namespace AlbanianXrm.SolutionPackager
{
    internal class AsyncWorkQueue
    {
        private readonly Queue<Job> queue;
        private readonly PluginViewModel pluginViewModel;
        private readonly SolutionPackagerControl solutionPackagerControl;

        public AsyncWorkQueue(SolutionPackagerControl solutionPackagerControl, PluginViewModel pluginViewModel)
        {
            this.queue = new Queue<Job>();
            this.solutionPackagerControl = solutionPackagerControl;
            this.pluginViewModel = pluginViewModel;
        }

        public void Enqueue(WorkAsyncInfo work)
        {
            var job = new Job(this, work);
            if (!queue.Any())
            {
                pluginViewModel.AllowRequests = false;
                solutionPackagerControl.WorkAsync(job.Work);
            }
            queue.Enqueue(job);
        }

        private void WorkAsyncEnded()
        {
            queue.Dequeue();
            if (queue.Any())
            {
                solutionPackagerControl.WorkAsync(queue.Peek().Work);
            }
            else
            {
                pluginViewModel.AllowRequests = true;
            }
        }

        private class Job
        {
            public WorkAsyncInfo Work { get; private set; }
            private readonly Action<RunWorkerCompletedEventArgs> postWorkCallBack;
            private readonly AsyncWorkQueue queue;

            public Job(AsyncWorkQueue queue, WorkAsyncInfo work)
            {
                this.queue = queue ?? throw new ArgumentNullException(nameof(queue));
                this.Work = work ?? throw new ArgumentNullException(nameof(work));
                this.postWorkCallBack = work.PostWorkCallBack;
                this.Work.PostWorkCallBack = PostWorkCallBack;
            }

            private void PostWorkCallBack(RunWorkerCompletedEventArgs args)
            {
                try
                {
                    postWorkCallBack?.Invoke(args);
                }
                finally
                {
                    this.queue.WorkAsyncEnded();
                }
            }
        }
    }
}
