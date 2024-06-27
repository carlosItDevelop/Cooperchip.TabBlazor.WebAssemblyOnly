using Microsoft.AspNetCore.Components;

namespace TabBlazor
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
