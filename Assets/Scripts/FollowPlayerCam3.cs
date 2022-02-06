using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCam3 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0.2f, 19f, -1.5f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
