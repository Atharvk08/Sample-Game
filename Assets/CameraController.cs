using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject player;
    Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position- player.transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position+offset;
    }
}
