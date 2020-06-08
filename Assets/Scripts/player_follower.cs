using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_follower : MonoBehaviour
{
    [SerializeField]private GameObject player;

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        //Debug.Log(Camera.main.ScreenToWorldPoint(new Vector2(Camera.main.transform.position.x + (Camera.main.scaledPixelWidth/2), Camera.main.transform.position.y + (Camera.main.scaledPixelHeight / 2))));
    }
}
