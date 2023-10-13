using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove = null)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                float currentCartPrice = 0f;
                foreach (var item in _cartItems)
                {
                    currentCartPrice += item.Article.Price * item.Quantity;
                }
                return currentCartPrice;
            }
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
