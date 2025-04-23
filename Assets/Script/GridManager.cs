using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(GridMap))]
[RequireComponent(typeof(Tilemap))]
public class GridManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Tilemap tilemap;
    GridMap grid;
    [SerializeField] TileBase tileBase;
    [SerializeField] TileBase tileBase2;
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        grid = GetComponent<GridMap>();
        grid.Init(25, 12);
        grid.Set(1, 1, true);
        UpdateTileMap();
    }

    // Update is called once per frame
    void UpdateTileMap()
    {
        for (int x = 0; x < grid.length; x++)
        {
            for (int y = 0; y < grid.height; y++)
            {
                if ((x+y)%2==0)
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), tileBase);
                }
                else
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), tileBase2);
                }
            }
        }
    }
}
