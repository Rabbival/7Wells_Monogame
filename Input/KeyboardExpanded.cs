using Microsoft.Xna.Framework.Input;

public static class KeyboardExpanded
{
    static KeyboardState currentKeyState;
    static KeyboardState previousKeyState;


    public static void UpdateKeyboardState()
    {
        previousKeyState = currentKeyState;
        currentKeyState = Keyboard.GetState();
    }

    public static bool Pressed(Keys key)
    {
        return currentKeyState.IsKeyDown(key);
    }

    public static bool JustPressed(Keys key)
    {
        return currentKeyState.IsKeyDown(key) && !previousKeyState.IsKeyDown(key);
    }

    public static bool Released(Keys key)
    {
        return currentKeyState.IsKeyUp(key);
    }

    public static bool JustReleased(Keys key)
    {
        return currentKeyState.IsKeyUp(key) && previousKeyState.IsKeyDown(key);
    }
}
