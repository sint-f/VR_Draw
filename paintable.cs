using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintable : MonoBehaviour
{
    public GameObject brush;
    public float brushsize = 0.1f;

    // Update is called once per frame
    void Update()
    {
        var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(Ray, out hit, Mathf.Infinity))
        {
            switch (hit.collider.tag)
            {
                case "wall":
                    var go = Instantiate(brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                    go.transform.localScale = Vector3.one * brushsize;
                    break;
                case "red":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "orange":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "yellow":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "green":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "blue":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "purple":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "white":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "black":
                    brush.GetComponent<MeshRenderer>().materials = hit.collider.gameObject.GetComponent<MeshRenderer>().materials;
                    break;
                case "small":
                    brushsize = 0.5f;
                    break;
                case "normal":
                    brushsize = 1f;
                    break;
                case "large":
                    brushsize = 2f;
                    break;
                default:
                    Debug.Log("error");
                    break;
            }
        }
    }
}
