using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class MotionBlurEditorTests : VolumeComponentEditorTests<MotionBlur>
    {
        [Test]
        public virtual void MotionBlur_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void MotionBlur_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"cameraMotionBlur","specialCameraClampMode","cameraVelocityClamp","cameraTranslationVelocityClamp","cameraRotationVelocityClamp","depthComparisonExtent"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

