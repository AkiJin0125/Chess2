using UnityEngine;

public class GridMap : MonoBehaviour
{
    public int height;
    public int length;

    bool[,] grid;

    public void Init(int height, int length)
    {
        grid = new bool[length, height];
        this.length = length;
        this.height = height;
    }

    public void Set(int x, int y,bool to) {
        grid[x,y] = to;
    }

    public bool Get(int x, int y) {
        if (CheckPosition(x, y) == false)
        {
            Debug.LogWarning("Boundries"+x.ToString()+":"+y.ToString());
            return false;
        }
        return grid[x, y];
    }

    public bool CheckPosition(int x, int y) {
        if (x < 0 || x>=length) {
            return false;
        }
        if (y < 0 || y >= height) {
            return false;
        }
        return true;
    }
}
