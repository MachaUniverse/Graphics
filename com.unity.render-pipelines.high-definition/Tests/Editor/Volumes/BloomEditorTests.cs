using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class BloomEditorTests : VolumeComponentEditorTests<Bloom>
    {
        protected override List<string> additionalProperties => new List<string>
                {"anamorphic","m_Resolution","m_HighQualityPrefiltering","m_HighQualityFiltering"};
    }
}

