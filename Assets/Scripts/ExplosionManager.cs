using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    public delegate void DestruirExplosion();
    public event DestruirExplosion MuerteExplosion;
    public static ExplosionManager instance;
    void Awake()
    {
        instance = this;
    }
    public void ActivarMuerteExplosion()
    {
        MuerteExplosion?.Invoke();
    }
}
