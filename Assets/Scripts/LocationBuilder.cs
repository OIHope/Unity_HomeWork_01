using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    [SerializeField] private string groundName;
    [SerializeField] private Material groundMaterial;
    [SerializeField] private Vector3 groundPosition;
    [SerializeField] private Vector3 groundSize;

    [Space(15)]

    [SerializeField] private string playerName;
    [SerializeField] private Material playerMaterial;
    [SerializeField] private Vector3 playerPosition;
    [SerializeField] private Vector3 playerSize;
    [SerializeField][Range(0,5f)] private float playerDrag;

    [Space(15)]

    [SerializeField] private string enemyName;
    [SerializeField] private Material enemyMaterial;
    [SerializeField] private Vector3 enemyPosition;
    [SerializeField] private Vector3 enemySize;
    [SerializeField][Range(0, 5f)] private float enemyDrag;

    [Space(15)]

    [SerializeField] private string coinName;
    [SerializeField] private Material coinMaterial;
    [SerializeField] private Vector3 coinPosition;
    [SerializeField] private Vector3 coinSize;
    [SerializeField][Range(0, 5f)] private float coinDrag;

    void Start()
    {

        GameObject Ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Ground.name = groundName;
        Ground.transform.position = groundPosition;
        Ground.transform.localScale = groundSize;
        Ground.GetComponent<MeshRenderer>().material = groundMaterial;

        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Player.name = playerName;
        Player.transform.position = playerPosition;
        Player.transform.localScale = playerSize;
        Player.GetComponent<MeshRenderer>().material = playerMaterial;
        Player.AddComponent<Rigidbody>();
        Player.GetComponent<Rigidbody>().drag = playerDrag;
        Player.AddComponent<PlayerControl>();

        GameObject Enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Enemy.name = enemyName;
        Enemy.tag = "Enemy";
        Enemy.transform.position = enemyPosition;
        Enemy.transform.localScale = enemySize;
        Enemy.GetComponent<MeshRenderer>().material = enemyMaterial;
        Enemy.AddComponent<Rigidbody>();
        Enemy.GetComponent <Rigidbody>().drag = enemyDrag;

        GameObject Coin = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Coin.name = coinName;
        Coin.tag = "Collectable";
        Coin.transform.position = coinPosition;
        Coin.transform.localScale = coinSize;
        Coin.GetComponent<MeshRenderer>().material = coinMaterial;
        Coin.AddComponent<Rigidbody>();
        Coin.GetComponent<Rigidbody>().drag = coinDrag;
        Coin.AddComponent<BoxCollider>();
        Coin.GetComponent<BoxCollider>().isTrigger = true;
    }
}
