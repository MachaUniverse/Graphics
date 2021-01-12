using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class HDRISkyEditorTests : VolumeComponentEditorTests<HDRISky>
    {
        [Test]
        public virtual void HDRISky_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void HDRISky_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"enableBackplate","backplateType","groundLevel","scale","projectionDistance","plateRotation","plateTexRotation","plateTexOffset","blendAmount","shadowTint","pointLightShadow","dirLightShadow","rectLightShadow"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

