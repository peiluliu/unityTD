using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetMoney : MonoBehaviour {

    public Text moneyText;
    public Text livesText;
    // Update is called once per frame
    void Update () {
        moneyText.text = "$" + playerState.Money.ToString();
        //livesText.text = playerState.Lives.ToString() + " LIVES";
       livesText.text = "abc" + " LIVES";
    }
}
