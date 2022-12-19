import React from 'react'
import { NavLink } from 'react-router-dom'
import MenuIcon from '../Components/MenuIcon'
const Navbar = () => {
  return (
    <nav className='navbar container'>
        
    <NavLink className='Logo' to="/" end >Fixxo.</NavLink>
   

    <div className='navbar-links'> 
            <NavLink className="navbar-link"  to="/" end>Home</NavLink>
            <NavLink className="navbar-link"  to="/categories" end>Categories</NavLink>
            <NavLink className="navbar-link"  to="/products" end>Products</NavLink>
            <NavLink className="navbar-link"  to="/contacts" end>Contacts</NavLink>
    </div>

    <div className='navbar-icons'>
        <MenuIcon link="/search" icon="fa-regular fa-magnifying-glass"/>
        <MenuIcon link="/compare" icon="fa-regular fa-retweet"/>
        <MenuIcon quantity="3" link="/wishlist" icon="fa-regular fa-heart"/>
        <MenuIcon quantity="4" link="/shoppingcart" icon="fa-regular fa-bag-shopping"/>
    
    </div>
</nav>

  )
}

export default Navbar