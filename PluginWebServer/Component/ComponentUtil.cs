using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace PluginWebServer.Component
{
    public static class ExtUtil
    {
        public static RenderFragment GenerateMenuItem(this MenuItem item)
        {
            RenderFragment fragment = builder =>
            {
                builder.OpenElement(3, "li");
                builder.AddAttribute(4, "class", "nav-item px-3");
                builder.OpenComponent<NavLink>(4);
                builder.AddAttribute(6, "class", "nav-link active");
                builder.AddAttribute(7, "href", $"/{item.Page}");
                builder.AddAttribute(8, "Match", NavLinkMatch.All);
                builder.AddAttribute(9, "ChildContent", (RenderFragment)((builder2) =>
                {
                    builder2.AddMarkupContent(10, $"<span class=\"{item.Icon}\" aria-hidden=\"true\"></span>");
                    builder2.AddContent(11, item.Text);
                }));
                builder.CloseComponent();
                builder.CloseElement();
            };
            return fragment;
        }
    }
    

}
