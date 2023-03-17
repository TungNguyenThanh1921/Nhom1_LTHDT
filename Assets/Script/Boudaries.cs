using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(RectTransform))]
public class Boudaries : MonoBehaviour
{
    RectTransform rt;
    Vector3[] worldconners;
    public Camera boundedcamera;
    
    private void Awake()
    {
        rt = transform as RectTransform;
        worldconners = new Vector3[4];
        if (boundedcamera == null)
        {
            boundedcamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        }
       
    }



    private void LateUpdate()
    {
       
        rt.GetWorldCorners(worldconners);
        var worldbounds = new Rect(worldconners[0], new Vector2(rt.rect.size.x * transform.localScale.x, rt.rect.size.y * transform.localScale.y));

        var viewExtents = new Vector2(boundedcamera.aspect * boundedcamera.orthographicSize, boundedcamera.orthographicSize);
        var camerapos = boundedcamera.transform.position;

        boundedcamera.transform.position = new Vector3(
            Mathf.Clamp(camerapos.x, worldbounds.min.x + viewExtents.x, worldbounds.max.x - viewExtents.x),
            Mathf.Clamp(camerapos.y, worldbounds.min.y + viewExtents.y, worldbounds.max.y - viewExtents.y),
            camerapos.z
            );
    }
}
