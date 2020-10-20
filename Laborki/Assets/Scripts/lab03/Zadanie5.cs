using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject myPrefab;
    public int from;
    public int to;
    public int howManyCubes;

    void Start()
    {
        List<int[]> Pairs = generateRandomPairs(from, to);
        for (int i = 0; i < howManyCubes; i++)
        {
            int randPair = UnityEngine.Random.Range(from, Pairs.Count);
            Instantiate(myPrefab, new Vector3(Pairs[randPair][0], 0.5f, Pairs[randPair][1]), Quaternion.identity);
            Pairs.Remove(Pairs[randPair]);
        }
    }

    List<int[]> generateRandomPairs(int from, int to)
    {
        List<int[]> wynik = new List<int[]>();

        for (int i = from; i < to; i++)
            for (int j = from; j < to; j++)
                wynik.Add(new int[2] { i, j });

        return wynik;
    }

}
