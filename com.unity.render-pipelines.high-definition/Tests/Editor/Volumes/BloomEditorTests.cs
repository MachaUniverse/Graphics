using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Rendering.Tests.Volumes;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class BloomEditorTests : VolumeComponentEditorTests<Bloom>
    {
        [Test]
        public virtual void Bloom_TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public virtual void Bloom_AdditionalProperties()
        {
            var additionalProperties = new List<string>
                {"anamorphic","m_Resolution","m_HighQualityPrefiltering","m_HighQualityFiltering"};

            CheckWithCurrentAdditionalProperties(additionalProperties);
        }
    }
}

