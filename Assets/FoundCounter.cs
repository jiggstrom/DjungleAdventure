using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoundCounter : MonoBehaviour
{
    static int counter = 0;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "RigidBodyFPSController")
        {
            var textref = GameObject.Find("CountText").GetComponent<Text>();
            counter++;
            textref.text = counter.ToString();
            if (counter == 1)
            {
                textref.color = Color.red;
                //var win = GameObject.FindGameObjectWithTag("Finish");
                //win.SetActive(true);
            }
            Destroy(this.gameObject);

        }
    }
}