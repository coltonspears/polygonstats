using Microsoft.AspNetCore.Components;
using PluginWebServer;
using PluginWebServer.Component;
using RCLComponentDemo.Areas.MyFeature.Pages;
using RCLComponentDemo.MyFeature.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCLComponentDemo.Areas.MyFeature.Data
{
    public class PokedexComponent : IDynamicComponent
    {
        public bool DisplayInMenu => true;

        public IDictionary<string, string> Parameters => new Dictionary<string, string>
    {
        {"Name","Pokedex"}
    };

        public string Name => "Pokedex";
        public string Page => "Pokebox";
        public Type Component => typeof(Component);

        public MenuItem MenuData => new MenuItem
        {
            Display = true,
            Page = Page,
            CSS = String.Empty,
            Text = "Pokebox 1",
            Icon = "oi oi-list-rich"
        };
    }

    public class PokeboxComponentBase : IDynamicComponent
    {
        public bool DisplayInMenu => true;

        public IDictionary<string, string> Parameters => new Dictionary<string, string>
    {
        {"Name","Pokebox"}
    };

        public string Name => "Pokebox";
        public string Page => "PokeboxComponent";
        public Type Component => typeof(Component);

        public MenuItem MenuData => new MenuItem
        {
            Display = true,
            Page = Page,
            CSS = String.Empty,
            Text = "Pokebox 2",
            Icon = "oi oi-list-rich"
        };
    }
}
