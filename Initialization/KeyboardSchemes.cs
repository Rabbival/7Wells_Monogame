using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

public static class KeyboardSchemes {

    public static Dictionary<KeyboardSchemeTag, KeyboardScheme> keyboardSchemeByTag = 
        new Dictionary<KeyboardSchemeTag, KeyboardScheme>() {
            { KeyboardSchemeTag.Menu, new KeyboardScheme(new Dictionary<Keys, Action>() {
                { Keys.Space, () => SceneManager.SetActiveScene(SceneTag.Game) }
            }) }
        };
}