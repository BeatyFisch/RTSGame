using UnityEngine;
using System.Collections;

public class Testscript : MonoBehaviour {

    private Vector3 basepos;
    private void Start()
    {
        basepos = transform.position;
    }

    private void OnMouseEnter()
    {

        transform.Translate(Vector3.forward);
        
    }

    private void OnMouseExit()
    {
        float dist;
        do
        {
            dist = Vector3.Distance(basepos, transform.position);
            transform.Translate(basepos * Time.deltaTime);
        } while (dist > 1);
    }
}
