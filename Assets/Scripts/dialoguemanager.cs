using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class dialoguemanager : MonoBehaviour
{
  
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo, textoBoton;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;
    [SerializeField] bool misionempezada;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCDIALOGUE>().data.dialoguelines;
            misionempezada = other.gameObject.GetComponent<NPCDIALOGUE>().data.misionempezada;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "Hola forastero";
            }

            else
            {
                textoDelDialogo.text = "Ve a buscar las cosas!";
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            //al entrar desactiva la UI de dialogo
            dialogueUI.SetActive(false);
        }
    }

    public void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;

            if (posicionFrase == frasesDialogo.Length)
            {
                textoBoton.text = "Cerrar";
            }
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
            misionempezada = true;
        }

    }
}
