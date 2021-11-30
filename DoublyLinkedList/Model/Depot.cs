using DataStructures.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Model
{
    internal class Depot
    {
        public readonly string DepoName;
        public Depot(string depoName)
        {
            BusesInTheDepot = new DoublyLinkedList<Bus>();
            BusesOnRoute = new DoublyLinkedList<Bus>();
            DepoName = depoName;
        }
        public DoublyLinkedList<Bus> BusesInTheDepot { get; set; }
        public DoublyLinkedList<Bus> BusesOnRoute { get; set; }
    }
}
