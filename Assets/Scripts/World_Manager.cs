using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class World_Manager : MonoBehaviour
{
    private Chunk[,] world = new Chunk[1000, 1000];
    private Chunkcreator[,] worldSkripts = new Chunkcreator[1000, 1000];
    public bool Spawn { get; set; } = true;

    public bool[] AddChunk(Chunk achunk, Chunkcreator chunkcreator)
    {
        int placeX;
        int placeY;
        bool[] returner = new bool[8];
        int counter = 0;

        if(achunk.WorldSpaceX < 0)
        {
            placeX = 100 - (Mathf.Abs(achunk.WorldSpaceX) % 100);
        }
        else
        {
            placeX = achunk.WorldSpaceX % 100;
        }

        if(achunk.WorldSpaceY < 0)
        {
            placeY = 100 - (Mathf.Abs(achunk.WorldSpaceY) % 100);
        }
        else
        {
            placeY = achunk.WorldSpaceY % 100;
        }

        world[placeX, placeY] = achunk;
        worldSkripts[placeX, placeY] = chunkcreator;

        if(placeX > 0 && placeY > 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1 && i == 1){ }
                    else
                    {
                        if (worldSkripts[((placeX - 1) + j) % 100, ((placeY - 1) + i)%100] != null)
                        {
                            returner[counter] = true;
                            worldSkripts[((placeX - 1) + j) % 100, ((placeY - 1) + i) % 100].setSpawn(7 - counter);
                            Debug.Log(7 - counter);
                            counter += 1;
                        }
                        else
                        {
                            counter += 1;
                        }
                    }
                }
            }
        }

        else if(placeX <= 0 && placeY <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1 && i == 1){ }
                    else
                    {
                        if (worldSkripts[(100 - (Mathf.Abs(placeX - 1) % 100) + j) % 100, (100 - (Mathf.Abs(placeY - 1) % 100) + i) % 100] != null)
                        {
                            returner[counter] = true;
                            worldSkripts[(100 - (Mathf.Abs(placeX - 1) % 100) + j) % 100, (100 - (Mathf.Abs(placeY - 1) % 100) + i) % 100].setSpawn(7 - counter);
                            Debug.Log(7 - counter);
                            counter += 1;
                        }
                        else
                        {
                            counter += 1;
                        }
                    }
                }
            }            
        }

        else if (placeX <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1 && i == 1){ }
                    else
                    {
                        if (worldSkripts[(100 - (Mathf.Abs(placeX - 1) % 100) + j)  % 100, ((placeY - 1) + i) % 100] != null)
                        {
                            returner[counter] = true;
                            worldSkripts[(100 - (Mathf.Abs(placeX - 1) % 100) + j) % 100, ((placeY - 1) + i) % 100].setSpawn(7-counter);

                            Debug.Log(7 - counter);
                            counter += 1;
                        }
                        else
                        {
                            counter += 1;
                        }
                    }
                }
            }            
        }

        else if(placeY <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1 && i == 1) { }
                    else
                    {
                        if (worldSkripts [((placeX - 1) + j) % 100,(100 - (Mathf.Abs(placeY - 1) % 100) + i) % 100] != null)
                        {
                            returner[counter] = true;
                            worldSkripts[((placeX - 1) + j) % 100, (100 - (Mathf.Abs(placeY - 1) % 100) + i) % 100].setSpawn(7 - counter);
                            Debug.Log(7 - counter); 
                            counter += 1;                
                        }
                        else
                        {
                            counter += 1;
                        }
                    }
                }
            }            
        }
        Spawn = true;
        return returner;
    }    
}
