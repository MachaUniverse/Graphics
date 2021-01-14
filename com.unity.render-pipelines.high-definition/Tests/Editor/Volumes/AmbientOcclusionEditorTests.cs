using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class AmbientOcclusionEditorTests : VolumeComponentEditorTests<AmbientOcclusion>
    {
        protected override List<string> additionalProperties => new List<string>
        {"m_BilateralUpsample"};
    }
}
