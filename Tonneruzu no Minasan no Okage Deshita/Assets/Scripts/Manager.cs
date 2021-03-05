using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int CurrentPhase = 0;
    public float Timer1;
    public float Timer2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentPhase==0)
        {
            FirstPhase();
        }
        if(CurrentPhase==1)
        {
            SecondPhase();
        }
    }
    public void FirstPhase()
    {
        if(CurrentPhase==0)
        { 
            if(Timer1>0)
            {
                Timer1 -= Time.deltaTime;
            }
        }
        if (Timer1<=0)
        {
            CurrentPhase = 1;
        }
    }
    public void SecondPhase()
    {
        if(CurrentPhase==1)
        {
            if (Timer2 > 0)
            {
                Timer2 -= Time.deltaTime;
            }
        }
        if(Timer2<=0)
        {
            CurrentPhase = 2;
        }
    }
}
