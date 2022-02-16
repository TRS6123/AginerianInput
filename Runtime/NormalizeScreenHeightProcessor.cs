using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class NormalizeScreenHeightProcessor : InputProcessor<float>
    {
        public override float Process(float value, InputControl control)
        {
            value /= Screen.height / 2;
            value -= 1f;
            return value;
        }
    }
}
