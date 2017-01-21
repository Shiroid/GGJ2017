using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config {

    public static int numPlayers = 8;

    public static KeyCode[] playerKeys = new KeyCode[8] {
        KeyCode.Joystick1Button0,
        KeyCode.Joystick1Button1,
        KeyCode.Joystick1Button2,
        KeyCode.Joystick1Button3,
        KeyCode.Joystick1Button4,
        KeyCode.Joystick1Button5,
        KeyCode.Joystick1Button6,
        KeyCode.Joystick1Button7 };

    public static bool savePhotos = false;
}
