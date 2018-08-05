using FsSanmoku.Core;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ResultText : MonoBehaviour{

    public Sanmoku sanmoku;

    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    private void Update() {
        switch (sanmoku.GetOver()) {
            case Controller.GameOver.Draw:
                text.text = "引き分け";
                break;
            case Controller.GameOver.Player1:
                text.text = "〇の勝ち";
                break;
            case Controller.GameOver.Player2:
                text.text = "×の勝ち";
                break;
        }
    }

}