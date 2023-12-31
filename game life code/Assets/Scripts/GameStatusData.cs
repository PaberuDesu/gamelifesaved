using UnityEngine;

public class GameStatusData {
    public static GameObject[] cellTypes = new GameObject[4];
    public static Transform CellsParent;
    public static int[] size3D = new int[] {10, 10, 10};
    public static byte[,,] AllCells;
    public static int[] size2D = new int[] {10, 10};
    public static byte[,] All2DCells;

    public static string[] CellNames = new string[] {"cell", "parasite", "mushroom", "imitator"};

    public static string WrittenSize(int dimensions) {
        if (dimensions == 2) return $"({size2D[0]}; {size2D[1]})";
        if (dimensions == 3) return $"({size3D[0]}; {size3D[1]}; {size3D[2]})";
        return "";
    }
}