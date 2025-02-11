using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour
{
    public List<GameObject> cars = new List<GameObject>(6);
    public GameObject carClone;
    public carMove car;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 6; i++)
        {
            Spawn();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject newCar = Instantiate(carClone);
        car = newCar.GetComponent<carMove>();
        cars.Add(newCar);
    }
}
