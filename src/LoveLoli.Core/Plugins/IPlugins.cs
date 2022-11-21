namespace LoveLoli.Core.Plugins
{
    public interface IPlugins
    {
        public string Name { get; }
        public string Description { get; }
        public string Version { get; }
        public string Author { get; }
        public string RepoUrl { get; }
    }
}
