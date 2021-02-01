using UnityEngine;
using static UnityEngine.InputSystem.InputSystem;

#if UNITY_EDITOR
using UnityEditor;

namespace Aginerian.Input
{
    [InitializeOnLoad]
#endif
    public static class CustomInputRegistration
    {
#if UNITY_EDITOR
        static CustomInputRegistration()
        {
            Register();
        }
#endif

        [RuntimeInitializeOnLoadMethod]
        private static void Register()
        {
            RegisterProcessor<NegateButtonProcessor>();
            RegisterProcessor<NormalizeScreenPositionProcessor>();
            RegisterBindingComposite<AxisWithModifiersComposite>();
            RegisterBindingComposite<Vector2WithModifiersComposite>();
        }
    }
}
