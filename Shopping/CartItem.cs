using System.Net.Http.Headers;

namespace Shopping
{
    public class CartItem
    {
        #region private attributes
        private Article? _article = null;
        private int _quantity = 0;
        #endregion private attributes

        #region public methods
        public CartItem(Article article, int quantity)
        {
            _quantity = quantity;
            for (int  i = 0; i < _quantity; i++)
            {
                _article = article;
            }
        }

        public Article Article
        {
            get
            {
                return _article;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new WrongQuantityException();
                }
            }
        }
        #endregion public methods

        public class CartItemException : Exception { }
        public class WrongQuantityException : CartItemException { }
    }
}
