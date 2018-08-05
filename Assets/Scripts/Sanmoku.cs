using UnityEngine;
using FsSanmoku.Core;
using Microsoft.FSharp.Collections;

public class Sanmoku : MonoBehaviour {

    private FSharpList<Model.Cell> cells;
    private Controller.GameOver over;

    private Model.Player next;

    public Model.Cell GetCell(int index) {
        return cells[index];
    }

    public Controller.GameOver GetOver() {
        return over;
    }

    public Model.Player NextPlayer() {
        return next;
    }
    
	void Start () {
        cells = Controller.initBoard;
	}

    public void Put(int index) {
        var result = Controller.putStone(cells, next, index);
        cells = result.Item1;
        next = result.Item2;

        over = Controller.judge(cells);
    }
}
