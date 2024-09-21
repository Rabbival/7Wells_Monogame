using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

public class KeyboardScheme {
    public Dictionary<Keys, Action> eventByKey;

    public KeyboardScheme(Dictionary<Keys, Action> eventByKey) {
        this.eventByKey = eventByKey;
    }
}