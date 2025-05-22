using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class pusher : MonoBehaviour
{
    int num = 0;
    public GameObject gameObject = default;
    // Start is called before the first frame update
    void Start()
    {
        num = 1 + 1;
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new UnityEngine.Vector3(0, 0, -1);
    }
}
