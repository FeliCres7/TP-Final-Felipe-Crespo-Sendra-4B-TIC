using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizadorscript1 : MonoBehaviour
{
    public GameObject[] alimento;
    public int alimentovisualizado;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado = 0;

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
        for (int i = 0; i < alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado++;
        if (alimentovisualizado >= alimento.Length)
        {

            alimentovisualizado = alimento.Length - 1;

        }
        alimento[alimentovisualizado].SetActive(true);

    }

    void AnteriorObjeto()
    {
        for (int i = 0; i < alimento.Length; i++)
        {
            alimento[i].SetActive(false);
        }
        alimentovisualizado--;
        if (alimentovisualizado <= 0)
        {


            alimentovisualizado = 0;

        }
        alimento[alimentovisualizado].SetActive(true);

    }
}
