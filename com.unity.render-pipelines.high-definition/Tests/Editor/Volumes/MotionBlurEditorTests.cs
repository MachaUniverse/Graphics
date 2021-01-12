using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class MotionBlurEditorTests : VolumeComponentEditorTests<MotionBlur>
    {
        protected override List<string> additionalProperties => new List<string>
                {"cameraMotionBlur","specialCameraClampMode","cameraVelocityClamp","cameraTranslationVelocityClamp","cameraRotationVelocityClamp","depthComparisonExtent"};
    }
}

