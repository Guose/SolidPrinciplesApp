using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.SOLID.DIP
{
    // DEPENDENCY INVERSION PRINCIPAL

    public interface IRemoteControlService
    {
        void PressOnButton();
    }

    public interface ITVService
    {
        void TurnOn();
    }

    public class RemoteControlService : IRemoteControlService
    {
        private readonly ITVService _tvService;

        public RemoteControlService(ITVService tvService)
        {
            _tvService = tvService;
        }

        public void PressOnButton()
        {
            _tvService.TurnOn();
        }
    }
}
