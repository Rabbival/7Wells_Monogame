using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

public static class InputManager{
    public static void ListenForInputAndSendEvents() {
        ListenForKeyboardInputAndSendEvents();
    }

    private static void ListenForKeyboardInputAndSendEvents() {
        if (CurrentInputConfig.activeKeyboardScheme.HasValue) {
            KeyboardExpanded.UpdateKeyboardState();
            Dictionary<Keys, Action> keyMap = CurrentInputConfig.activeKeyboardScheme.Value.eventByKey;
            foreach (KeyValuePair<Keys, Action> keyValuePair in keyMap) {
                if (KeyboardExpanded.JustPressed(keyValuePair.Key)) {
                    keyValuePair.Value.Invoke();
                }
            }
        }
    }
}