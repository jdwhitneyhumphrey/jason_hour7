using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Put together a loop that outputs 9 - 0
        int count = 9;
        //Debug.Log("This is my count" + count)
        do
        {
            count = count - 1;
            Debug.Log("This is my count " + count);
        }
        while (count > 0);

        count = 9;
        //Debug.Log("This is my count" + count)
        while (count > 0)
        {
            count = count - 1;
            Debug.Log("This is my count " + count);
        }

        for(int i = 10; i > 0; i--)
        {
            Debug.Log("This is my count " + count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
