using MotionCard.Core;
using MotionCard.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.VendorAxis
{
    class GoogoltechAxis : AxisBase
    {

        public GoogoltechAxis(string axisName) : base(axisName)
        {

        }

        public string Discription { get; set; }

        public decimal Price { get; set; }


        public override void AbsoluteMove(double targetPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void CheckAxisArrived()
        {
            throw new NotImplementedException();
        }

        public override void CLearAlarm()
        {
            throw new NotImplementedException();
        }

        public override void Enable(bool enable)
        {
            throw new NotImplementedException();
        }

        public override double GetCurrentPosition()
        {
            throw new NotImplementedException();
        }

        public override StopReason GetStopReason()
        {
            throw new NotImplementedException();
        }

        public override Velocity GetVelocity()
        {
            throw new NotImplementedException();
        }

        public override bool HasHomed()
        {
            throw new NotImplementedException();
        }

        public override void Home()
        {
            throw new NotImplementedException();
        }

        public override bool IsAlarming()
        {
            throw new NotImplementedException();
        }

        public override bool IsEnabled()
        {
            throw new NotImplementedException();
        }

        public override bool IsMoving()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnLmtN()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnLmtP()
        {
            throw new NotImplementedException();
        }

        public override bool IsOnOrg()
        {
            throw new NotImplementedException();
        }

        public override bool IsReady()
        {
            throw new NotImplementedException();
        }

        public override void Jog(Velocity velocity)
        {
            throw new NotImplementedException();
        }

        public override void MoveToCalibrationPosition(string calibrationPositionName, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void RelativeMove(double deltaPosition, Velocity velocity, bool waitStopped = true, double timeoutSeconds = double.PositiveInfinity, StopReason expectedStopReason = StopReason.Normal)
        {
            throw new NotImplementedException();
        }

        public override void SetVelocity(Velocity velocity)
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
