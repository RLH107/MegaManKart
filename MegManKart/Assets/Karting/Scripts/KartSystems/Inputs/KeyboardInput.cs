using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        //public string TurnInputName = "Horizontal";
        //public string AccelerateButtonName = "Accelerate";
        //public string BrakeButtonName = "Brake";

        public override InputData GenerateInput() {
            return new InputData
            {
                Accelerate = Input.GetButton("Accelerate"),
                WASDAccelerate = Input.GetButton("WASDAccelerate"),
                Brake = Input.GetButton("Brake"),
                WASDBrake = Input.GetButton("WASDBrake"),
                TurnInputP1 = Input.GetAxis("Horizontal"),
                TurnInputP2 = Input.GetAxis("WASDHorizontal")
            };
        }
    }
}
