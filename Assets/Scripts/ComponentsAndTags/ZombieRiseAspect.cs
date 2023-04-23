using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace ComponentsAndTags
{
    public readonly partial struct ZombieRiseAspect:IAspect
    {
        public readonly Entity Entity;
        private readonly TransformAspect _transformAspect;
        private readonly RefRO<ZombieRiseRate> _zombieRiseRate;

        public void Rise(float deltaTime)
        {
            _transformAspect.Position += math.up() * _zombieRiseRate.ValueRO.Value * deltaTime;
        }
    }
}