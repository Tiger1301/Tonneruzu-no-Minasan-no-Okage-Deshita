using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Manager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GM.CurrentPhase==0)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                GM.CurrentPhase = 1;
                GM.Timer2 = GM.Timer2 + GM.Timer1;
            }
        }
    }
}
