using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChange : MonoBehaviour
{

    public GameObject bullets;

    public Transform inspos;

    public Vector3 oldPos;


    public GameObject ShowUI;

    public Transform ShowUIpar;
    // Start is called before the first frame update
    void Start()
    {
        oldPos  = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MoveAndInsBullets()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.25f);
        GameObject obj = Instantiate(bullets);
        StartCoroutine(Reset());

    }


    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        this.transform.position = oldPos;
    }



    public void insShowUI()
    {
        GameObject obj = Instantiate(ShowUI,ShowUIpar);
    }
}
