using UnityEngine;
using UnityEngine.Video;

public class TVRemoteControl : MonoBehaviour
{
    [SerializeField] private VideoPlayer _tv;
    [SerializeField] private MeshRenderer _screenMesh;
    [SerializeField] private Material _videoMaterial;
    [SerializeField] private Material _blackMaterial;

    private void Awake()
    {
        TurnOff();
    }

    public void Turn() 
    {
        if (_tv.isPlaying)
            TurnOff();
        else
            TurnOn();
    }

    private void TurnOn()
    {
        _tv.Play();
        _screenMesh.material = _videoMaterial;
    }

    private void TurnOff()
    {
        _tv.Stop();
        _screenMesh.material = _blackMaterial;
    }
}
