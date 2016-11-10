using UnityEngine;
using System.Collections;

public class playerState : MonoBehaviour {

    public static int Money;
    public int curretScenceNumber;
    public int startmoney = 300;

    public static int Lives;
    public int startLives = 20;
    public static int Rounds;
    public int scencenumber;
    void Start()
    {
        Money = startmoney;
        Lives = startLives;
        curretScenceNumber = scencenumber;
        Rounds = 0;
    }
}
