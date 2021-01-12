using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class ExposureEditorTests : VolumeComponentEditorTests<Exposure>
    {
        [Test]
        public virtual void Exposure_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void Exposure_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"targetMidGray","maskMinIntensity","maskMaxIntensity"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

