using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColDetection : MonoBehaviour
{
    public int contador = 0;
    public Text contadorText;
    // Start is called before the first frame update
    void Start()
    {
        contadorText.text = "Score: " + contador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("celu")){
            Destroy(other.gameObject);
            contador++;
            contadorText.text = "Score: " + contador;
        }
        
    }
}
