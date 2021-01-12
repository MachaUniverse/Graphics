using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class ExposureEditorTests : VolumeComponentEditorTests<Exposure>
    {
        protected override List<string> additionalProperties => new List<string>
                {"targetMidGray","maskMinIntensity","maskMaxIntensity"};
    }
}

