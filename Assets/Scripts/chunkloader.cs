using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkloader : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private Chunkcreator Chunkcreator;
    private bool right, top, left, bottom;
    private int ID;
    private int x, y;
    private bool spawned = false;

    private void Start()
    {
        cam = Camera.main;
        Chunkcreator = GetComponentInParent<Chunkcreator>();

        if(right == true)
        {
            if(top == true)
            {
                ID = 6;
            }
            else if(bottom == true)
            {
                ID = 5;
            }
            else
            {
                ID = 1;
            }
        }
        else if (left == true)
        {
            if (top == true)
            {
                ID = 7;
            }
            else if (bottom == true)
            {
                ID = 4;
            }
            else
            {
                ID = 3;
            }
        }
        else if(bottom == true)
        {
            ID = 0;
        }
        else if(top == true)
        {
            ID = 2;
        }
    }

    void Update()
    {        
        if(spawned == false)
        {
            if (transform.position.x < cam.ScreenToWorldPoint(new Vector2(cam.transform.position.x + cam.scaledPixelWidth, cam.transform.position.y)).x && transform.position.x > cam.ScreenToWorldPoint(new Vector2(cam.transform.position.x, cam.transform.position.y)).x)
            {
                if (transform.position.y < cam.ScreenToWorldPoint(new Vector2(cam.transform.position.x, cam.transform.position.y + cam.scaledPixelHeight)).y && transform.position.y > cam.ScreenToWorldPoint(new Vector2(cam.transform.position.x, cam.transform.position.y)).y)
                {
                    Debug.Log("create");
                    spawned = true;
                    Chunkcreator.setNewChunk(ID);                                      
                }
            }
        }
    }

    public bool Right
    {
        get { return right; }
        set { right = value; }
    }
    public bool Top
    {
        get { return top; }
        set { top = value; }
    }
    public bool Left    
    {
        get { return left; }
        set { left = value; }
    }
    public bool Bottom  
    {
        get { return bottom; }
        set { bottom = value; }
    }
}