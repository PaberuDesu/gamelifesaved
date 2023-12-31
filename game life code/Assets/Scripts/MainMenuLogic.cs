using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour {
    public static int data_slot_to_load;
    public static bool _isChosen2D;

    private void Awake() {
        GameStatusData.AllCells = new byte[10,10,10];
        GameStatusData.All2DCells = new byte[10,10];
        for (int x = 0; x < 10; x++) {
            for (int y = 0; y < 10; y++) {
                for (int z = 0; z < 10; z++)
                    GameStatusData.AllCells[x,y,z] = 0;
                GameStatusData.All2DCells[x,y] = 0;
            }
        }
    }

    public void Start2DGame(int SlotNumber) {
        data_slot_to_load = SlotNumber;
        _isChosen2D = true;
        SceneManager.LoadScene(1);
    }

    public void Start3DGame(int SlotNumber) {
        data_slot_to_load = SlotNumber;
        _isChosen2D = false;
        SceneManager.LoadScene(1);
    }

    public void Exit() {Application.Quit();}
}