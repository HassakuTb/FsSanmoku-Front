using FsSanmoku.Core;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class NextPlayerText : MonoBehaviour{

    public Sanmoku sanmoku;
    
    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    private void Update() {
        switch (sanmoku.NextPlayer()) {
            case Model.Player.Player1:
                text.text = "次：〇";
                break;
            case Model.Player.Player2:
                text.text = "次：×";
                break;
        }
    }
}
