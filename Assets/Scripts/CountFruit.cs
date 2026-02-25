using UnityEngine;

public class CountFruit : MonoBehaviour
{
    public bool orange;
    public bool lemon;
    public bool lime;
    public int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("orange") && orange)
        {
            count++;
            UnityEngine.Debug.Log("oranges: " + count);
        } 
        else if (other.CompareTag("lemon") && lemon)
        {
            count++;
            UnityEngine.Debug.Log("lemon: " + count);
        } 
        else if(other.CompareTag("lime") && lime)
        {
            count++;
            UnityEngine.Debug.Log("lime: " + count);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("orange") && orange)
        {
            count--;
            UnityEngine.Debug.Log("oranges: " + count);
        }
        else if (other.CompareTag("lemon") && lemon)
        {
            count--;
            UnityEngine.Debug.Log("lemon: " + count);
        }
        else if (other.CompareTag("lime") && lime)
        {
            count--;
            UnityEngine.Debug.Log("limes: " + count);
        }
    }

    private void CheckCount()
    {

    }
}
