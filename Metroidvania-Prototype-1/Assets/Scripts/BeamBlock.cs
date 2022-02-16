using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BeamBlock : MonoBehaviour
{
    [SerializeField] private Tilemap map;
    [SerializeField] private TileBase empty;
    [SerializeField] private TileBase original;

    internal void Disappear(Vector3Int position)
    {
        map.SetTile(position, empty);
        StartCoroutine(Regenerate(position));
    }

    IEnumerator Regenerate(Vector3Int position)
    {
        yield return new WaitForSeconds(5);
        map.SetTile(position, original);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
