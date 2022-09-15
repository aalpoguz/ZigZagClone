using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGroundObject;

    [SerializeField] private GameObject groundPrefab;
    private GameObject newGroundObject;

    private int groundDirection;



    void Start()
    {
        GenerateNewGrounds();
    }

    public void GenerateNewGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            createNewGround();
        }
    }

    private void createNewGround()
    {
        groundDirection = Random.Range(0, 2); //0 dahil olur 2 dahil olmaz

        if (groundDirection == 0)
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y,
            lastGroundObject.transform.position.z), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y,
            lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
}
