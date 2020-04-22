using UnityEngine;
using UnityEngine.AI;

namespace Armmy
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class ArmmyController : MonoBehaviour
    {
        [SerializeField]
        ArmmyConfig config = default;

        static float PlacementDistance = 6f;
        void Start()
        {
            Vector3 placement = Vector3.zero;
            var referenceValue = Mathf.Sqrt(this.config.Menber);
            for (int i = 0; i < this.config.Menber; i++)
            {
                placement.x = Mathf.Floor(i / referenceValue);
                placement.z = i % referenceValue;
                Instantiate(config.Solder, this.transform.position + placement * PlacementDistance, Quaternion.identity, this.transform);
            }
        }
    }
}
