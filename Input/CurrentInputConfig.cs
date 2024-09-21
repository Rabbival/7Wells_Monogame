public static class CurrentInputConfig{
    public static Option<KeyboardScheme> activeKeyboardScheme = Option.None;

    public static void SetActiveKeyboardSchemeIfAssigned(SceneTag sceneTag){
        Option<KeyboardSchemeTag> tag = SceneTagToKeyboardSchemeTag(sceneTag);
        if (tag.HasValue){
            activeKeyboardScheme = KeyboardSchemes.keyboardSchemeByTag[tag.Value];
        } else {
            activeKeyboardScheme = Option.None;
        }
    }

    public static Option<KeyboardSchemeTag> SceneTagToKeyboardSchemeTag(SceneTag sceneTag){
        switch (sceneTag){
            case SceneTag.TitleScreen:
                return Option.Some(KeyboardSchemeTag.Menu);
            default:
                return Option.None;
        }
    }
}