using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBoundsCheckable
{
    void OnOutOfBounds();
}

public class CameraBoundsChecker : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    private void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    private void OnOutOfBounds(Camera mainCamera)
    {
        // get object width and height
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2

        // check if object is out of bounds
        if (transform.position.x < screenBounds.x - objectWidth)
        {
            // call OnOutOfBounds function if object is out of bounds
            IBoundsCheckable boundsCheckable = GetComponent<IBoundsCheckable>();
            if (boundsCheckable != null)
            {
                boundsCheckable.OnOutOfBounds();
            }
        }
        if (transform.position.x > screenBounds.x + objectWidth)
        {
            // call OnOutOfBounds function if object is out of bounds
            IBoundsCheckable boundsCheckable = GetComponent<IBoundsCheckable>();
            if (boundsCheckable != null)
            {
                boundsCheckable.OnOutOfBounds();
            }
        }
        if (transform.position.y < screenBounds.y - objectHeight)
        {
            // call OnOutOfBounds function if object is out of bounds
            IBoundsCheckable boundsCheckable = GetComponent<IBoundsCheckable>();
            if (boundsCheckable != null)
            {
                boundsCheckable.OnOutOfBounds();
            }
        }
        if (transform.position.y > screenBounds.y + objectHeight)
        {
            // call OnOutOfBounds function if object is out of bounds
            IBoundsCheckable boundsCheckable = GetComponent<IBoundsCheckable>();
            if (boundsCheckable != null)
            {
                boundsCheckable.OnOutOfBounds();
            }
        }
    }




}