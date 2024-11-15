﻿using System.Collections.Generic;

namespace GenericCollections
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        //method for calculate the total price of the order
        public decimal Total()
        {
            decimal total = 0;
            foreach(var item in _orderItems)
            {
                total += item.Price;
            }
            return total;
        }

        public override string ToString()
        {

            return ($"Order {orderIdCounter}:" +
                $"Amount: {_tableNumber}, Total: {Total}, {_orderItems}");
        }
    }

}
