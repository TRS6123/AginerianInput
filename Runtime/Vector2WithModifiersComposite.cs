using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class Vector2WithModifiersComposite : InputBindingComposite<Vector2>
    {
        [InputControl(layout = "Vector2")]
        public int axes;

        [InputControl(layout = "Axis")]
        public int axisX;

        [InputControl(layout = "Axis")]
        public int axisY;

        [InputControl(layout = "Button")]
        public int modifier;

        public override Vector2 ReadValue(ref InputBindingCompositeContext context)
        {
            Vector2 splitAxisValue = new Vector2 { x = context.ReadValue<float, HighestMagnitudeFloatComparer>(axisX), y = context.ReadValue<float, HighestMagnitudeFloatComparer>(axisY) };
            Vector2 stickValue = context.ReadValue<Vector2, Vector2MagnitudeComparer>(axes);
            Vector2MagnitudeComparer comparer = default;
            Vector2 value = comparer.Compare(splitAxisValue, stickValue) > 0 ? splitAxisValue : stickValue;
            return context.ReadValue<float, LowestMagnitudeFloatComparer>(modifier) != 0f ? value : default;
        }
    }
}
