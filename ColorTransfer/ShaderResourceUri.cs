namespace ColorTransfer;

internal static class ShaderResourceUri
{
    public static Uri Get(string shaderName) => new($"pack://application:,,,/ColorTransfer;component/Resources/Shader/{shaderName}.cso", UriKind.Absolute);
}
