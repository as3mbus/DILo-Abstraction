using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speedMod = 5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float x = position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speedMod;
        float y = position.y + Input.GetAxis("Vertical") * Time.deltaTime * speedMod;
        transform.position = new Vector3(x, y, position.z);
    }
}