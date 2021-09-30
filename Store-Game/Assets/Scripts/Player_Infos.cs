using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Infos : MonoBehaviour
{
    public static int Money;
    public static GameObject Halt;
    public static GameObject Torso;
    public static GameObject[] Arms;
    public static GameObject[] legs;
    public static string PlayerName;

    public void ChangeMoney(int value)
    {
        Money += value;
    }
    public void ChangeTextUI(Text UiText)
    {
        UiText.text = Money.ToString();
    }
}
