using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class DepthOfFieldEditorTests : VolumeComponentEditorTests<DepthOfField>
    {
        [Test]
        public virtual void DepthOfField_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void DepthOfField_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"m_HighQualityFiltering","m_Resolution","m_PhysicallyBased"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

