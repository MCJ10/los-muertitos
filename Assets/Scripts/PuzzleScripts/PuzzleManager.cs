using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int PointsToWin;
    private int CurrentPoints;
    private bool SceneWasLoaded;
    public GameObject myPuzzlePieces;

    void Start()
    {
        PointsToWin = myPuzzlePieces.transform.childCount;
        SceneWasLoaded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentPoints >= PointsToWin && !SceneWasLoaded)
        {
            SceneWasLoaded = true;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
        }
        
    }

    public void AddPoint()
    {
        CurrentPoints++;
    }

    public void GoBackToMainGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }
}
