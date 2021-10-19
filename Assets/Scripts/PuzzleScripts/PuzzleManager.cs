using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int PointsToWin;
    private int CurrentPoints;
    public GameObject myPuzzlePieces;

    void Start()
    {
        PointsToWin = myPuzzlePieces.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentPoints >= PointsToWin)
        {
            //Tell Scene Manager that it won
        }
        
    }

    public void AddPoint()
    {
        CurrentPoints++;
    }
}
