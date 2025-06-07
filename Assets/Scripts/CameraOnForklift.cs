using System.Collections;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CameraOnForklift : MonoBehaviour
{
    [SerializeField] private XROrigin xrOrigin; // Reference to XR Origin   
    [SerializeField] private Transform driverSeatTransform; // Reference to the driver seat 
    [SerializeField] private Transform forkliftTransform; // Reference to the forklift 
    [SerializeField] private Vector3 seatOffset = Vector3.zero; 

    private bool isCameraAttached = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            isCameraAttached = !isCameraAttached;
            if (isCameraAttached)
            {
                
                xrOrigin.transform.SetPositionAndRotation(
                    driverSeatTransform.position + seatOffset,
                    driverSeatTransform.rotation
                );
                
                xrOrigin.transform.SetParent(forkliftTransform, true);
            }
            else
            {
                xrOrigin.transform.SetParent(null, true);
            }
        }
    }
}
