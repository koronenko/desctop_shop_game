using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Desctop_User
{
    partial interface ICartState
    {
        ICartState Transition(
            Func<CartStateEmpty, ICartState> cartStateEmpty,
            Func<CartStateActive, ICartState> cartStateActive,
            Func<CartStatePaid, ICartState> cartStatePaid
            );
    }

    class CartStateEmpty : ICartState
    {
        ICartState ICartState.Transition(
            Func<CartStateEmpty, ICartState> cartStateEmpty,
            Func<CartStateActive, ICartState> cartStateActive,
            Func<CartStatePaid, ICartState> cartStatePaid
            )
        {
            // I'm the empty state, so invoke cartStateEmpty
            return cartStateEmpty(this);
        }
    }

    class CartStateActive : ICartState
    {
        ICartState ICartState.Transition(
            Func<CartStateEmpty, ICartState> cartStateEmpty,
            Func<CartStateActive, ICartState> cartStateActive,
            Func<CartStatePaid, ICartState> cartStatePaid
            )
        {
            // I'm the active state, so invoke cartStateActive 		
            return cartStateActive(this);
        }
    }

    class CartStatePaid : ICartState
    {
        ICartState ICartState.Transition(
            Func<CartStateEmpty, ICartState> cartStateEmpty,
            Func<CartStateActive, ICartState> cartStateActive,
            Func<CartStatePaid, ICartState> cartStatePaid
            )
        {
            // I'm the paid state, so invoke cartStatePaid 		
            return cartStatePaid(this);
        }
    }
}
