using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Chunk
{
    [SerializeField]private bool[] spawns = new bool[8];

    private bool setTexturebool = true;
        
    [SerializeField]private int worldSpaceX = 0;
    [SerializeField]private int worldSpaceY = 0;

    private Sprite[] textures;


    //creators
    public Chunk(bool[] spawn)
    {

        for (int i = 0; i < 8; i++)
        {
            if(spawn[i] == true)
            {
                spawns[i] = true;
            }
            else
            {
                spawns[i] = false;
            }
        }
    }
   
    public Chunk() { }


    //getters setters
    
    
    public Sprite[] Textures
    {
        
        get 
        {
            textures = Resources.LoadAll<Sprite>("Map");
            return textures; 
        }
    }
   
    public bool[] Spawns
    {
        get { return spawns; }
        set { spawns = value; }
    }

    public int WorldSpaceX
    {
        get { return worldSpaceX; }
        set { worldSpaceX = value; }
    }
    public int WorldSpaceY
    {
        get { return worldSpaceY; }
        set { worldSpaceY = value; }
    }
}
