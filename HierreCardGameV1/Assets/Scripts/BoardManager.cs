using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoardManager : MonoBehaviour
{
    public GameObject cardPlaceholderPrefab, cardPrefab;
    public Transform grid;
    public GameObject[,] gridLocations;
    public GameObject[,] cards;


    void Start()
    {
        SetupGrid();
    }



    void SetupGrid()
    {
        gridLocations = new GameObject[5, 6];

        for (int i = 0; i < gridLocations.GetLength(0); i++)
        {
            for (int j = 0; j < gridLocations.GetLength(1); j++)
            {
                GameObject currObj = Instantiate(cardPlaceholderPrefab);
                gridLocations[i, j] = currObj;
                currObj.transform.SetParent(grid, false);
            }
        }
    }
}
