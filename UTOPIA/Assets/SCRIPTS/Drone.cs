using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

/*public class Drone : MonoBehaviour
{
   public Team Team;
   [SerializeField] private Team _team;
   [SerializeField] private LayerMask _layerMask;

   private float _attackRange = 3.0f;
   private float _rayDistance = 5.0f;
   private float _stoppingDistance = 5f;

   private Vector3 _destination;
   private Quaternion _desiredRotation;
   private Vector3 _direction;
   private Drone _target;
   private DroneState _currentState;



    // Update is called once per frame
    private void Update()
    {
        switch (_currentState)
        {
            case DroneState.Wander:
            {
                if (NeedsDestination())
                {
                    GetDestination();
                }
                transform.rotation = _desiredRotation;

                transform.Translate(translation: Vector3.forward * Time.deltaTime * 5f);

                Debug.DrawRay(start: transform.position, dir: _direction * _rayDistance);

                while (IsPathBlocked())
                {
                    Debug.Log(message: "Path blocked");
                    GetDestination();
                }

                var targetToAggro = CheckForAggro();
                if (targetToAggro != null)
                {
                    _target = targetToAggro.GetComponent<Drone>();
                    _currentState = DroneState.Chase;
                }
                break;
            }
            case DroneState.Chase:
            {
                if(_target==null)
                {
                    _currentState = DroneState.Wander;
                    return;
                }
                transform.LookAt(_target.transform);
                transform.Translate(translation: Vector3.forward * Time.deltaTime * 5f);

                if (Vector3.Distance(a: transform.position, b: transform.position) < _attackRange)
                {
                    _currentState = DroneState.Attack;
                }
                break;
            }
            case DroneState.Attack:
            {
                if (_target != null)
                {
                    Destroy(_target.GameObject);
                }
                _currentState = DroneState.Wander;
                break;
            }
        }
    }

private bool IsPathBlocked() 
{
    Ray ray = new Ray(origin: transform.position, _direction);
    var hitSomething = Physics.Raycast(ray, _rayDistance, _layerMask);
    return hitSomething.Any();
}

private void GetDestination()
{
    Vector3 testPosition = (transform.position + (transform.forward) * 4f) + new Vector3(x: UnityEngine.Random.Range(-4.5f, 4.5f), y:0f, z: UnityEngine.Random.Range(-4.5f, 4.5f));
    
    _destination = new Vector3(testPosition.x, y: 1f, testPosition.z);

    _direction= Vector3.Normalize(_destination - transform.position);
    _direction= new Vector3(_direction.x, y: 0f, _direction.z);
    _desiredRotation= Quaternion.LookRotation(_direction);
}

private bool NeedsDestination()
{
    if (_destination == Vector3.zero)
    return true;

    var distance = Vector3.Distance( a: transform.position, b:_destination);
    if (distance <= _stoppingDistance)
    {
        return true;
    }
    return false;
}

new Quarternion startingAngle = Quaternion.AngleAxis(angle: -60, Vector3.up);
new Quarternion stepAngle = Quaternion.AngleAxis(angle: 5, Vector3.up);

private Transform CheckForAggro()
{
    float aggroRadius = 5f;

    RaycastHit hit;
    var angle = transform.rotation * startingAngle;
    var direction = angle * Vector3.forward;
    var pos = transform.position;
    for (var i = 0; i < 24; i++)
    {
        if (Physics.Raycast(origin: pos, direction, out hit, aggroRadius))
        {
            var drone = hit.collider.GetComponent<Drone>();
            if (drone != null && drone.Team != gameObject.GetComponent<Drone>().Team)
            {
                return drone.transform;
            }
            else
            {
                Debug.Log("I REMOVED RAYCAST Colour");
            }
        }
    }
}

public enum Team 
{
    Red,
    Blue
}

public enum DroneState 
{
    Wander,
    Chase,
    Attack
}
}
*/