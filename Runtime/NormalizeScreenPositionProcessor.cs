using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace Aginerian.Input
{
    [Preserve]
    public class NormalizeScreenPositionProcessor : InputProcessor<Vector2>
    {
        public override Vector2 Process(Vector2 value, InputControl control)
        {
            value /= new Vector2(Screen.width, Screen.height) / 2;
            value -= Vector2.one;
            return value;
        }
    }
}
