using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class DepthOfFieldEditorTests : VolumeComponentEditorTests<DepthOfField>
    {
        protected override List<string> additionalProperties => new List<string>
                {"m_HighQualityFiltering","m_Resolution","m_PhysicallyBased"};
    }
}

