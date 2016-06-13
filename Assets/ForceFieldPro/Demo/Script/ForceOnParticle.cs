using UnityEngine;
using System.Collections;

/// <summary>
/// Attach this script on a particle system.
/// All its and its children's particles will be affected by the target force field.
/// </summary>
public class ForceOnParticle : MonoBehaviour
{
    [FFToolTip("The force field that will be used.")]
    public ForceField field_01;
	public ForceField field_02;
	public ForceField field_03;

    [FFToolTip("Modifier of the force.")]
    public float factor = 1;

    ParticleEmitter[] pes;
    ParticleSystem[] pss;

    // Use this for initialization
    void Start()
    {
        pes = GetComponentsInChildren<ParticleEmitter>(true);
        pss = GetComponentsInChildren<ParticleSystem>(true);
    }

    void Update()
    {
		if (field_01 != null) {
				foreach (ParticleEmitter pe in pes) {
					Transform t = pe.transform;
					Particle[] particles = pe.particles;
					int num = particles.Length;
					for (int i = 0; i < num; i++) {
						Vector3 force;
						if (!pe.useWorldSpace) {
						force = t.InverseTransformDirection (field_01.GetForce (t.TransformPoint (particles [i].position)));
						} else {
						force = field_01.GetForce (particles [i].position);
						}
						particles [i].velocity += force * factor;
					}
					pe.particles = particles;
				}
				foreach (ParticleSystem ps in pss) {
					Transform t = ps.transform;
					ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.maxParticles];
					int num = ps.GetParticles (particles);
					for (int i = 0; i < num; i++) {
						Vector3 force;
						if (ps.simulationSpace == ParticleSystemSimulationSpace.Local) {
						force = t.InverseTransformDirection (field_01.GetForce (t.TransformPoint (particles [i].position)));
						} else {
						force = field_01.GetForce (particles [i].position);
						}
						particles [i].velocity += force * factor;
					}
					ps.SetParticles (particles, num);
				}
			}
		if (field_02 != null) {
			foreach (ParticleEmitter pe in pes) {
				Transform t = pe.transform;
				Particle[] particles = pe.particles;
				int num = particles.Length;
				for (int i = 0; i < num; i++) {
					Vector3 force;
					if (!pe.useWorldSpace) {
						force = t.InverseTransformDirection (field_02.GetForce (t.TransformPoint (particles [i].position)));
					} else {
						force = field_02.GetForce (particles [i].position);
					}
					particles [i].velocity += force * factor;
				}
				pe.particles = particles;
			}
			foreach (ParticleSystem ps in pss) {
				Transform t = ps.transform;
				ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.maxParticles];
				int num = ps.GetParticles (particles);
				for (int i = 0; i < num; i++) {
					Vector3 force;
					if (ps.simulationSpace == ParticleSystemSimulationSpace.Local) {
						force = t.InverseTransformDirection (field_02.GetForce (t.TransformPoint (particles [i].position)));
					} else {
						force = field_02.GetForce (particles [i].position);
					}
					particles [i].velocity += force * factor;
				}
				ps.SetParticles (particles, num);
			}
		}
		if (field_03 != null) {
			foreach (ParticleEmitter pe in pes) {
				Transform t = pe.transform;
				Particle[] particles = pe.particles;
				int num = particles.Length;
				for (int i = 0; i < num; i++) {
					Vector3 force;
					if (!pe.useWorldSpace) {
						force = t.InverseTransformDirection (field_03.GetForce (t.TransformPoint (particles [i].position)));
					} else {
						force = field_03.GetForce (particles [i].position);
					}
					particles [i].velocity += force * factor;
				}
				pe.particles = particles;
			}
			foreach (ParticleSystem ps in pss) {
				Transform t = ps.transform;
				ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.maxParticles];
				int num = ps.GetParticles (particles);
				for (int i = 0; i < num; i++) {
					Vector3 force;
					if (ps.simulationSpace == ParticleSystemSimulationSpace.Local) {
						force = t.InverseTransformDirection (field_03.GetForce (t.TransformPoint (particles [i].position)));
					} else {
						force = field_03.GetForce (particles [i].position);
					}
					particles [i].velocity += force * factor;
				}
				ps.SetParticles (particles, num);
			}
		}
    }

}
