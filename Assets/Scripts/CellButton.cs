using FsSanmoku.Core;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CellButton : MonoBehaviour{

    public Sanmoku sanmoku;
    public int index;

    private Button button;

    private void Awake() {
        button = GetComponent<Button>();
    }

    private void Start() {
        button.onClick.AddListener(OnClick);
    }

    private void OnClick() {
        sanmoku.Put(index);
    }

    private void Update() {
        Model.Cell cell = sanmoku.GetCell(index);
        if (!cell.hasStone) {
            button.GetComponentInChildren<Text>().text = "";
            button.interactable = true;
        }
        else if(cell.stone == Model.Player.Player1) {
            button.GetComponentInChildren<Text>().text = "〇";
            button.interactable = false;
        }
        else {
            button.GetComponentInChildren<Text>().text = "×";
            button.interactable = false;
        }
    }
}
