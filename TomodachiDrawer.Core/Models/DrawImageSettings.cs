using TomodachiDrawer.Core.ImageProcessing.Quantizers;

namespace TomodachiDrawer.Core.Models
{
    public class DrawImageSettings
    {
        public required QuantizerSettings QuantizerSettings { get; set; }

        public string? DenoiserName { get; set; } = null;

        public float TSPTimeLimit { get; set; } = 1.0f;

        /// <summary>Disables "stamp" detection, which is areas that could be drawn with 3x3, 5x5, 9x9, etc brushes to save time.</summary>
        public bool DisableLargeBrush { get; set; } = false;

        /// <summary>Enables stuff that may be prone to desyncs or other instabilities.</summary>
        public bool EnableExperimentalFeatures { get; set; } = false;

        public bool HomeToTopLeft { get; set; } = false;

        // Experimental colour-picker strategies. Each can be toggled independently
        // to diagnose residual drift on long arbitrary-colour drawings.
        //   ExpPreserveHueOnReopen: skip the hue side of the round-trip prediction.
        //     Tests whether the game preserves the last hue intent across reopen
        //     even when sat/val collapse for blacks/greys.
        //   ExpReanchorEveryNPicks (0 disables): force a fresh slam-home every N
        //     arbitrary picks. Bounds any cumulative drift to N picks worth.
        //   ExpUseSimplifiedGamma: use the simple gamma=2.2 power curve instead of
        //     the piecewise sRGB curve. Tests whether the game uses the simpler
        //     conversion.
        public bool ExpPreserveHueOnReopen { get; set; } = false;
        public int ExpReanchorEveryNPicks { get; set; } = 0;
        public bool ExpUseSimplifiedGamma { get; set; } = false;
    }
}
