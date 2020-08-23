using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{

    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-2, 0, 0);
        Instantiate(redObj,transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
