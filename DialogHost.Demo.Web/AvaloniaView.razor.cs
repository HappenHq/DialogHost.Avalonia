namespace DialogHostDemo.Web;

/// <summary>
/// This is a workaround for https://github.com/dotnet/aspnetcore/issues/13090
/// The issue is that @using Avalonia.Web.Blazor in .razor files resolves to
/// MetaVerseChat.Avalonia.Web.Blazor instead of Avalonia.Web.Blazor and since
/// .razor files have no support for global:: the suggested workaround for now
/// is to subclass the component within a non-ambigous namespace.
/// </summary>
public class AvaloniaView : global::Avalonia.Web.Blazor.AvaloniaView
{
}