using NUnit.Framework;
using System.Collections.Generic;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class CloudLayerBloomEditorTests : VolumeComponentEditorTests<CloudLayer>
    {
        protected override List<string> additionalProperties => new List<string>
        {"upperHemisphereOnly", "resolution", "shadowResolution"};
    }
}
