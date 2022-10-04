using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propellerRotationSpeed = 10;
    private Vector3 propellerRotationAngle;

    // Start is called before the first frame update
    void Start()
    {
        propellerRotationAngle = new Vector3(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller along its Z-Axis
        transform.Rotate(propellerRotationAngle, propellerRotationSpeed);
    }
}
