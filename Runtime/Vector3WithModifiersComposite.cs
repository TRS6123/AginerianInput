using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class Vector3WithModifiersComposite : InputBindingComposite<Vector3>
    {
        [InputControl(layout = "Vector3")]
        public int axes;

        [InputControl(layout = "Axis")]
        public int axisX;

        [InputControl(layout = "Axis")]
        public int axisY;

        [InputControl(layout = "Axis")]
        public int axisZ;

        [InputControl(layout = "Button")]
        public int modifier;

        public override Vector3 ReadValue(ref InputBindingCompositeContext context)
        {
            Vector3 splitAxisValue = new Vector3 {
                x = context.ReadValue<float, HighestMagnitudeFloatComparer>(axisX),
                y = context.ReadValue<float, HighestMagnitudeFloatComparer>(axisY),
                z = context.ReadValue<float, HighestMagnitudeFloatComparer>(axisZ)
            };
            Vector3 stickValue = context.ReadValue<Vector3, Vector3MagnitudeComparer>(axes);
            Vector3MagnitudeComparer comparer = default;
            Vector3 value = comparer.Compare(splitAxisValue, stickValue) > 0 ? splitAxisValue : stickValue;
            return context.ReadValue<float, LowestMagnitudeFloatComparer>(modifier) != 0f ? value : default;
        }
    }
}