using System.Text.Json.Serialization;
using TomodachiDrawer.Core.Models;

namespace TomodachiDrawer.UI.Avalonia;

internal class AppSettings
{
    public SwitchVersion SelectedSwitchVersion { get; set; } = SwitchVersion.None;

    public int SelectedThemeIndex { get; set; } = 0;

    public bool EnableExperimentalFeatures { get; set; } = false;

    public bool CheckForUpdatesOnStart { get; set; } = true;

    public int FirstStartId { get; set; } = 0;

    // Experimental colour-picker strategies for diagnosing the residual greenish
    // drift in long arbitrary-colour drawings. Each can be toggled independently
    // so we can A/B test the underlying hypotheses against a known-good image.
    // Default off - the existing 5.0 behaviour is what shipped.
    public bool ExpPreserveHueOnReopen { get; set; } = false;
    public int ExpReanchorEveryNPicks { get; set; } = 0; // 0 disables
    public bool ExpUseSimplifiedGamma { get; set; } = false;
}

// Source gen serialization to avoid trimming warnings.
[JsonSerializable(typeof(AppSettings))]
[JsonSourceGenerationOptions(WriteIndented = true)]
internal partial class AppSettingsContext : JsonSerializerContext { }
