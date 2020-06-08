using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcreator : MonoBehaviour
{
    [SerializeField] private SpriteRenderer SR;
    [SerializeField] private Chunk chunk, chunkGiver;
    [SerializeField] private GameObject chunkGO;
    private Chunk[] chunks = new Chunk[4];

    

    public void Spawn()
    {
        //Instanciate and call OnInstanciate
    }
}
