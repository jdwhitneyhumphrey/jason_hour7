using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 1; i < 12; i = i + 1)
        {
            Debug.Log(i);

            if (i == 6)
            {
                print("It's my birthday month!");
            }
        }

        for (int i = 1; i < 30; i = i + 1)
        {
            Debug.Log(i);

            if (i == 14)
            {
                print("It's my birthday day!");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
