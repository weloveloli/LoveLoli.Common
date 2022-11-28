namespace LoveLoli.Common.Serialization
{
    using System;
    using System.IO;

    public interface IXmlSerializer
    {
        /// <summary>
        /// Serializes to stream.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="stream">The stream.</param>
        void SerializeToStream(object obj, Stream stream);

        /// <summary>
        /// Serializes to file.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="file">The file.</param>
        void SerializeToFile(object obj, string file);

        /// <summary>
        /// Deserializes from stream.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromStream(Type type, Stream stream);

        /// <summary>
        /// Deserializes from stream.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="stream">The stream.</param>
        /// <returns>System.Object.</returns>
        T DeserializeFromStream<T>(Stream stream) => (T)DeserializeFromStream(typeof(T), stream);

        /// <summary>
        /// Deserializes from file.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="file">The file.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromFile(Type type, string file);

        /// <summary>
        /// Deserializes from file.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="file">The file.</param>
        /// <returns>System.Object.</returns>
        T DeserializeFromFile<T>(string file) => (T)DeserializeFromFile(typeof(T), file);

        /// <summary>
        /// Deserializes from bytes.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="buffer">The buffer.</param>
        /// <returns>System.Object.</returns>
        object DeserializeFromBytes(Type type, byte[] buffer);

        /// <summary>
        /// Deserializes from bytes.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <returns>T.</returns>
        T DeserializeFromBytes<T>(byte[] buffer) => (T)DeserializeFromBytes(typeof(T), buffer);
    }
}
