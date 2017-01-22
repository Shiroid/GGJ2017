using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config {

    public static int numPlayers = 8;

    public static KeyCode[] playerKeys = new KeyCode[8] {
        KeyCode.A,
        KeyCode.S,
        KeyCode.D,
        KeyCode.F,
        KeyCode.J,
        KeyCode.K,
        KeyCode.L,
        KeyCode.Semicolon };

    public static bool savePhotos = false;

    public static float victoryCameraScale = 1.3f;
}
