using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace PluginWebServer.Component
{
    public interface IPluginComponentService
    {
        void LoadComponents(string path);
        IDynamicComponent GetComponentByName(string name);
        IDynamicComponent GetComponentByPage(string name);
        IEnumerable<Type> Components { get; }
        IEnumerable<MenuItem> GetMenuItems(bool getHiddenItems = false);
    }
    public interface IDynamicComponent
    {
        IDictionary<string, string> Parameters { get; }
        string Name { get; }
        string Page { get; }
        Type Component { get; }
        MenuItem MenuData { get; }
    }
    public class MenuItem
    {
        public bool Display { get; set; }
        public string Text { get; set; }
        public string Page { get; set; }
        public string Icon { get; set; }
        public string CSS { get; set; }

    }

    public class PluginComponentService : IPluginComponentService
    {
        public IEnumerable<Type> Components { get; private set; }

        public void LoadComponents(string path)
        {
            var components = new List<Type>();
            var assemblies = LoadAssemblies(path);

            foreach (var asm in assemblies)
            {
                var types = GetTypesWithInterface(asm);
                foreach (var typ in types) components.Add(typ);
            }

            Components = components;
        }

        public IEnumerable<MenuItem> GetMenuItems(bool getHiddenItems = false)
        {
            var components = Components.Select(x => (IDynamicComponent)Activator.CreateInstance(x));
            if (!getHiddenItems)
                components = components.Where(x => x.MenuData.Display);

            return components.Select(x => x.MenuData);
        }


        public IDynamicComponent GetComponentByName(string name)
        {
            return Components.Select(x => (IDynamicComponent)Activator.CreateInstance(x))
                .SingleOrDefault(x => x.Name == name);
        }

        public IDynamicComponent GetComponentByPage(string name)
        {
            return Components.Select(x => (IDynamicComponent)Activator.CreateInstance(x))
                .SingleOrDefault(x => x.Page == name);
        }

        private IEnumerable<Assembly> LoadAssemblies(string path)
        {
            return Directory.GetFiles(path, "*.dll").Select(dll => Assembly.LoadFile(dll)).ToList();
        }

        private IEnumerable<Type> GetTypesWithInterface(Assembly asm)
        {
            var it = typeof(IDynamicComponent);
            return GetLoadableTypes(asm).Where(it.IsAssignableFrom).ToList();
        }

        private IEnumerable<Type> GetLoadableTypes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}