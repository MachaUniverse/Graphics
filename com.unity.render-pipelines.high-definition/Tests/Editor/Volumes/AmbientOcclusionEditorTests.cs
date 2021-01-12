using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class AmbientOcclusionEditorTests : VolumeComponentEditorTests<AmbientOcclusion>
    {
        [Test]
        public virtual void AmbientOcclusion_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void AmbientOcclusion_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"m_BilateralUpsample"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

