using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Camera mainCamera;
    private bool isMoving = false;
    private Vector3 targetPosition;

    public float moveSpeed = 5f; // �̵� �ӵ� ����

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                isMoving = true;
               transform.LookAt(targetPosition);
            }
        }

        if (isMoving)
        {
            MoveTowardsTarget();
        }
    }

    private void MoveTowardsTarget()
    {
        Vector3 moveDirection = targetPosition - transform.position;
        moveDirection.y = 0; // y ���� �������� �ʵ��� �մϴ�.
        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;

        // ��ǥ ������ �������� �� �̵��� ����ϴ�.
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }
}
