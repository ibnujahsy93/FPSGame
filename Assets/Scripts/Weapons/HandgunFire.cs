using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    [SerializeField] AudioSource gunFire; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gunFire.Play();
        }
    }
}
