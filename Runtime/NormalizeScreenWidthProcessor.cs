using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class NormalizeScreenWidthProcessor : InputProcessor<float>
    {
        public override float Process(float value, InputControl control)
        {
            value /= Screen.width / 2;
            value -= 1f;
            return value;
        }
    }
}
