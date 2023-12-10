using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public float shrinkSpeed = 5;
    public Vector3 rotateSpeed;
    public GameObject bottle;

    private void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);

        if (transform.localScale.x > 1f)
        {
            transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        }
    }

    private void OnMouseDown()
    {
        GameManager.clicks++;
        transform.localScale = Vector3.one * 1.3f;

        var position = new Vector3(Random.Range(-4.0f, 4.0f), 5, 0);

        Instantiate(bottle, position, Quaternion.identity);
    }
}
