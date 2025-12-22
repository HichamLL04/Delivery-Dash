using UnityEngine;

public class GridSetup : MonoBehaviour
{
    void Start()
    {
        Grid grid = GetComponent<Grid>();
        if (grid != null)
        {
            grid.cellSize = new Vector3(1, 1, 0);
        }
    }
}