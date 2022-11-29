namespace LoveLoli.Common.Progress
{
    using System;

    public class SimpleProgress<T> : IProgress<T>
    {
        public event EventHandler<T>? ProgressChanged;

        public void Report(T value)
        {
            ProgressChanged?.Invoke(this, value);
        }
    }
}
