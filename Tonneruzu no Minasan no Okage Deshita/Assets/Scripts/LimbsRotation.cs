using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbsRotation : MonoBehaviour
{
    public GameObject RightArm, LeftArm, RightLeg, LeftLeg;
    public float RotationAngle;
    public float RotationSpeed;
    Manager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GM.CurrentPhase==1)
        {
            RotationInput();
            ResetRotation();
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                GM.CurrentPhase = 2;
            }
        }
    }

    public void RotationInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LeftArm.transform.Rotate(0, 0, -RotationAngle);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            LeftLeg.transform.Rotate(0, 0, -RotationAngle);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            RightLeg.transform.Rotate(0, 0, RotationAngle);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            RightArm.transform.Rotate(0, 0, RotationAngle);
        }
    }

    public void ResetRotation()
    {
        if(LeftArm.transform.rotation.z<0)
        {
            LeftArm.transform.Rotate(0, 0, RotationSpeed);
        }
        if (RightArm.transform.rotation.z > 0)
        {
            RightArm.transform.Rotate(0, 0, -RotationSpeed);
        }
        if (LeftLeg.transform.rotation.z < 0)
        {
            LeftLeg.transform.Rotate(0, 0, RotationSpeed);
        }
        if (RightLeg.transform.rotation.z > 0)
        {
            RightLeg.transform.Rotate(0, 0, -RotationSpeed);
        }
    }
}
