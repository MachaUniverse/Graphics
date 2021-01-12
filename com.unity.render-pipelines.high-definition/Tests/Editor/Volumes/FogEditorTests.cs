using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class FogEditorTests : VolumeComponentEditorTests<Fog>
    {
        [Test]
        public virtual void Fog_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void Fog_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"mipFogMaxMip","mipFogNear","mipFogFar","anisotropy","sliceDistributionUniformity","m_FogControlMode","screenResolutionPercentage","volumeSliceCount","m_VolumetricFogBudget","m_ResolutionDepthRatio","directionalLightsOnly"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

