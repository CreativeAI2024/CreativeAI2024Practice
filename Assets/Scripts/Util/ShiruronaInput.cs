using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Util
{
    public static class ShiruronaInput
    {
        public static bool GetKey(Key key)
        {
            Keyboard keyboard = Keyboard.current;
            KeyControl keyControl = keyboard[key];
            return keyControl.isPressed;
        }
    
        public static bool GetKeyDown(Key key)
        {
            Keyboard keyboard = Keyboard.current;
            KeyControl keyControl = keyboard[key];
            return keyControl.wasPressedThisFrame;
        }
    
        public static bool GetKeyUp(Key key)
        {
            Keyboard keyboard = Keyboard.current;
            KeyControl keyControl = keyboard[key];
            return keyControl.wasReleasedThisFrame;
        }
    }
}