using UnityEngine.InputSystem;

namespace Aginerian.Input
{
    public interface IInput<T> where T : struct
    {
        void SetInput(InputAction.CallbackContext ctx, int index);
    }
}
