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

        [InputControl(layout = "Button")]
        public int modifier;

        public override Vector2 ReadValue(ref InputBindingCompositeContext context)
        {
            return context.ReadValue<float, LowestMagnitudeFloatComparer>(modifier) != 0f ? context.ReadValue<Vector2, Vector2MagnitudeComparer>(axes) : default;
        }
    }
}
