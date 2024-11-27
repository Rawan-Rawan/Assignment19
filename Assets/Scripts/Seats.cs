using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seats : MonoBehaviour
{
    public Transform rotationCenter;
    public float seatRotationDiameter = 2.7f;
    public float seatAngle = 0f;
    public float rotationSpeed = 1f;
    public float angleOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "seat1") angleOffset = 10;
        if (this.gameObject.name == "seat2") angleOffset = 20;
        if (this.gameObject.name == "seat3") angleOffset = 30;
        if (this.gameObject.name == "seat4") angleOffset = 40;
        if (this.gameObject.name == "seat5") angleOffset = 50;

        seatAngle += rotationSpeed * Time.deltaTime;
        float zNew = rotationCenter.position.z + seatRotationDiameter * Mathf.Cos(seatAngle + angleOffset);
        float yNew = rotationCenter.position.y + seatRotationDiameter * Mathf.Sin(seatAngle + angleOffset);

        transform.position = new Vector3(transform.position.x, yNew, zNew);

    }
}
