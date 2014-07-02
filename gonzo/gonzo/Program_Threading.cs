using System;
using System.Threading;
using System.Threading.Tasks;

namespace gonzo
{
    partial class Program
    {
        private static void ThreadingDemo()
        {
            var cts = new CancellationTokenSource();
            var task = Task.Run(() => Callback(cts.Token), cts.Token);
            try
            {
                while (true)
                {
                    var result = Console.ReadLine();
                    if (string.IsNullOrEmpty(result))
                    {
                        cts.Cancel();
                    }
                    else
                    {
                        if (result == "exit") return;
                    }
                }
            }
            catch (AggregateException exception)
            {
                exception.Handle(e => e is OperationCanceledException);
            }
        }

        private static void Callback(CancellationToken ct)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.Second);
                Thread.Sleep(1000);
                ct.ThrowIfCancellationRequested();
            }
        }
    }
}
