using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed=5f;
    float horizontal, vertical;
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    private GameObject spawnPosition;

    public float force = 2f;
    // Update is called once per frame
    void Update()
    {

        //playerMovement
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(BulletPrefab);
            bullet.transform.position = spawnPosition.transform.position+spawnPosition.transform.forward;
        }
    }
}
