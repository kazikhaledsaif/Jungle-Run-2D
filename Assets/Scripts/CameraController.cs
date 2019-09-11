using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Player player;
    private Vector3 lastPostion;
    private float distance;
    void Start()
    {
        player = FindObjectOfType<Player>();
        lastPostion = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPostion.x;
        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y,
            transform.position.z);
        lastPostion = player.transform.position;
    }
}
