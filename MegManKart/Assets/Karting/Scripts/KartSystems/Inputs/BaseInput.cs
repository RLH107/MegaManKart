using UnityEngine;

namespace KartGame.KartSystems
{
    public struct InputData
    {
        public bool Accelerate, WASDAccelerate;
        public bool Brake, WASDBrake;
        public float TurnInputP1, TurnInputP2;
    }

    public interface IInput
    {
        InputData GenerateInput();
    }

    public abstract class BaseInput : MonoBehaviour, IInput
    {
        /// <summary>
        /// Override this function to generate an XY input that can be used to steer and control the car.
        /// </summary>
        public abstract InputData GenerateInput();
    }
}
