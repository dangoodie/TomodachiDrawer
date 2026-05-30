namespace TomodachiDrawer.Core.ImageProcessing.Quantizers
{
    public record QuantizerSettings(
        string QuantizerName,
        int? ColourCount = null,
        bool? UseDithering = null
    );
}
