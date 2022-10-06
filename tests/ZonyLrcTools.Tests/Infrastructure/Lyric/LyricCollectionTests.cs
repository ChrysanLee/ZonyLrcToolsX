﻿using Shouldly;
using Xunit;
using ZonyLrcTools.Cli.Infrastructure.Lyric;
using ZonyLrcTools.Common.Configuration;
using ZonyLrcTools.Common.Lyrics;

namespace ZonyLrcTools.Tests.Infrastructure.Lyric
{
    public class LyricCollectionTests : TestBase
    {
        [Fact]
        public void LyricCollectionLineBreak_Test()
        {
            var lyricObject = new LyricItemCollection(new GlobalLyricsConfigOptions
            {
                IsOneLine = false,
                LineBreak = LineBreakType.MacOs
            })
            {
                new(0, 20, "你好世界!"),
                new(0, 22, "Hello World!")
            };

            lyricObject.ToString().ShouldContain(LineBreakType.MacOs);
        }
    }
}