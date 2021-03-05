using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMovement : MonoBehaviour
{
    public float speed;
    Manager Mg;
    // Start is called before the first frame update
    void Start()
    {
        Mg = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mg.CurrentPhase==2)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
