using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class ChangeWire : MonoBehaviour
{
    public List<GameObject> Wire = new List<GameObject>();
    public List<GameObject> CuttingWire = new List<GameObject>();
    public List<GameObject> StrippedWire = new List<GameObject>();
    public List<GameObject> PbWire = new List<GameObject>();

    public Material[] mat = new Material[2];
    

    public bool isCutted1 = false;
    public bool isCutted2 = false;
    public bool isCutted3 = false;
    public bool isCutted4 = false;
    public bool isCuttingDone = false;

    public bool isStripped1 = false;
    public bool isStripped2 = false;
    public bool isStripped3 = false;
    public bool isStripped4 = false;



    public bool isDone1 = false;
    public bool isDone2 = false;
    public bool isDone3 = false;
    public bool isDone4 = false;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Wire[0].SetActive(true);
        Wire[1].SetActive(false);
        Wire[2].SetActive(false);

        PbWire[0].GetComponent<MeshRenderer>().material = mat[2];
        PbWire[1].GetComponent<MeshRenderer>().material = mat[2];
        PbWire[2].GetComponent<MeshRenderer>().material = mat[2];
        PbWire[3].GetComponent<MeshRenderer>().material = mat[2];

    }

    // Update is called once per frame
    void Update()
    {
        isDone1 = MoveObject.instance.moveDone;


        if(isDone1)
        {
            Wire[0].SetActive(false);
            Wire[1].SetActive(true);

            CuttingWire[0].SetActive(!isCutted1);
            CuttingWire[1].SetActive(!isCutted2);
            CuttingWire[2].SetActive(!isCutted3);
            CuttingWire[3].SetActive(!isCutted4);
            isDone4 = false;
        }

        //Ŀ���� �� ���� �˸�
        if(isCutted1 && isCutted2 && isCutted3 && isCutted4)
        {
            isCuttingDone = true;
            isDone1 = false;

        }


       



        //�Ǻ��� ���ܳ�
        if (isCuttingDone)
        {
            isStripped1 = MoveJig.instance.stripped1;
            isStripped2 = MoveJig.instance.stripped2;
            isStripped3 = MoveJig.instance.stripped3;
            isStripped4 = MoveJig.instance.stripped4;
            if (isStripped1)
                StrippedWire[0].GetComponent<MeshRenderer>().material = mat[2];
            if (isStripped2)
                StrippedWire[1].GetComponent<MeshRenderer>().material = mat[2];
            if (isStripped3)
                StrippedWire[2].GetComponent<MeshRenderer>().material = mat[2];
            if (isStripped4)
                StrippedWire[3].GetComponent<MeshRenderer>().material = mat[2];
            
        }

        //�Ǻ��� �� ������ �˸�
        if (isStripped1 && isStripped2 && isStripped3 && isStripped4)
        {
            isDone2 = true;
            isCuttingDone = false;
        }

        if(isDone2 && isDone3)
        {
            isDone2 = false;
            Wire[1].SetActive(false);
            Wire[2].SetActive(true);

        }
        if(isDone4)
        {
            isDone3 = false;
            PbWire[0].GetComponent<MeshRenderer>().material = mat[1];
            PbWire[1].GetComponent<MeshRenderer>().material = mat[1];
            PbWire[2].GetComponent<MeshRenderer>().material = mat[1];
            PbWire[3].GetComponent<MeshRenderer>().material = mat[1];
        }

        

        



    }


}
