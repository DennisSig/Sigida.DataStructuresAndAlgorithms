using DataStructures.Collections;
using DoublyLinkedList.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.Controller
{
    internal class DepotController : IEnumerable
    {
        private Depot _depot;
        public DepotController(Depot depot)
        {
            _depot = depot;
        }

        /// <summary>
        /// Возвращает информацию о автобусах находящихся в депо
        /// </summary>
        public DoublyLinkedList<Bus> InfoAboutBusesAtTheDepo => _depot.BusesInTheDepot;
        /// <summary>
        /// Возвращает информацию о автобусах находящихся на маршруте
        /// </summary>
        public DoublyLinkedList<Bus> InfoAboutBusesOnTheRoute => _depot.BusesOnRoute;

        /// <summary>
        /// Добавляет новый автобус в депо
        /// </summary>
        /// <param name="bus">Объект автобуса</param>
        public void AddBus(Bus bus)
        {
            if (bus != null)
                _depot.BusesInTheDepot.AddToEnd(bus);
            else
                throw new ArgumentNullException();
        }
        /// <summary>
        /// Отправляет автобус в путь
        /// </summary>
        /// <param name="bus"></param>
        public void TransferTheBusToTheRoute(int index)
        {
            //if (index <= 0 || index > _depot.BusesInTheDepot.Count)
            //    throw new ArgumentException("Индекс равен нулю или выходит за пределы массива");

            var indexInList = 1;
            var currentBus = _depot.BusesInTheDepot.Front;
            while (currentBus.Next != null & currentBus.Data.BusID != index)
            {
                currentBus = currentBus.Next;
                indexInList++;
            }

            _depot.BusesInTheDepot.DeleteByIndex(indexInList);
            _depot.BusesOnRoute.AddToEnd(currentBus.Data);


        }

        public void TransferTheBusToDepot(int index)
        {
            //if (index <= 0 || index > _depot.BusesInTheDepot.Count)
            //    throw new ArgumentException("Индекс равен нулю или выходит за пределы массива");

            var indexInList = 1;
            var currentBus = _depot.BusesOnRoute.Front;
            while (currentBus.Next != null & currentBus.Data.BusID != index)
            {
                currentBus = currentBus.Next;
                indexInList++;
            }

            _depot.BusesOnRoute.DeleteByIndex(indexInList);
            _depot.BusesInTheDepot.AddToEnd(currentBus.Data);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _depot.BusesInTheDepot)
            {
                yield return item;
            }
        }
    }
}
