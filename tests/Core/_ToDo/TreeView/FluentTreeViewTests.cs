using Bunit;
using Xunit;

namespace Microsoft.Fast.Components.FluentUI.Tests.TreeView;
public class FluentTreeViewTests : TestBase
{
    [Fact]
    public void FluentTreeView_Default()
    {
        //Arrange
        string childContent = "<b>render me</b>";
        bool renderCollapsedNodes = default!;
        FluentTreeItem currentSelected = default!;
        Action<FluentTreeItem?> currentSelectedChanged = _ => { };
        Action<FluentTreeItem> onSelectedChange = _ => { };
        Action<FluentTreeItem> onExpandedChange = _ => { };
        var cut = TestContext.RenderComponent<FluentTreeView>(parameters => parameters
            .Add(p => p.RenderCollapsedNodes, renderCollapsedNodes)
            .Add(p => p.CurrentSelected, currentSelected)
            .Add(p => p.CurrentSelectedChanged, currentSelectedChanged)
            .AddChildContent(childContent)
            .Add(p => p.OnSelectedChange, onSelectedChange)
            .Add(p => p.OnExpandedChange, onExpandedChange)
        );
        //Act

        //Assert
        cut.Verify();
    }
}






