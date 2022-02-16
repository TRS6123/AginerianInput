using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class NegateButtonProcessor : InputProcessor<float>
    {
        public override float Process(float value, InputControl control)
        {
            return 1f - value;
        }
    }
}
