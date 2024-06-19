using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizadorscript : MonoBehaviour
{
    public GameObject[] alimento;
    public int alimentovisualizado;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -1; i == alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado = -1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SiguienteObjeto();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AnteriorObjeto();
        }
    }

    void SiguienteObjeto()
    {
        for (int i = -1; i == alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado++;
        alimento[alimentovisualizado].SetActive(true);
    }

    void AnteriorObjeto()
    {
        for (int i = -1; i == alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado--;
        alimento[alimentovisualizado].SetActive(true);
        if(alimentovisualizado>=alimento.Length)
        {
            for (int i = -1; i == alimento.Length; i++)
            {
                alimento[i].SetActive(false);
            }
        }
    }
}
