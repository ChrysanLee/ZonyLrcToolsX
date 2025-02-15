namespace ZonyLrcTools.Common.Configuration;

public class LyricsOptions
{
    public IEnumerable<LyricsProviderOptions> Plugin { get; set; }

    public GlobalLyricsConfigOptions Config { get; set; }

    public LyricsProviderOptions GetLyricProviderOption(string name)
    {
        return Plugin.FirstOrDefault(x => x.Name == name);
    }
}