using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class CloudLayerBloomEditorTests : VolumeComponentEditorTests<CloudLayer>
    {
        [Test]
        public virtual void CloudLayer_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void CloudLayer_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"upperHemisphereOnly","resolution","shadowResolution"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

