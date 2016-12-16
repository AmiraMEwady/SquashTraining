using UnityEngine;
using System.Collections;

public class EggMover : MonoBehaviour 
{
    
    public GameObject squashBall;
    // public int numberOfBalls;
    public int minY;
    public int maxY;
    public int minX;
    public int maxX;
    


    void Start()
    {
        GenerateBalls();

    }
    void Update()
    {

    }


    void GenerateBalls()
    {
        
            Instantiate(squashBall, GeneratedPosition(), Quaternion.identity);
        Invoke("GenerateBalls", 5);

    }
    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = UnityEngine.Random.Range(minX, maxX);
       y = UnityEngine.Random.Range(minY, maxY);
        z = 25;

        return new Vector3(x, y, z);
    }











  /*  public Vector3 spawnLocation;
    public GameObject squashBall;
    public GameObject[] sqashBallPrefabs;
    int[] randomNumber = new int[50];


    // Use this for initialization
    void Start()
    {
        while (true)
        {
            generateSquashBalls();


            Invoke("generateSquashBalls", 100.0f);

        }
    }

    // Update is called once per frame
    void Update()
    {


       //generateSquashBalls();

    }

public void generateSquashBalls()
{

    int randomX = Random.Range(0, randomNumber.Length);
    Vector3 locations = new Vector3(randomNumber[randomX], Random.Range(0, 25), 25.5f);
 
        Instantiate(squashBall, locations, Quaternion.identity);
}*/









}