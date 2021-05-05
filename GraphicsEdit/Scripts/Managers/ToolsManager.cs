using PluginSystem;
using Scripts;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEdit
{
    public class ToolsManager
    {
        #region Singleton

        private static readonly Lazy<ToolsManager> instance =
            new Lazy<ToolsManager>(() => new ToolsManager());

        #endregion

        public ToolsManager()
        {
            Drawer = new Drawer();
            PluginImporter = new PluginImporter();
        }

        public static ToolsManager Instance => instance.Value;

        //Отрисовщик фигур
        public Drawer Drawer { get; set; }
        public PluginImporter PluginImporter { get; set; }

        readonly List<Plugin> LoadedPlugins = new List<Plugin>();

        public bool AddPlugin(Plugin plugin)
        {
            if (!LoadedPlugins.Contains(plugin))
            {
                LoadedPlugins.Add(plugin);
                return true;
            }
            return false;
        }
    }
}