using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutFOV = 60f;

    bool isZoomedIn = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(isZoomedIn == false)
            {
                isZoomedIn = true;
                fpsCamera.fieldOfView = zoomedInFOV;
            }
            else
            {
                isZoomedIn = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
            }
        }
    }
}
