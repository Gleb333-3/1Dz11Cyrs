using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using System.Linq;

public class Postprocessefffectcontroller : MonoBehaviour
{
    private PostProcessVolume _activeVolume;

    protected void Awake()
    {
        var postProcessValumes = new List<PostProcessVolume>();
        PostProcessManager.instance.GetActiveVolumes(layer: GetComponent<PostProcessLayer>(), postProcessValumes);
        _activeVolume = postProcessValumes.First();
    }

    protected void Start()
    {
        Vignette vignette;
        if(!_activeVolume.profile.TryGetSettings(out vignette))
        {
            vignette = _activeVolume.profile.AddSettings<Vignette>();
        }
        vignette.color.value = Color.red;
        vignette.intensity.value = 0.0f;
    }

  
}
