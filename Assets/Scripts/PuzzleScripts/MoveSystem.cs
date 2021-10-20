using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject correctPositionedObject;
    private bool bIsMoving;
    private bool bIsPieceInRightPosition;

    private float StartPositionInX;
    private float StartPositionInY;

    private Vector3 ResetPosition;

    void Start()
    {
        ResetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(bIsMoving && !bIsPieceInRightPosition)
        {
            Vector3 MousePosition;
            MousePosition = Input.mousePosition;
            MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);

            this.gameObject.transform.localPosition = new Vector3(MousePosition.x - StartPositionInX, MousePosition.y - StartPositionInY, this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            bIsMoving = true;
            Vector3 MousePosition;
            MousePosition = Input.mousePosition;
            MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);

            StartPositionInX = MousePosition.x - this.transform.localPosition.x;
        }
    }

    private void OnMouseUp()
    {
        bIsMoving = false;

        if(Mathf.Abs(this.transform.localPosition.x - correctPositionedObject.transform.localPosition.x) <= 0.5f && Mathf.Abs(this.transform.localPosition.y - correctPositionedObject.transform.localPosition.y) <= 0.5f)
        {
            this.transform.position = new Vector3(correctPositionedObject.transform.position.x, correctPositionedObject.transform.position.y, correctPositionedObject.transform.position.z);
            bIsPieceInRightPosition = true;
            GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>().AddPoint();
        }
        else
        {
            this.transform.localPosition = new Vector3(ResetPosition.x, ResetPosition.y, ResetPosition.z);
        }
        
    }
}
