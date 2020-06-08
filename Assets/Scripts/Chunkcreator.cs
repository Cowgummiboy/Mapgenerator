using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunkcreator : MonoBehaviour
{
    [SerializeField] private int Chunksize;

    [SerializeField] private Vector2[,] position;

    [SerializeField] private Chunk thisChunk;

    [SerializeField] private GameObject chunkGO, startChunkGO;

    private bool built = true;

    private int Tilesize = 10;

    private World_Manager World_Manager;
    

    private void Update()
    {
        if (built)
        {
            createChunk();
            built = false;
        }
    }

    //Spawn new Chunk
    public void setNewChunk(int iD)
    {
        if (GetComponentInParent<World_Manager>().Spawn == true)
        {
            GetComponentInParent<World_Manager>().Spawn = false;
            if (iD == 0)
            {
                if (thisChunk.Spawns[1] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y - Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY - 1;
                    thisChunk.Spawns[1] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 1)
            {
                if (thisChunk.Spawns[4] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x + Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();

                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX + 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[4] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 2)
            {
                if (thisChunk.Spawns[6] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y + Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY + 1;
                    thisChunk.Spawns[6] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 3)
            {
                if (thisChunk.Spawns[3] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x - Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX - 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[3] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 4)
            {
                if (thisChunk.Spawns[0] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x - Chunksize * Tilesize, transform.position.y - Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX - 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY - 1;
                    thisChunk.Spawns[0] = true;
                }
                if (thisChunk.Spawns[3] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x - Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX - 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[3] = true;
                }
                if (thisChunk.Spawns[1] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y - Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY - 1;
                    thisChunk.Spawns[1] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 5)
            {
                if (thisChunk.Spawns[2] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x + Chunksize * Tilesize, transform.position.y - Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX + 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY - 1;
                    thisChunk.Spawns[2] = true;
                }
                if (thisChunk.Spawns[1] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y - Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY - 1;
                    thisChunk.Spawns[1] = true;
                }
                if (thisChunk.Spawns[4] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x + Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX + 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[4] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 6)
            {
                if (thisChunk.Spawns[7] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x + Chunksize * Tilesize, transform.position.y + Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX + 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY + 1;
                    thisChunk.Spawns[7] = true;
                }
                if (thisChunk.Spawns[4] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x + Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX + 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[4] = true;
                }
                if (thisChunk.Spawns[6] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y + Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY + 1;
                    thisChunk.Spawns[6] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
            else if (iD == 7)
            {
                if (thisChunk.Spawns[5] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x - Chunksize * Tilesize, transform.position.y + Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX - 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY + 1;
                    thisChunk.Spawns[5] = true;
                }
                if (thisChunk.Spawns[6] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x, transform.position.y + Chunksize * Tilesize), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY + 1;
                    thisChunk.Spawns[6] = true;
                }
                if (thisChunk.Spawns[3] == false)
                {
                    Chunkcreator save = Instantiate<GameObject>(startChunkGO, new Vector2(transform.position.x - Chunksize * Tilesize, transform.position.y), Quaternion.identity, transform.parent).GetComponent<Chunkcreator>();
                    save.thisChunk.WorldSpaceX = thisChunk.WorldSpaceX - 1;
                    save.thisChunk.WorldSpaceY = thisChunk.WorldSpaceY;
                    thisChunk.Spawns[3] = true;
                }
                else { GetComponentInParent<World_Manager>().Spawn = true; }
            }
        }
    }

    private void createChunk()
    {
        GameObject tile;
        startChunkGO = Resources.Load<GameObject>("Chunk/Chunk_Start");
        position = new Vector2[Chunksize, Chunksize];
        World_Manager = GetComponentInParent<World_Manager>();
        ThisChunk.Spawns =  World_Manager.AddChunk(thisChunk, gameObject.GetComponent<Chunkcreator>());

        //activate chunkloaders
        for (int i = 0; i < Chunksize; i++)
        {
            for (int j = 0; j < Chunksize; j++)
            {
                position[j, i] = new Vector2(j * 10, i * 10);
                tile = Instantiate<GameObject>(chunkGO, transform, false);
                tile.transform.localPosition = position[j, i];
                tile.GetComponent<SpriteRenderer>().sprite = thisChunk.Textures[Random.Range(0, thisChunk.Textures.Length)];
                if (i == 0)
                {
                    tile.GetComponent<chunkloader>().enabled = true;
                    tile.GetComponent<chunkloader>().Bottom = true;
                }
                if (i == Chunksize - 1)
                {
                    tile.GetComponent<chunkloader>().enabled = true;
                    tile.GetComponent<chunkloader>().Top = true;
                }
                if (j == 0)
                {
                    tile.GetComponent<chunkloader>().enabled = true;
                    tile.GetComponent<chunkloader>().Left = true;
                }
                if (j == Chunksize - 1)
                {
                    tile.GetComponent<chunkloader>().enabled = true;
                    tile.GetComponent<chunkloader>().Right = true;
                }
            }
        }
    }

    public void setSpawn(int pos)
    {
        ThisChunk.Spawns[pos] = true;
    }
    
    public Chunk ThisChunk
    {
        get { return thisChunk; }
        set { thisChunk = value; }
    }
}

