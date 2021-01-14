using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class HDRISkyEditorTests : VolumeComponentEditorTests<HDRISky>
    {
        protected override List<string> additionalProperties => new List<string>
        {"enableBackplate", "backplateType", "groundLevel", "scale", "projectionDistance", "plateRotation", "plateTexRotation", "plateTexOffset", "blendAmount", "shadowTint", "pointLightShadow", "dirLightShadow", "rectLightShadow"};
    }
}
