using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class FogEditorTests : VolumeComponentEditorTests<Fog>
    {
        protected override List<string> additionalProperties => new List<string>
            {"mipFogMaxMip","mipFogNear","mipFogFar","anisotropy","sliceDistributionUniformity","m_FogControlMode","screenResolutionPercentage","volumeSliceCount","m_VolumetricFogBudget","m_ResolutionDepthRatio","directionalLightsOnly"};
    }
}

