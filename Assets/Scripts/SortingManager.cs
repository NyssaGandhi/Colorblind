using UnityEngine;
using UnityEngine.SceneManagement;

public class SortingManager : MonoBehaviour
{
    public GameObject[] fruits;
    public int numLemons;
    public int numLimes;
    public int numOranges;
    public GameObject spawn;
    public GameObject orangeBasket;
    public GameObject lemonBasket;
    public GameObject limeBasket;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randInt = Random.Range(1, 5);
        numLemons = randInt;
        randInt = Random.Range(1, 5);
        numOranges = randInt;
        randInt = Random.Range(1, 5);
        numLimes = randInt;

        Vector3 offsetLocation = Vector3.zero;
        for(int i = 0; i < numLemons; i++)
        {
            offsetLocation = new Vector3(
            Random.Range(-1, 1),
            Random.Range(-1, 1),
            Random.Range(-1, 1) );
            Instantiate( fruits[0], spawn.transform.position, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f) );
        }
        for (int i = 0; i < numLimes; i++)
        {
            offsetLocation = new Vector3(
            Random.Range(-1, 1),
            Random.Range(-1, 1),
            Random.Range(-1, 1));
            Instantiate( fruits[1], spawn.transform.position, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f) );
        }
        for (int i = 0; i < numOranges; i++)
        {
            offsetLocation = new Vector3(
            Random.Range(-1, 1),
            Random.Range(-1, 1),
            Random.Range(-1, 1));
            Instantiate( fruits[2], spawn.transform.position, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f) );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(orangeBasket.GetComponent<CountFruit>().count == numOranges && lemonBasket.GetComponent<CountFruit>().count == numLemons && limeBasket.GetComponent<CountFruit>().count == numLimes)
        {


            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
