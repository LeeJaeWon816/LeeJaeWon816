using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tests : MonoBehaviour
{
    public bool MoveRight = true;
    public bool SizeUp = true;
    public bool MoveUp = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Test Script On Start");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localScale을 이용하여
        // Squre을 1,1,1 => 3,3,3 => 1,1,1로 바뀌는 로직을 구현합니다.
        // localScale도 Vector3 구조체를 통해서 더하고 뺄 수 있습니다.

        Debug.Log("Test Script On Update");
        if (MoveRight)
        {
            transform.position += new Vector3(0.01f, 0, 0);
            if(transform.position.x > 7)
            {
                MoveRight = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0.01f, 0, 0);
            if (transform.position.x < -7)
            {
                MoveRight = true;
            }
        }

        if (SizeUp)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            if (transform.localScale.x > 3)
            {
                SizeUp = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            if(transform.localScale.x < 1)
            {
                SizeUp = true;
            }
        }

        if(MoveUp)
        {
            transform.position += new Vector3(0, 0.01f, 0);
            if(transform.position.y > 4)
            {
                MoveUp = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0, 0.01f, 0);
            if(transform.position.y < -4)
            {
                MoveUp = true;
            }
        }
    }
}
