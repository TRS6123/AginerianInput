using UnityEngine;
using static UnityEngine.InputSystem.InputSystem;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Aginerian.Input
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public static class CustomInputRegistration
    {
        private static bool initialized = false;

#if UNITY_EDITOR
        static CustomInputRegistration()
        {
            Register();
        }
#endif
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Register()
        {
            if (!initialized)
            {
                RegisterProcessor<NegateButtonProcessor>();
                RegisterProcessor<NormalizeScreenWidthProcessor>();
                RegisterProcessor<NormalizeScreenHeightProcessor>();
                RegisterProcessor<NormalizeScreenPositionProcessor>();
                RegisterBindingComposite<AxisWithModifiersComposite>();
                RegisterBindingComposite<Vector2WithModifiersComposite>();
                RegisterBindingComposite<Vector3WithModifiersComposite>();
                initialized = true;
            }
        }
    }
}
