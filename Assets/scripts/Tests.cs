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
        // transform.localScale�� �̿��Ͽ�
        // Squre�� 1,1,1 => 3,3,3 => 1,1,1�� �ٲ�� ������ �����մϴ�.
        // localScale�� Vector3 ����ü�� ���ؼ� ���ϰ� �� �� �ֽ��ϴ�.

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
