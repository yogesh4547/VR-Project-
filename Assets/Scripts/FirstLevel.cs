using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FirstLevel : MonoBehaviour
{
    [SerializeField] private int numberOfElements;

    private int numberOfElementsInSocket = 0;

    public UnityEvent level2;

    public void addElements ()
    {
        numberOfElementsInSocket++;
        checkForElements();


    }

    public void checkForElements()
    {
        if(numberOfElementsInSocket == numberOfElements)
        {
            level2.Invoke();
        }
    }

    public void removeElements() 
    {
        numberOfElementsInSocket--;
        checkForElements();
    }
}
