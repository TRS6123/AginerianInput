using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class AxisWithModifiersComposite : InputBindingComposite<float>
    {
        [InputControl(layout = "Axis")]
        public int axis;

        [InputControl(layout = "Button")]
        public int modifier;

        public override float ReadValue(ref InputBindingCompositeContext context)
        {
            return context.ReadValue<float, ClosestFloatToZeroComparer>(modifier) != 0f ? context.ReadValue<float>(axis) : default;
        }
    }
}
