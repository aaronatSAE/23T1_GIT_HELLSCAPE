using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
     private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //get object and mouse position
        mOffset = gameObject.transform.position - GetMouseWorldPos();

    }

    private Vector3 GetMouseWorldPos()
    {
        //x y coordinates
        Vector3 mousePoint = Input.mousePosition;

        //z coordinates
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
    //click on the object with the mopuse and drag it
}
