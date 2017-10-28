using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int seeds = 0;
    public GameObject seedCount;
    public Transform sapling;
    private Vector2 gridSize = new Vector2(12, 30);
    private Grid grid;
    public void AddSeed(int i = 1)
    {
        seeds += i;
        updateSeeds();
    }
    // Use this for initialization
	void Start () {
        grid = new Grid(Mathf.RoundToInt(gridSize.x), Mathf.RoundToInt(gridSize.y));
    }
	


	// Update is called once per frame
	void Update () {
	}

    void updateSeeds()
    {
        seedCount.GetComponent<Text>().text = seeds.ToString("G");
    }

    public void PlantTree()
    {
        // instantiate tree somewhere
        // Find free slot in grid
        int tries = 50;
        int randX = 0;
        int randY = 0;
        while (tries > 0)
        { 
            randX = Random.Range(1, Mathf.RoundToInt(gridSize.x));
            randY = Random.Range(1, Mathf.RoundToInt(gridSize.y));

            if(grid.accessCoordinate(randX, randY) == 0)
            {
                break;
            }

        }

        // occupy grid spot
        grid.assignValue(randX, randY, 1);
        // create tree
        float xOffset = 6;
        float yOffset = 6;
        Transform newTree = Instantiate(sapling, new Vector2(randX - xOffset, randY - yOffset), Quaternion.identity);
        newTree.parent = GameObject.Find("Forest").transform;

        // parent tree

        // add tree to tree tracker
    }

    class Grid
    {
        List<Coordinate> coordinates;

        public Grid(int width, int length)
        {
            coordinates = new List<Coordinate>();
            for (int i = 1; i < width + 1; i++)
            {
                for (int k = 1; k < length + 1; k++)
                {
                    coordinates.Add(new Coordinate(i, k));
                }
            }

        }
        int width { get; set; }
        int length { get; set; }
        public int accessCoordinate(int x, int y)
        {
            return coordinates.Where(coord => coord.x == x && coord.y == y)
                              .FirstOrDefault().storedValue;
        }
        public void assignValue(int x, int y, int value)
        {
            coordinates.Where(coord => coord.x == x && coord.y == y)
                       .FirstOrDefault().storedValue = value;
        }
    }
    class Coordinate
    {
        public Coordinate(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int x { get; set; }
        public int y { get; set; }
        public int storedValue { get; set; }
    }
}
