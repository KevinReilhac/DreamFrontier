using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyRoutine : VersionedMonoBehaviour
{
    private IAstarAI _ai = null;
    [SerializeField] private List<Transform> points = null;
    [SerializeField] private float waitAtPoint = 1f;

    private int _index = 0;

    private void OnEnable()
    {
        if (points.Count == 0)
        {
            Debug.LogError(name += " need routine points", this);
            enabled = false;
            return;
        }

        _ai = GetComponent<IAstarAI>();
        if (_ai != null)
            _ai.onSearchPath += Update;
    }

    private void OnDisable()
    {
        if (_ai != null)
            _ai.onSearchPath -= Update;
    }

    private void Update()
    {
        _ai.destination = points[_index].position;

        if (_ai.reachedDestination)
        {
            if (!isWait)
                StartCoroutine(WaitAtPointCoroutine());
        }
    }

    private bool isWait = false;
    private IEnumerator WaitAtPointCoroutine()
    {
        isWait = true;
        yield return new WaitForSeconds(waitAtPoint);
        _index += 1;
        if (_index == points.Count)
            _index = 0;
        isWait = false;
    }
}
