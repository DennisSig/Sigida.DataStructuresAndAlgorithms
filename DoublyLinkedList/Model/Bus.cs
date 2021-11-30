using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    internal class Bus
    {
        private int _busId;
        private string _fullNameOfTheDriver;
        private int _routeNumber;

        public Bus(int busID, string fullname, int routeNumber)
        {
            _busId = busID;
            _fullNameOfTheDriver = fullname;
            _routeNumber = routeNumber;
        }

        public int BusID => _busId;
        public string Fullname => _fullNameOfTheDriver;
        public int RouteNumber => _routeNumber;

        public override string ToString()
        {
            return $"ID{_busId}|Имя водителя:{_fullNameOfTheDriver}|Номер пути:{_routeNumber}";
        }
    }
}
