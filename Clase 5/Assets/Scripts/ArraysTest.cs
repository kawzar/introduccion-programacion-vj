using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysTest : MonoBehaviour
{
    public Vector3 potionPosition;
    public float spaceBetweenPotions = 1;

    public int numberOfPotions = 10;

    public float minYPosition = -4;
    public float maxYPosition = -2;

    //private int[] numeros;
    public Potion[] potions;

    // Start is called before the first frame update
    void Start()
    {
        //    numeros = new int[5];

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        numeros[i] = i * 2;
        //        print(numeros[i]);
        //    }

        //Potion newPotion = Instantiate<Potion>(potions[0]);
        //newPotion.transform.position = potionPosition;

        for (int i = 0; i < numberOfPotions; i++)
        {
            int randomNumber = Random.Range(0, potions.Length);
            Potion newPotion = Instantiate<Potion>(potions[randomNumber]);
            newPotion.transform.position = potionPosition;

            potionPosition.x += spaceBetweenPotions;
            potionPosition.y = Random.Range(minYPosition, maxYPosition);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
