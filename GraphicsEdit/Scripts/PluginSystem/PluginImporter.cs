using SharedLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PluginSystem
{
    public class PluginImporter : IExpand
    {
        readonly string pluginsPath = Path.Combine(Application.StartupPath, "Plugins");

        public List<Plugin> Import(string path)
        {
            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginsPath);
            if (!pluginDirectory.Exists) 
                pluginDirectory.Create();
            string pluginPath = Path.Combine(pluginsPath, Path.GetFileName(path));
            if (!File.Exists(pluginPath))
            {
                File.Copy(path, pluginPath);

                List<Plugin> plugins = new List<Plugin>();
                try
                {
                    Assembly asm = Assembly.LoadFrom(path);
                    foreach (var type in asm.GetTypes())
                    {
                        if (type.BaseType == typeof(Plugin))
                        {
                            plugins.Add(asm.CreateInstance(type.FullName) as Plugin);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return plugins;
            }
            return null;
        }

        

        public List<Plugin> ImportAll()
        {
            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginsPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();
    
            var pluginFiles = Directory.GetFiles(pluginsPath, "*.dll");
            List<Plugin> plugins = new List<Plugin>();
            List<Assembly> asms = new List<Assembly>();
            foreach (var file in pluginFiles)
            {
                try
                {
                    Assembly asm = Assembly.LoadFrom(file);
                    if (!asms.Contains(asm))
                    {
                        asms.Add(asm);

                            foreach (var type in asm.GetTypes())
                            {
                                if (type.BaseType == typeof(Plugin))
                                {
                                    plugins.Add(asm.CreateInstance(type.FullName) as Plugin);
                                }
                            }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return plugins;
        }
    }
}