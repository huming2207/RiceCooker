using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceCooker.Desktop.ViewModel
{
    public class Gateway
    {
        public Gateway()
        {
            Devices = new ObservableCollection<Device>();
        }

        public string GatewayId { get; set; }
        public string GatewayIpAddr { get; set; }
        public ObservableCollection<Device> Devices { get; set; }
    }
}
