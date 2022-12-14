namespace LoveLoli.Common.IO
{
    using System.IO;

    /// <summary>
    /// Class IODefaults.
    /// </summary>
    public static class IODefaults
    {
        /// <summary>
        /// The default copy to buffer size.
        /// </summary>
        public const int CopyToBufferSize = 81920;

        /// <summary>
        /// The default file stream buffer size.
        /// </summary>
        public const int FileStreamBufferSize = 4096;

        /// <summary>
        /// The default <see cref="StreamWriter" /> buffer size.
        /// </summary>
        public const int StreamWriterBufferSize = 1024;
    }
}
