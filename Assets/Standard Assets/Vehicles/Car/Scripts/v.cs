using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
namespace UnityStandardAssets.Vehicles.Car
{
public class v : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CarController>().enabled = true;
			GetComponent<CarUserControl>().enabled = true;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
