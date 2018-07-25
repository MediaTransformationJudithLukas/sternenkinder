using UnityEngine;
using System.Collections;

public class geh : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current;

    void Update()
    {
		// wenn die Position des Objekts nicht gleich der Position des Targets ist
        if (transform.position != target[current].position)
        {
			//Objekt bewegt sich in einer festgelegten Zeit auf der Z-Achse von Startposition zu Targetposition
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else current = (current + 1) % target.Length;
    }
}