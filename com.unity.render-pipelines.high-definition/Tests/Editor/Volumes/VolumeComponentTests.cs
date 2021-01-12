using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor.Rendering;
using UnityEngine.Rendering.Tests;

namespace UnityEngine.Rendering.HighDefinition.Tests.Volumes
{
    public class VolumeComponentEditorTests<TComponent>
        where TComponent : VolumeComponent
    {
        protected TComponent component { get; set; }
        protected VolumeComponentEditor editor { get; set; }

        protected virtual List<string> additionalProperties => null;
        
        [SetUp]
        public void Init()
        {
            component = ScriptableObject.CreateInstance<TComponent>();
            editor = (VolumeComponentEditor)Activator.CreateInstance(typeof(VolumeComponentEditor));
            editor.Invoke("Init", component, null);
        }

        [Test]
        public void TestOverridesChanges()
        {
            CheckOverridesChanges();
        }

        [Test]
        public void TestCheckWithCurrentAdditionalProperties()
        {
            CheckWithCurrentAdditionalProperties(additionalProperties);
        }

        [TearDown]
        public void Dispose()
        {
            ScriptableObject.DestroyImmediate(component);
        }

        protected void CheckWithCurrentAdditionalProperties(List<string> additionalProperties)
        {
            Assert.True(additionalProperties != null, "additionalProperties should not be null") ;
            var fields = component
                .GetFields()
                .Where(f => f.GetCustomAttribute<AdditionalAttribute>() != null)
                .Select(f => f.Name)
                .ToList();

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{typeof(TComponent)}`");
            stringBuilder.AppendLine($"\"{string.Join("\",\"", fields)}\"");
            stringBuilder.AppendLine("vs");
            stringBuilder.AppendLine($"\"{string.Join("\",\"", additionalProperties)}\"");

            Assert.True(fields.Count == additionalProperties.Count, $"The size of the additional parameters is different: {stringBuilder}");
            Assert.True(additionalProperties.All(fields.Contains), $"The additional parameters has changed {stringBuilder}");
        }

        protected void CheckOverridesChanges()
        {
            component.SetAllOverridesTo(false);
            bool allOverridesState = (bool)editor.Invoke("AreAllOverridesTo", false);
            Assert.True(allOverridesState);

            component.SetAllOverridesTo(true);

            // Was the change correct?
            allOverridesState = (bool)editor.Invoke("AreAllOverridesTo", true);
            Assert.True(allOverridesState);

            // Enable the advance mode on the editor
            component.SetField("m_AdvancedMode", true);

            // Everything is false
            component.SetAllOverridesTo(false);

            // Disable the advance mode on the editor
            component.SetField("m_AdvancedMode", false);

            // Now just set to true the overrides of non additional properties
            editor.Invoke("SetOverridesTo", true);

            // Check that the non additional properties must be false
            allOverridesState = (bool)editor.Invoke("AreAllOverridesTo", true);
            Assert.False(allOverridesState);
        }
    }
}

