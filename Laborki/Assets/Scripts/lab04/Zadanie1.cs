using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3f;
    int objectCounter = 0;
    public int howManyObject;
    public GameObject block;
    public Material[] materials;
    System.Random rnd = new System.Random();

    void Start()
    {
        GameObject plane = GameObject.Find("Plane");
        int positionX = (int)plane.transform.position.x;
        int scaleX = (int)plane.transform.localScale.x;
        int positionZ = (int)plane.transform.position.z;
        int scaleZ = (int)plane.transform.localScale.z;

        List<int> pozycje_x = new List<int>(Enumerable.Range(positionX - (scaleX * 5), positionX + (scaleX * 5)).OrderBy(x => Guid.NewGuid()).Take(howManyObject));
        List<int> pozycje_z = new List<int>(Enumerable.Range(positionZ - (scaleZ * 5), positionX + (scaleZ * 5)).OrderBy(x => Guid.NewGuid()).Take(howManyObject));

        for (int i = 0; i < howManyObject; i++)
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));

        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        foreach (Vector3 pos in positions)
        {
            this.block.GetComponent<Renderer>().material = materials[rnd.Next(0, materials.Length)];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }

        StopCoroutine(GenerujObiekt());
    }
}