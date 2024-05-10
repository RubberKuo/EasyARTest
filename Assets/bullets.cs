using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    public MoveChange movechange;
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        movechange =GameObject.Find("assault3").GetComponent<MoveChange>();
        StartCoroutine(dest_());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * movespeed*Time.deltaTime);
    }


    IEnumerator dest_()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "AI")
        {
            movechange.insShowUI();
            //Debug.LogError("Œ“¥•∑¢¡À");
        }
    }
}
