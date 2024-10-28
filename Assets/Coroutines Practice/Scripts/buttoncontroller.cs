using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoncontroller : MonoBehaviour
{
    private bool buttonPushed = false;
    public GameObject cannonBall;
    public GameObject spawnpoint;
    public Material defaultMaterial;
    public Material usedMaterial;
    public MeshRenderer myMr;
    private void Start()
    {
        myMr = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!buttonPushed)
        {
            buttonPushed = true;
            Debug.Log("button was pushed");
            myMr.material = usedMaterial;
            StartCoroutine(buttonDelay());
            Shoot();
        }
    }
    IEnumerator buttonDelay()
    {
        yield return new WaitForSeconds(5);
        myMr.material = defaultMaterial;
        buttonPushed = false;
    }
    public void Shoot()
    {
        Instantiate(cannonBall, spawnpoint.transform.position, spawnpoint.transform.rotation);
    }
}
