using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainunityengine : MonoBehaviour
{
    void Start()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        for (int y = 0; y < windowY; y++)
        {
                for (int x = 0; x < windowX; x++)
                {
                    newwinow(windowX 800, windowY 400(transform.position.y 800, transform.position.x 400));
                    
                }
            posX = transform.position.x;
            posY = transform.position.y;
        }
    }
}
