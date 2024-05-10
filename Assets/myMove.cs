using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMove : MonoBehaviour
{



    public float movespeed=2;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(des());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up*movespeed*Time.deltaTime);
    }

    IEnumerator des()
    {
        yield return new WaitForSeconds(1f);

        Destroy(this.gameObject);
    }
}
