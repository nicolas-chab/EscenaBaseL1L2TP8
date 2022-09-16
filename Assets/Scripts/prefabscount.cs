using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prefabscount : MonoBehaviour
{
    public GameObject puerta;
    public static int contadordecomponentesparanpc=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contadordecomponentesparanpc >= 4)
        {
            Destroy(gameObject);
            Destroy(puerta);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("mouse"))
        {
          
            contadordecomponentesparanpc+=1;
            
        }
        if (other.gameObject.CompareTag("teclado"))
        {
           
            contadordecomponentesparanpc+=1;

        }
        if (other.gameObject.CompareTag("monitor"))
        {
           
            contadordecomponentesparanpc+=1;

        }
        if (other.gameObject.CompareTag("gabinete"))
        {
    
            contadordecomponentesparanpc+=1;
            
        }
    }
    
}
