using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;

    private void Start()
    {
        transform.position = player.transform.position + (offset);
    }

    private void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
